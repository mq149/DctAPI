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

        public async Task<DonHangEntity> CapNhatTTDH(DonHangEntity donHang, TrangThaiDonHang trangThai)
        {
            var result = await context.DonHang.FirstOrDefaultAsync(dh => dh.ID == donHang.ID);
            var ttdh = await context.TrangThaiDonHang.FirstOrDefaultAsync(tt => tt.ID == (int)trangThai);
            if (result != null)
            {
                result.TTDH = ttdh;
                try
                {
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return null;
                }
                return result;
            }
            return null;
        }
    }
}
