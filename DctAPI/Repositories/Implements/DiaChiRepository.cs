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
    public class DiaChiRepository : RepositoryBase<DiaChiEntity>, IDiaChiRepository
    {
        private readonly ApplicationDbContext context;

        public DiaChiRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<int> TaoDiaChi(DiaChiEntity dc)
        {
           
           await context.Set<DiaChiEntity>().AddAsync(dc);
            try
            {
               await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return 0;
            }
            return dc.Id;
        }
    }
}
