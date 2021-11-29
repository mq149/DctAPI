using DctApi.Shared.Enums;
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
        private IDonHangRepository donHangRepo;

        public DonHangController(IDonHangRepository donHangRepo)
        {
            this.donHangRepo = donHangRepo;
        }

        // GET: api/<DonHangController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DonHangController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        [HttpPost("{id}/XacNhan/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> XacNhanDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.Find(id);
            //var shipper = await shipperRepo.Find(id);
            if (donHang == null 
                || donHang.TTDH.ID != (int) TrangThaiDonHang.ChoXacNhan 
                //|| shipper.Id != donHang.ShipperID
                )
            {
                return BadRequest();
            }
            var _donHang = await donHangRepo.CapNhatTTDH(donHang, TrangThaiDonHang.DangLayHang);
            if (_donHang != null)
            {
                return Ok();
            } 
            return BadRequest();
        }

        // POST api/<DonHangController>/{id}/Huy/{shipperId}
        [HttpPost("{id}/Huy/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> HuyDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.Find(id);
            //var shipper = await shipperRepo.Find(id);
            if (donHang != null 
                //|| shipper.Id != donHang.ShipperID
                )
            {
                return BadRequest();
            }
            if (donHang.TTDH.ID == (int)TrangThaiDonHang.DangLayHang 
                || donHang.TTDH.ID == (int)TrangThaiDonHang.DangGiaoHang)
            {
                var _donHang = await donHangRepo.CapNhatTTDH(donHang, TrangThaiDonHang.DaHuy);
                if (_donHang != null)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }
    }
}
