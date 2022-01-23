using DctApi.Shared.Models;
using DctAPI.Models;
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
    public class CuaHangController : ControllerBase {
        private readonly ICuaHangRepository _cuahangRepository;

        public CuaHangController(ICuaHangRepository cuahangRepository) {
            _cuahangRepository = cuahangRepository;
        }

        [HttpGet]
        [Route("checkexiststore")]
        public async Task<Boolean> KiemTraCuaHang( int UserId) {
            return await _cuahangRepository.KiemTraCuaHang(UserId);
        }

        [HttpGet]
        [Route("getstorebyuserId")]
        public async Task<ActionResult<CuaHangEntity>> GetCuaHangByUserId(int UserId) {
            return await _cuahangRepository.GetCuaHangByUserId(UserId);
        }
    }
}
