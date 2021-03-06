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

        private readonly ISanPhamRepository sanPhamRepo;
        public SanPhamController(ISanPhamRepository SanPhamRepo)
        {
            this.sanPhamRepo = SanPhamRepo;
          
        }
        // GET: api/<SanPhamController>
        [HttpGet]
        public IEnumerable<SanPhamEntity> Get()
        {
            return  sanPhamRepo.GetAll();
        }
        [HttpGet("TatCaSanPham")]
        public IEnumerable<SanPhamEntity> GetAllSanPham()
        {
            return sanPhamRepo.GetAllSanPham();
        }
        [HttpGet("SanPham/{ID}")]
        public IEnumerable<SanPhamEntity> GetSanPhamID(int ID)
        {
            return sanPhamRepo.GetSanPhamID(ID);
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
    
   

     
        // GET: api/<SanPhamController>
  
        // GET api/<SanPhamController>/5
        [HttpGet("SanPhamTheoTen")]
        public async Task<List<SanPhamEntity>> GetSanPhamByName(string name)
        {
            var sp =  await sanPhamRepo.GetSanPhamByName(name);
            if (sp != null)
                return sp;
            return null; // not found
        }
        [HttpGet("SanPhamTheoId")]
        public async Task<SanPhamEntity> GetSanPhamById(int id)
        {
            var sp = await sanPhamRepo.GetSanPhamById(id);
            if (sp != null)
                return sp;
            return null; //not found
        }

        // POST api/<SanPhamController>
        [HttpPost("ThemSanPham")]
        public async Task<ActionResult<SanPhamEntity>> Create([FromBody] SanPhamEntity sp)
        {
            var sanpham=await sanPhamRepo.CreateSanPham(sp);
            //khoi can kiem tra id do da tu tang
            if(sanpham!=null)
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<SanPhamController>/5
        [HttpPut("SuaSanPham")]
        public async Task<bool> Update(SanPhamEntity sp)
        {
            //FK phai co: LoaiSPID, NSXID
            var sanpham =  await sanPhamRepo.UpdateSanPham(sp);
            if (sanpham!=null)
            {
                return true;
            }
            return false;

        }

        // DELETE api/<SanPhamController>/5
        [HttpDelete("XoaSanPham")]
        public async Task<bool> DeleteSanPham(int id)
        {
            var sanpham = await sanPhamRepo.DeleteSanPham(id);
            if (sanpham != null)
            {
                return true;
            }
            return false;

        }

        //cua hang
        [HttpGet]
        [Route("cuahang-sanpham")]
        public async Task<List<SanPhamEntity>> SanPhamCuaHang(int userId) {
            return await sanPhamRepo.SanPhamCuaHang(userId);
        }
    }
}
