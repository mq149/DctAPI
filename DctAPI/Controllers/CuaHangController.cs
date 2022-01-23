using DctApi.Shared.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Controllers {

    [Route("api/[Controller]")]
    [ApiController]
    public class CuaHangController:ControllerBase {
        private readonly ICuaHangRepository CuaHangRepo;
        public CuaHangController(ICuaHangRepository CH)
        {
            this.CuaHangRepo = CH;

        }
        // GET: api/<SanPhamController>
        [HttpGet]
        public IEnumerable<CuaHangEntity> Get()
        {
            return CuaHangRepo.GetAll();
        }
        [HttpGet("TatCaCuaHang")]
        public IEnumerable<CuaHangEntity> GetAllCuaHang()
        {
            return CuaHangRepo.GetAllCuaHang();
        }
    }
}
