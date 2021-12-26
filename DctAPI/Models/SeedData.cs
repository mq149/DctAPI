using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Models {
    public static class SeedData {

        public static void Seed(UserManager<UserEntity> _userManage,RoleManager<RoleEntity> _roleManage) {
            SeedRole(_roleManage);
            SeedUser(_userManage);
        }

        public static void SeedUser(UserManager<UserEntity> _userManage) {
            if(_userManage.FindByNameAsync("123456789").Result==null) {
                var user = new UserEntity() {
                    UserName = "123456789",
                    NormalizedUserName = "123456789",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "123456789",
                    HoTen = "Admin",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now
                };
                var result = _userManage.CreateAsync(user, "Admin@123").Result;
                if(result.Succeeded) {
                    _userManage.AddToRoleAsync(user, RoleName.Admin).Wait();
                }
            }
        }

        public static void SeedRole(RoleManager<RoleEntity> _roleManage) {
            if(!_roleManage.RoleExistsAsync(RoleName.Admin).Result) {
                var role = new RoleEntity() {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Ten = "Admin"
                };
               _roleManage.CreateAsync(role).Wait();
            }
        }
    }
}
