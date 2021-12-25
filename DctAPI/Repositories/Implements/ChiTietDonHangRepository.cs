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
    public class ChiTietDonHangRepository : RepositoryBase<ChiTietDonHangEntity>, IChiTietDonHangRepository
    {
        private readonly ApplicationDbContext context;

        public ChiTietDonHangRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<int> TaoChiTietDonHang(ChiTietDonHangEntity ct)
        {
            int i;
            await context.Set<ChiTietDonHangEntity>().AddAsync(ct);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return 0;
            }
            return ct.Id;
        }
    }
}
