using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IKhachHangRepository: IRepositoryBase<KhachHangEntity>
    {
        public Task<int> findIdKhachHang(int id);
        //public Task<bool> UpdateKhachHang(string cmnd, string hoTen, string gioiTinh, DateTime ngaySinh, int hinhAnhId);
        public Task<KhachHangEntity> UpdateKhachHang(KhachHangEntity kh);
    }
}
