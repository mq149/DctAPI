using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IDonHangRepository : IRepositoryBase<DonHangEntity>
    {
        public List<DonHangEntity> GetChoXacNhan();

        public Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper);

        public Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang);

        public Task<DonHangEntity> KhachHangDatHang(DonHangEntity dh);

        public Task<DonHangEntity> PostDonHang(DonHangEntity dh);

        public Task<DonHangEntity> GetDonHang(int id);
        public Task<List<DonHangEntity>> GetAllDonHang();

        public Task<List<DonHangEntity>> GetAllDonHangByUser(int user);

        public Task<List<DonHangEntity>> GetAllDonHangByShipper(int shipper);

        public Task<List<DonHangEntity>> GetAllDonHangByCuaHang(int cuahang);
        public Task<DonHangEntity> ShipperGiaoThanhCong(DonHangEntity donHang, ShipperEntity shipper);
        public Task<DonHangEntity> ShipperDangGiaoHang(DonHangEntity donHang, ShipperEntity shipper);

    }
}
