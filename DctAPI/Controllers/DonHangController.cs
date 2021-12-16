﻿using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// M Quân: Ai làm CRUD đơn hàng thì cứ làm trên file này nha, tui làm phần xác nhận với huỷ đơn trước

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private readonly IDonHangRepository donHangRepo;
        private readonly IKhachHangRepository khachHangRepo;
        //private ISanPhamRepository sanPhamRepo;
        //private IChiTietDonHangRepository chiTietDonHangRepo;

        public DonHangController(IDonHangRepository donHangRepo1,IKhachHangRepository khachHangRepo1)
        {
            this.donHangRepo = donHangRepo;
            this.khachHangRepo = khachHangRepo1;
           
        }

        // GET: api/<DonHangController>
        [HttpGet]
        public IEnumerable<KhachhangEntity> Get()
        {
            return donHangRepo.GetAll();
        }

        // GET api/<DonHangController>/5
        [HttpGet("{id}")]
        public IEnumerable<KhachhangEntity> Get(int id)
        {
            return khachHangRepo.GetAll();
        }

        // POST api/<DonHangController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DonHangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DonHangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/<DonHangController>/{id}/XacNhan/{shipperId}
        [HttpPost("{id}/ShipperXacNhan/{shipperId}")]
        public async Task<ActionResult<KhachhangEntity>> ShipperXacNhanDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.Find(id);
            //var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null 
                //&& shipper != null
                )
            {
                if (donHang.TTDH.ID != (int)TrangThaiDonHang.ChoXacNhan 
                    //&& shipper.KichHoat
                    )
                {
                    //var _donHang = await donHangRepo.ShipperXacNhanDonHang(donHang, shipper);
                    //if (_donHang != null) {
                    //    return Ok();
                    //}
                }
            }
            return BadRequest();
        }

        // POST api/<DonHangController>/{id}/Huy/{shipperId}
        [HttpPost("{id}/Huy/{shipperId}")]
        public async Task<ActionResult<KhachhangEntity>> ShipperHuyDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.Find(id);
            //var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null 
                //&& shipper != null
                )
            {
                if ((donHang.TTDH.ID == (int)TrangThaiDonHang.DangLayHang
                    || donHang.TTDH.ID == (int)TrangThaiDonHang.DangGiaoHang)
                //&& shipper.KichHoat
                )
                {
                    //var _donHang = await donHangRepo.ShipperHuyDonHang(donHang, shipper);
                    //if (_donHang != null)
                    //{
                    //    return Ok();
                    //}
                }
            }
            return BadRequest();
        }
    

    }
}
