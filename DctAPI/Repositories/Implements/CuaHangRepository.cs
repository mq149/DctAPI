using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements
{
    public class CuaHangRepository : RepositoryBase<CuaHangEntity>, ICuaHangRepository
    {
        private readonly ApplicationDbContext context;

        public CuaHangRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<bool> TaoCuaHang(CuaHangEntity cuahang) {
            try {
                await context.CuaHang.AddAsync(new CuaHangEntity() { UserId = cuahang.UserId, LoaiCHId = cuahang.LoaiCHId, TrangThaiKichHoat = false });
                await context.SaveChangesAsync();
                return true;
            }
            catch {
                return false;
            }
        }
        public async Task<CuaHangEntity> GetCuaHang(int cuahang)
        {
            return await context.CuaHang.Where(ch => ch.Id == cuahang)
                .Include(x => x.User)
                .FirstOrDefaultAsync();
        }

        public async Task<Boolean> KiemTraCuaHang(int UserId) {
            var check = await context.CuaHang.Where(cuahang => cuahang.UserId == UserId).FirstOrDefaultAsync();
            if(check!=null) {
                return true;
            }
            return false;
        }

        public async Task<CuaHangEntity> GetCuaHangByUserId(int UserId)
        {
            return await context.CuaHang.Where(cuahang => cuahang.UserId == UserId)
                                                                    .Include(cuahang => cuahang.ChiTietCuaHang)
                                                                    .Include(cuahang => cuahang.ChiTietCuaHang.AnhQuan)
                                                                    .Include(cuahang => cuahang.ChiTietCuaHang.ThoiGian)
                                                                    .Include(cuahang => cuahang.HinhChungMinhNhanDan)
                                                                    .Include(cuahang => cuahang.LoaiCH)
                                                                    .Include(cuahang => cuahang.DiaChiCuaHang).FirstOrDefaultAsync();
        }
        public IEnumerable<CuaHangEntity> GetAllCuaHang()
        {
            return context.CuaHang    
               .ToList();

        }
    }
}
