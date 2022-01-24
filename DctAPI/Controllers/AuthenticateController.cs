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
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<RoleEntity> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthenticateController(ApplicationDbContext context,UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManage, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManage;
            _configuration = configuration;
            _context = context;
        }

        [HttpPost]
        [Route("RegisterCustomer")]
        public async Task<IActionResult> RegisterCustomer([FromBody] RegisteModel model) {
            var user = await _userManager.FindByNameAsync(model.username);
            if (user != null) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "User already exists" });
            }
            UserEntity userNew = new UserEntity() {
                UserName = model.username,
                SDT = model.username,
                Email = model.email,
            };
            var result = await _userManager.CreateAsync(userNew, model.password);
            if (!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "Create user failed" });
            }
            //set role for user
            if (!await _roleManager.RoleExistsAsync(RoleName.Customer)) {
                await _roleManager.CreateAsync(new RoleEntity() { Id = (int)Role.KhachHang, Name = "Customer", Ten = "Khach Hang" });
            }
            await _userManager.AddToRoleAsync(userNew,RoleName.Customer);
            _context.Add(new KhachHangEntity { UserId =userNew.Id, CMND=""});
            _context.SaveChanges();
            return Ok(new Response { status = "Success", message = "Tạo tài khoản thành công" });

        }

        [HttpPost]
        [Route("RegisterShipper")]
        public async Task<IActionResult> RegisterShipper([FromBody] ShipperDangKyModel model) {
            var user = await _userManager.FindByNameAsync(model.SDT);
            if (user != null) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "Số điện thoại đã được sử dụng" });
            }
            UserEntity userNew = new UserEntity() {
                UserName = model.SDT,
                SDT = model.SDT,
                Email = model.Email,
                HoTen = model.HoTen
            };
            var result = await _userManager.CreateAsync(userNew, model.MatKhau);
            if (!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "Đã xảy ra lỗi, vui lòng kiểm tra lại" });
            }
            //set role for user
            if (!await _roleManager.RoleExistsAsync(RoleName.Shipper)) {
                await _roleManager.CreateAsync(new RoleEntity() { Id = (int)Role.Shipper, Name = "Shipper", Ten = "Shipper" });
            }
            await _userManager.AddToRoleAsync(userNew, RoleName.Shipper);
            _context.Add(new ShipperEntity {UserId = userNew.Id, KichHoat = false, CMND = "", BienSo = "", DongXe = "" });
            _context.SaveChanges();
            return Ok(new Response { status = "Success", message = "Tạo tài khoản thành công" });

        }

        [HttpPost]
        [Route("RegisterStore")]
        public async Task<IActionResult> RegisterStore([FromBody] RegisteModel model) {
            var user = await _userManager.FindByNameAsync(model.username);
            if (user != null) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "User already exists" });
            }
            UserEntity userNew = new UserEntity() {
                UserName = model.username,
                SDT = model.username,
                Email = model.email,
            };
            var result = await _userManager.CreateAsync(userNew, model.password);
            if (!result.Succeeded) {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { status = "Error", message = "Create user failed" });
            }
            //set role for user
            if (!await _roleManager.RoleExistsAsync(RoleName.Store)) {
                await _roleManager.CreateAsync(new RoleEntity() { Id = (int)Role.CuaHang, Name = "CuaHang", Ten = "CuaHang" });
            }
            await _userManager.AddToRoleAsync(userNew, RoleName.Store);
            return Ok(new Response { status = "Success", message = "Tạo tài khoản thành công" });

        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model) {
            var user = await _userManager.FindByNameAsync(model.username);
            if(user!=null&& await _userManager.CheckPasswordAsync(user,model.password) ) {
                var userRole = await _userManager.GetRolesAsync(user);
                var auth = new List<Claim> {
                    new Claim(ClaimTypes.Name,user.UserName),
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
                    Id = user.Id,
                    SDT = user.SDT,
                    HoTen = user.HoTen,
                    GioiTinh = user.GioiTinh,
                    NgaySinh = user.NgaySinh,
                    AvatarId = user.AvatarId,
                    DiaChiId = user.DiaChiId,
                    username = user.SDT,
                    password = user.PasswordHash,
                    email = user.Email,
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    role = userRole,
                    expires=1,
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("LoginAccessToken")]
        public async Task<IActionResult> LoginAccessToken([FromBody]string accessToken) {
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
                    //return await _userManage.FindByNameAsync(userId);
                    var user= await _userManager.FindByNameAsync(userId);
                    var userRole = await _userManager.GetRolesAsync(user);
                    return Ok(new {
                        Id = user.Id,
                        SDT = user.SDT,
                        HoTen = user.HoTen,
                        GioiTinh = user.GioiTinh,
                        NgaySinh = user.NgaySinh,
                        AvatarId = user.AvatarId,
                        DiaChiId = user.DiaChiId,
                        username = user.SDT,
                        email=user.Email,
                        password = user.PasswordHash,
                        role = userRole,
                    });
                }
            }
            catch (Exception) {
                //return new UserEntity();
                return Unauthorized();
            }

            return Unauthorized();
        }
    }
}
