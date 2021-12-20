using DctApi.Shared.Enums;
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
    public class DonHangRepository : RepositoryBase<DonHangEntity>, IDonHangRepository
    {
        private readonly ApplicationDbContext context;

        public DonHangRepository(ApplicationDbContext context) :base(context)
        {
            this.context = context;
        }

        public List<DonHangEntity> GetChoXacNhan()
        {
            return context.DonHang
                .Where(dh => dh.ShipperId == null)
                .Include(dh => dh.CuaHang)
                .Include(dh => dh.KhachHang)
                .Include(dh => dh.DiaChiGiao)
                .Include(dh => dh.PTTT)
                .Include(dh => dh.TTDH)
                .ToList();
        }


        public async Task<DonHangEntity> GetDonHang(int id)
        {
            return await context.DonHang
                .Where(dh => dh.Id == id)
                .Include(dh => dh.CuaHang)
                .Include(dh => dh.KhachHang)
                .Include(dh => dh.DiaChiGiao)
                .Include(dh => dh.PTTT)
                .Include(dh => dh.TTDH)
                .FirstAsync();
        }

        public async Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper)
        {
            var ttdh = await context.TrangThaiDonHang.FindAsync((int)TrangThaiDonHang.DangLayHang);
            donHang.ShipperId = shipper.Id;
            donHang.TTDH = ttdh;
            context.Entry(donHang).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            } 
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return donHang;
        }

        public async Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang)
        {
            var ttdh = await context.TrangThaiDonHang.FindAsync((int)TrangThaiDonHang.DaHuy);
            donHang.TTDH = ttdh;
            context.Entry(donHang).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return donHang;
        }
    }
}
