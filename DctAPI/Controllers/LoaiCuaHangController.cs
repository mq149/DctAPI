using DctApi.Shared.Models;
using DctAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Controllers {

    [Route("api/[Controller]")]
    [ApiController]
    public class LoaiCuaHangController {
        private readonly ApplicationDbContext _context;

        public LoaiCuaHangController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet]
        [Route("getall-category-store")]
        public async Task <ActionResult<IEnumerable<LoaiCuaHangEntity>>> GetAllCategoryStore() {
            return await _context.LoaiCuaHang.ToListAsync();
        }

    }
}
