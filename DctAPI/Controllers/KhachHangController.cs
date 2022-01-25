using DctApi.Shared.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangRepository khachHangRepo;
        public KhachHangController(IKhachHangRepository khachHangRepo)
        {
            this.khachHangRepo = khachHangRepo;

        }
        // GET: api/<KhachHangController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<KhachHangController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KhachHangController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KhachHangController>/5
        [HttpPut("SuaThongTin")]
        public async Task<bool> Update(KhachHangEntity kh)
        {
            var sanpham = await khachHangRepo.UpdateKhachHang(kh);
            if (sanpham != null)
            {
                return true;
            }
            return false;
        }

        // DELETE api/<KhachHangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
