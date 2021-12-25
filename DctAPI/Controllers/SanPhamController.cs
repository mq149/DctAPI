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
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamRepository SanPhamRepo;
        public SanPhamController(ISanPhamRepository SanPhamRepo)
        {
            this.SanPhamRepo = SanPhamRepo;
          
        }
        // GET: api/<SanPhamController>
        [HttpGet]
        public IEnumerable<SanPhamEntity> Get()
        {
            return  SanPhamRepo.GetAll();
        }
        [HttpGet("TatCaSanPham")]
        public IEnumerable<SanPhamEntity> GetAllSanPham()
        {
            return SanPhamRepo.GetAllSanPham();
        }
        [HttpGet("SanPham/{ID}")]
        public IEnumerable<SanPhamEntity> GetSanPhamID(int ID)
        {
            return SanPhamRepo.GetSanPhamID(ID);
        }
        // GET api/<SanPhamController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SanPhamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

  
        

        // DELETE api/<SanPhamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
