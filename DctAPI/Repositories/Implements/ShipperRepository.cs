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
    public class ShipperRepository : RepositoryBase<ShipperEntity>, IShipperRepository
    {
        private readonly ApplicationDbContext context;

        public ShipperRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<ShipperEntity> GetShipper(int shipper)
        {
            return await context.Shipper.Where(sp => sp.Id == shipper)
                .Include(x => x.User)
                .FirstOrDefaultAsync();
                
        }
    }
}
