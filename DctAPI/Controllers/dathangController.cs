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
    public class dathangController : ControllerBase
    {
        // GET: api/<dathangController>
        private readonly IDonHangRepository donHangRepo;
        private readonly IKhachHangRepository khachHangRepo;
        
        public dathangController(IDonHangRepository donHangRepo1)
        {
            this.donHangRepo = donHangRepo1;
     
         

        }
        [HttpGet]
        public IEnumerable<KhachHangEntity> Get()
        {
            return khachHangRepo.GetAll();
        }

        // GET api/<dathangController>/5
        [HttpGet("{id}")]
        public IEnumerable<KhachhangEntity> Get(int id)
        {
            return donHangRepo.GetAll();
        }

        // POST api/<dathangController>
        [HttpPost]
        public void Post([FromBody] KhachhangEntity dh)
        {
          
        }

        // PUT api/<dathangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<dathangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
