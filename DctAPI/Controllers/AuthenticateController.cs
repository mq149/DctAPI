using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using DctAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<UserEntity> _userManage;
        private readonly RoleManager<RoleEntity> _roleManage;
        private readonly IConfiguration _configuration;

        public AuthenticateController(UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManage, IConfiguration configuration)
        {
            _userManage = userManager;
            _roleManage = roleManage;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("RegisterCustomer")]
        public async Task<IActionResult> RegisterCustomer([FromBody] RegisteModel model) {
            var userExits = await _userManage.FindByNameAsync(model.username);
            if (userExits != null) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "User already exits" });
            }
            UserEntity userNew = new UserEntity() {
                UserName = model.username,
                SDT = model.username,
                Email = model.email,
            };
            var result = await _userManage.CreateAsync(userNew, model.password);
            if (!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "Create user faild" });
            }
            //set role for user
            if (!await _roleManage.RoleExistsAsync(RoleName.Customer)) {
                await _roleManage.CreateAsync(new RoleEntity() { Id = (int)Role.KhachHang, Name = "Customer", Ten = "Khach Hang" });
            }
            await _userManage.AddToRoleAsync(userNew,RoleName.Customer);
            return Ok(new Response { status = "Success", message = "User created successfully" });

        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model) {
            var userExits = await _userManage.FindByNameAsync(model.username);
            if(userExits!=null&& await _userManage.CheckPasswordAsync(userExits,model.password) ) {
                var userRole = await _userManage.GetRolesAsync(userExits);
                var auth = new List<Claim> {
                    new Claim(ClaimTypes.Name,userExits.UserName),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };
                foreach(var itm in userRole) {
                    auth.Add(new Claim(ClaimTypes.Role, itm));
                }
                var authLoginKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(1),
                    claims:auth,
                    signingCredentials: new SigningCredentials(authLoginKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new {
                    Id = userExits.Id,
                    SDT = userExits.SDT,
                    HoTen = userExits.HoTen,
                    GioiTinh = userExits.GioiTinh,
                    NgaySinh = userExits.NgaySinh,
                    AvatarId = userExits.AvatarId,
                    DiaChiId = userExits.DiaChiId,
                    username=userExits.SDT,
                    password=userExits.PasswordHash,
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    role=userRole,
                    expires=1,
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("LoginAccessToken")]
        public async Task<UserEntity> LoginAccessToken(string accessToken) {
            try {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]);

                var tokenValidationParameters = new TokenValidationParameters {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                SecurityToken securityToken;
                var principle = tokenHandler.ValidateToken(accessToken, tokenValidationParameters, out securityToken);

                JwtSecurityToken jwtSecurityToken = securityToken as JwtSecurityToken;

                if (jwtSecurityToken != null && jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase)) {
                    var userId = principle.FindFirst(ClaimTypes.Name)?.Value;
                    return await _userManage.FindByNameAsync(userId);
                }
            }
            catch (Exception) {
                return new UserEntity();
            }

            return new UserEntity();
        }
    }
}
