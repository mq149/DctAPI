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
        public async Task<ActionResult<CuaHangEntity>> GetCuaHangByUserId(int UserId)
        {
            return await _cuahangRepository.GetCuaHangByUserId(UserId);
        }

        [HttpPost]
        [Route("create-store")]
        public async Task<IActionResult> TaoCuaHang([FromBody]CuaHangEntity cuahang) {
            var check= await _cuahangRepository.TaoCuaHang(cuahang);
            if(check==true) {
                return StatusCode(StatusCodes.Status200OK, new Response { status = "Success", message = "Khởi tạo của hàng thành công" });
            }
            else {
                return StatusCode(StatusCodes.Status400BadRequest, new Response { status = "Error", message = "Khởi tạo của hàng không thành công" });
            }
        }
        [HttpGet("TatCaCuaHang")]
        public IEnumerable<CuaHangEntity> GetAllCuaHang()
        {
            return _cuahangRepository.GetAllCuaHang();

        }

  
 
    }
}
