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
        
    }
    }
