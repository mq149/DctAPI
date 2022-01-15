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

    public class SanPhamRepository : RepositoryBase<SanPhamEntity>, ISanPhamRepository

    {
        private readonly ApplicationDbContext context;

        public SanPhamRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<SanPhamEntity> PostSanPham(SanPhamEntity sp)
        {


            context.Set<SanPhamEntity>().Add(sp);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return sp;
        }
        public IEnumerable<SanPhamEntity> GetAllSanPham()
        {
            return context.SanPham

               .Include(sp => sp.HinhSanPham)
               .Include(sp => sp.LoaiSP)
               .Include(sp => sp.NSX)
               .ToList();
        }
        public IEnumerable<SanPhamEntity> GetSanPhamID(int id)
        {
            return context.SanPham
            .Where(sp => sp.Id == id)
              .Include(sp => sp.HinhSanPham)
              .Include(sp => sp.LoaiSP)
              .Include(sp => sp.NSX)
              .ToList();
        }


        public async Task<SanPhamEntity> CreateSanPham(SanPhamEntity sp)
        {
            //Kiem tra ng danh gia

            var sanpham = await context.SanPham.AddAsync(sp);
            await context.SaveChangesAsync();
            if (sanpham != null)
            {
                return sp;
            }
            return null;
        }

        public async Task<SanPhamEntity> GetSanPhamById(int id)
        {
            return await context.SanPham
                .Where(sp => sp.Id == id)
                .Include(x => x.HinhSanPham)
                .Include(x => x.LoaiSP)
                .Include(x => x.NSX)
                .FirstOrDefaultAsync();
        }

        public async Task<List<SanPhamEntity>> GetSanPhamByName(string ten)
        {
            return await context.SanPham
                //.Where(sp => sp.Ten.ToLower() == ten.ToLower() )
                .Where(sp => sp.Ten.ToLower().Contains(ten))
                .Include(x => x.HinhSanPham)
                .Include(x => x.LoaiSP)
                .Include(x => x.NSX)
                .ToListAsync();
        }

        
        public async Task<SanPhamEntity> UpdateSanPham(SanPhamEntity sp)
        {
            
            SanPhamEntity spc = await context.SanPham.Where(x => x.Id == sp.Id).FirstOrDefaultAsync();
            if(spc!=null)
            {
                spc.LoaiSP = sp.LoaiSP;
                spc.HinhSanPham = sp.HinhSanPham;
                spc.MoTa = sp.MoTa;
                spc.NSX = sp.NSX;
                spc.Ten = sp.Ten;
                spc.GiaSP = sp.GiaSP;
                spc.SoLuong = sp.SoLuong;
                await context.SaveChangesAsync();
                return sp;
            }
            return null;
        }
        public async Task<SanPhamEntity> DeleteSanPham(int id)
        {
            
            //var sanpham = context.SanPham.Where(x => x.Id == id).
            SanPhamEntity sp =  await context.SanPham.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (sp!= null)
            {
                 context.SanPham.Remove(sp);
                await context.SaveChangesAsync();
                return sp;
            }

            return null;
        }
    }
}
