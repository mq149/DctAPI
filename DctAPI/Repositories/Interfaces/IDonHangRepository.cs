﻿using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IDonHangRepository : IRepositoryBase<DonHangEntity>
    {
        public Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper);
        public Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang, ShipperEntity shipper);
    }
}
