using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements
{
    public class DanhGiaRepository : RepositoryBase<DanhGiaEntity>, IDanhGiaRepository
    {
        private readonly ApplicationDbContext context;
        public DanhGiaRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        //public Task<DanhGiaEntity> CreateDanhGia(string noidung, int diem, int loaidanhgia, int donhang)
        
        public async Task<DanhGiaEntity> CreateDanhGia(DanhGiaEntity dg)
        {
            //kiem tra da danh gia chua?
            //if(dg.DonHang.KhachHangId==kh)
            if(context.DanhGia.Where(x =>x.DonHangId==dg.DonHangId && x.LoaiDGId==dg.LoaiDGId ).FirstOrDefault() == null)
            {
                var danhgia = await context.DanhGia.AddAsync(dg);
                await context.SaveChangesAsync();
                if(danhgia!=null)
                {
                    return dg;
                }
            }
            return null;
        }
        public async Task<List<DanhGiaEntity>> GetDanhGiaDonHang(int id)
        {

            return context.DanhGia.Where(dg => dg.DonHangId == id).ToList();
        }

        public async Task<List<DanhGiaEntity>> GetDanhGiaCuaHang(int cuahang)
        {

            return context.DanhGia
                .Where(dg => dg.LoaiDGId==2 && dg.DonHang.CuaHangId == cuahang)
                .Include(x => x.DonHang)
                .OrderBy(dg => dg.NgayDanhGia)
                .ToList();
        }

        public async Task<List<DanhGiaEntity>> GetDanhGiaShipper(int shipper)
        {
            return context.DanhGia
                .Where(dg => dg.LoaiDGId == 1 && dg.DonHang.ShipperId == shipper)
                .Include(x => x.DonHang)
                .OrderBy(dg =>dg.NgayDanhGia)
                .ToList();
        }

        public bool DeleteDanhGia(int id)
        {
            throw new NotImplementedException();
        }
    }
}
