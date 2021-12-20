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

        public async Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper)
        {
            var ttdh = await context.TrangThaiDonHang.FindAsync((int)TrangThaiDonHang.DangLayHang);
            donHang.ShipperID = shipper.ID;
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
        public async Task<DonHangEntity> PostDonHang(DonHangEntity dh)
        {
           

            context.Set<DonHangEntity>().Add(dh);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return dh;
        }
    }
}
