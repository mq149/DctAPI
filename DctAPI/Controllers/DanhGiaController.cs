﻿using DctApi.Shared.Models;
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
    public class DanhGiaController : ControllerBase
    {
        private readonly IDanhGiaRepository danhGiaRepo;


        public DanhGiaController(IDanhGiaRepository danhGiaRepo)
        {
            this.danhGiaRepo = danhGiaRepo;

        }
        // GET: api/<DanhGiaController>
        [HttpGet]
        public IEnumerable<DanhGiaEntity> Get()
        {
            return danhGiaRepo.GetAll();
        }
        // DANH GIA CUA CUA HANG
        [HttpGet("DanhGiaCuaHang/{cuahang}")]
        public List<DanhGiaEntity> GetDanhGiaCuaHang(int cuahang)
        {
            return danhGiaRepo.GetDanhGiaCuaHang(cuahang);
        }
        // DANH GIA CUA SHIPPER
        [HttpGet("DanhGiaShipper/{shipper}")]
        public List<DanhGiaEntity> GetDanhGiaShipper(int shipper)
        {
            return danhGiaRepo.GetDanhGiaShipper(shipper);
        }

        // GET api/<DanhGiaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DanhGiaController>
        [HttpPost("TaoDanhGia")]
        public async Task<ActionResult<DanhGiaEntity>> CreateDanhGia([FromBody] DanhGiaEntity dg)
        {
            
            var danhgia = await danhGiaRepo.CreateDanhGia(dg);

            //khoi can kiem tra id do da tu tang
            if (danhgia != null)
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<DanhGiaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DanhGiaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}