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
    public class KhachHangRepository: RepositoryBase<KhachHangEntity>, IKhachHangRepository
    {
        private readonly ApplicationDbContext context;

        public KhachHangRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
  
        public async Task<int> findIdKhachHang(int id)
        {
            KhachHangEntity  temp = await context.KhachHang
                .Where(kh => kh.UserId == id)
                .FirstOrDefaultAsync();
            return temp.Id;
        }
        //public async Task<bool> UpdateKhachHang(string cmnd, string hoTen, string gioiTinh, DateTime ngaySinh, int hinhAnhId)
        public async Task<KhachHangEntity> UpdateKhachHang(KhachHangEntity kh)
        {

            var temp = await context.KhachHang.Where(t => t.UserId == kh.UserId).SingleOrDefaultAsync();
            if(temp!=null)
            {
                if (kh.CMND != null) temp.CMND = kh.CMND;
                if (kh.GioiTinh != null) temp.GioiTinh = kh.GioiTinh;
                if (kh.HoTen != null) temp.HoTen = kh.HoTen;
                if (kh.NgaySinh != null) temp.NgaySinh = kh.NgaySinh;
                if (kh.SDT != null) temp.SDT = kh.SDT;
                if (kh.AvatarId != null) temp.AvatarId = kh.AvatarId;
                await context.SaveChangesAsync();
                return kh;
            }
                //changing inf
            return null;
        }
    }
}
