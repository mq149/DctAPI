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
        public Task<DonHangEntity> GetDonHang(int id);
        public Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper);
        public Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang);
        public DonHangEntity GetDonHang(int user, int id);
        //public  Task<DonHangEntity> GetDonHang(int user, int id);
        public List<DonHangEntity> GetAllDonHangByUser(int user);
        //public Task<ActionResult<IEnumerable<DonHangEntity>>> GetAllDonHangByUser(int user);
        public List<DonHangEntity> GetAllDonHang();
    }
}
