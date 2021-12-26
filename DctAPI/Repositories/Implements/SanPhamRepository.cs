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

    public class SanPhamRepository : RepositoryBase<SanPhamEntity>,   ISanPhamRepository

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
            if(sanpham!=null)
            {
                return sp;
            }
            return null;
        }

        public SanPhamEntity GetSanPhamById(int id)
        {
            return context.SanPham
                .Where(sp => sp.Id == id)
                .Include(x => x.HinhSanPham)
                .Include(x => x.LoaiSP)
                .Include(x => x.NSX)
                .FirstOrDefault();
        }

        public List<SanPhamEntity> GetSanPhamByName(string ten)
        {
            return context.SanPham
                .Where(sp => sp.Ten.ToLower() ==ten.ToLower())
                .Include(x => x.HinhSanPham)
                .Include(x=>x.LoaiSP)
                .Include(x=>x.NSX)
                .ToList();
        }
        //public async Task<SanPhamEntity> UpdateSanPham(SanPhamEntity sp)
        public bool UpdateSanPham(SanPhamEntity sp)
        {
            //int id = sp.ID;
            var sanpham=context.SanPham.Update(sp);
            context.Entry(sp).State = EntityState.Modified;
            context.SaveChanges();
            if (sanpham != null)
            {
                return true;
            }
            return false;
            //var DataList = context.SanPham.Where(x => x.ID==id).FirstOrDefault();
            //if (DataList!=null)
            //{
            //    context.SanPham.Update(sp);
            //    //context.Entry(sp).State = EntityState.Modified;
            //    await context.SaveChangesAsync();
            //    return DataList;
            //}
            //else
            //{
            //    return null;
            //}

        }
        public bool DeleteSanPham(int id)
        {
            //chua lam
            //var sanpham = context.SanPham.Where(x => x.Id == id).
            
            //context.SaveChanges();
            //if(sanpham!=null)
            //{
            //    return true;
            //}
            return false;
        }
    }
}
