using DctApi.Shared.Models;
using DctAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
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
            var _listLCH = from lch in _context.LoaiCuaHang
                           join img in _context.HinhAnh on lch.HinhAnhId equals img.Id
                           where lch.HinhAnhId == img.Id
                           select new LoaiCuaHangEntity() {
                               Id = lch.Id,
                               Ten = lch.Ten,
                               DienGiai = lch.DienGiai,
                               HinhAnhId = lch.HinhAnhId,
                               HinhAnh = new HinhAnhEntity() {
                                   Id = img.Id,
                                   Ten = img.Ten,
                                   Url = img.Url
                               },
                           };
            return await _listLCH.ToListAsync();
        }
    }
}
