using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DctAPI.Models.Users;
using DctApi.Shared.Models;
using DctAPI.Repositories.Implements;
using Microsoft.AspNetCore.Identity;
using DctAPI.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using DctApi.Shared.Enums;

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperRepository shipperRepo;
        private readonly UserManager<UserEntity> userManager;
        private readonly RoleManager<RoleEntity> roleManager;
        private readonly IConfiguration configuration;

        public ShipperController(IShipperRepository shipperRepo,
            UserManager<UserEntity> userManager,
            RoleManager<RoleEntity> roleManager,
            IConfiguration configuration)
        {
            this.shipperRepo = shipperRepo;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        // POST api/<ShipperController>
        [HttpPost("/DangNhap")]
        public async Task<ActionResult<UserEntity>> DangNhap([FromBody] ShipperDangNhapModel model)
        {
            if (string.IsNullOrEmpty(model.SDT) || string.IsNullOrEmpty(model.MatKhau))
                return StatusCode(200, "Thong tin dang nhap khong hop le");
            var user = await userManager.FindByNameAsync(model.SDT);
            if (user != null 
                && await userManager.CheckPasswordAsync(user, model.MatKhau))
            {
                var userRole = await userManager.GetRolesAsync(user);
                var auth = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };
                foreach(var item in userRole)
                {
                    auth.Add(new Claim(ClaimTypes.Role, item));
                }
                var authLoginKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]));
                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(1),
                    claims: auth,
                    signingCredentials: new SigningCredentials(authLoginKey, SecurityAlgorithms.HmacSha256)
                    );
                return Ok(new
                {
                    Id = user.Id,
                    SDT = user.SDT,
                    HoTen = user.HoTen,
                    GioiTinh = user.GioiTinh,
                    NgaySinh = user.NgaySinh,
                    AvatarId = user.AvatarId,
                    DiaChiId = user.DiaChiId,
                    username = user.SDT,
                    password = user.PasswordHash,
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    role = userRole,
                    expires = 1,
                });
            }

            return Unauthorized();
        }

        // POST api/<ShipperController>
        [HttpPost("/DangKy")]
        public async Task<ActionResult<UserEntity>> DangKy([FromBody] ShipperDangKyModel model)
        {
            var user = await userManager.FindByNameAsync(model.SDT);
            if (user != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { status = "Error", message = "Tài khoản đã tồn tại" });
            }
            UserEntity newUser = new UserEntity()
            {
                UserName = model.SDT,
                SDT = model.SDT,
                Email = ""
            };
            var result = await userManager.CreateAsync(newUser, model.MatKhau);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { status = "Error", message = "Lỗi hệ thống, vui lòng kiểm tra lại." });
            }
            //set role for user
            if (!await roleManager.RoleExistsAsync(RoleName.Shipper))
            {
                await roleManager.CreateAsync(new RoleEntity() { Id = (int)Role.Shipper, Name = "Shipper", Ten = "Shipper" });
            }
            await userManager.AddToRoleAsync(newUser, RoleName.Shipper);
            return Ok(new Response { status = "Success", message = "Đăng ký tài khoản shipper thành công" });
        }

    }
}
