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

        public async Task<Object> GetShipper(int userId, string sdt, string email)
        {
            var shipper = await context.Shipper
                .Where(s => s.UserId == userId)
                .Where(s => s.User.SDT == sdt && s.User.Email == email)
                .FirstOrDefaultAsync();
            var user = await context.UserEntity
                .Where(u => u.Id == userId)
                .Include(u => u.AvatarId)
                .Include(u => u.DiaChi)
                .FirstOrDefaultAsync();
            if (shipper == null && user == null)
            {
                return null;
            }
            return new
            {
                GioiTinh = shipper.User.GioiTinh,
                NgaySinh = shipper.User.NgaySinh,
                AvatarId = user.AvatarId,
                DiaChi = user.DiaChi,
                CMND = shipper.CMND,
                BienSo = shipper.BienSo,
                DongXe = shipper.DongXe,
            };
        }
    }
}
