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

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperRepository shipperRepo;

        public ShipperController(IShipperRepository shipperRepo)
        {
            this.shipperRepo = shipperRepo;
        }

        // POST api/<ShipperController>
        [HttpPost("/DangNhap")]
        public async Task<ActionResult<UserEntity>> DangNhap([FromBody] ShipperDangNhapModel user)
        {
            if (string.IsNullOrEmpty(user.SDT) || string.IsNullOrEmpty(user.MatKhau))
                return StatusCode(200, "Thong tin dang nhap khong hop le");
            var existingUser = await shipperRepo.Find(user.SDT);
            if (existingUser == null)
                return null;
            // TODO: Compare hashed passwords
            if (user.MatKhau != existingUser.MatKhau)
                return null;
            return existingUser;
        }

        // POST api/<ShipperController>
        [HttpPost("/DangKy")]
        public async Task<UserEntity> DangKy([FromBody] ShipperDangKyModel user)
        {
            if (string.IsNullOrWhiteSpace(user.MatKhau) || string.IsNullOrWhiteSpace(user.HoTen))
                return null;
            var existingUser = await shipperRepo.Find(user.SDT);
            if (existingUser == null)
                return null;

            // Hash user's password
            string hashed = user.MatKhau;

            // Create new user
            UserEntity newUser = new UserEntity();
            newUser.SDT = user.SDT;
            newUser.HoTen = user.HoTen;
            newUser.MatKhau = hashed;
            var _newUser = await shipperRepo.Create(newUser);
            return _newUser;
        }

    }
}
