using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IDanhGiaRepository : IRepositoryBase<DanhGiaEntity>
    {
        public Task<List<DanhGiaEntity>> GetDanhGiaDonHang(int id);
        public Task<List<DanhGiaEntity>> GetDanhGiaShipper(int shipper);
        public Task<List<DanhGiaEntity>> GetDanhGiaCuaHang(int cuahang);
        public Task<DanhGiaEntity> CreateDanhGia(DanhGiaEntity danhgia);
        //public Task<DanhGiaEntity> CreateDanhGia(string noidung, int diem, int loaidanhgia, int donhang);
        public bool DeleteDanhGia(int id);

    }
}
