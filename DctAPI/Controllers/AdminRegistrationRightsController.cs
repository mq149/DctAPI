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
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DctAPI.Controllers {
    [Authorize(Roles=RoleName.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminRegistrationRightsController : ControllerBase {
        private readonly UserManager<UserEntity> _userManage;
        private readonly RoleManager<RoleEntity> _roleManage;
        private readonly IConfiguration _configuration;

        public AdminRegistrationRightsController(UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManage, IConfiguration configuration) {
            _userManage = userManager;
            _roleManage = roleManage;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisteModel model) {
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
            if (!await _roleManage.RoleExistsAsync(RoleName.Admin)) {
                await _roleManage.CreateAsync(new RoleEntity() { Id = (int)Role.Admin, Name = "Admin", Ten = "Admin" });
            }
            await _userManage.AddToRoleAsync(userNew, RoleName.Admin);
            return Ok(new Response { status = "Success", message = "User created successfully" });

        }

       
    }
}
