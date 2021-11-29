using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IDonHangRepository : IRepositoryBase<DonHangEntity>
    {
        public Task<DonHangEntity> CapNhatTTDH(DonHangEntity donHang, TrangThaiDonHang ttdh);
    }
}
