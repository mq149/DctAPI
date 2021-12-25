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
    public class DiaChiController : ControllerBase
    {
        private readonly IDiaChiRepository DiaChiRepo;
        public DiaChiController(IDiaChiRepository DiaChiRepo)
        {
            this.DiaChiRepo = DiaChiRepo;

        }
        // GET: api/<DiaChiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DiaChiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DiaChiController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] DiaChiEntity dc)
        {
            return await DiaChiRepo.TaoDiaChi(dc);
        }

        // PUT api/<DiaChiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DiaChiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
