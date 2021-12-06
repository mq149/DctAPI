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
    public class ShipperRepository : IShipperRepository
    {
        private readonly ApplicationDbContext context;

        public ShipperRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<UserEntity> Create(UserEntity user)
        {
            var role = await context.Role.FindAsync(Role.Shipper);
            user.Role = role;
            var newUser = await context.User.AddAsync(user);
            return newUser.Entity;
        }

        public async Task<UserEntity> Find(string SDT)
        {
            return await context.User.FirstOrDefaultAsync(s => s.SDT == SDT);
        }
    }
}
