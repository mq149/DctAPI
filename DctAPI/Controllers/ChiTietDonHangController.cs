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
    public class ChiTietDonHangController : ControllerBase
    {
        private readonly IChiTietDonHangRepository ChiTietRepo;
        public ChiTietDonHangController(IChiTietDonHangRepository ChiTietRepo)
        {
            this.ChiTietRepo = ChiTietRepo;

        }
        // GET: api/<ChiTietDonHangController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChiTietDonHangController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChiTietDonHangController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] ChiTietDonHangEntity ct)
        {
            return await ChiTietRepo.TaoChiTietDonHang(ct);
        }
     
        // PUT api/<ChiTietDonHangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChiTietDonHangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
