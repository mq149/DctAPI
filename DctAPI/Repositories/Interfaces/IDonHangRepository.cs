using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IDonHangRepository : IRepositoryBase<KhachhangEntity>
    {
        public Task<KhachhangEntity> ShipperXacNhanDonHang(KhachhangEntity donHang, ShipperEntity shipper);
        public Task<KhachhangEntity> ShipperHuyDonHang(KhachhangEntity donHang);
    }
}
