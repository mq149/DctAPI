using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements
{
    public class KhachHangRepository : RepositoryBase<KhachHangEntity>, IKhachHangRepository
    {
        private readonly ApplicationDbContext context;

        public KhachHangRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public async KhachhangEntity DocKhachHang(int id)
        {
            return await context.KhachHang.FindAsync(id);
        }

        Task<KhachHangEntity> IKhachHangRepository.DocDonKhachHang(KhachHangEntity kh)
        {
            throw new NotImplementedException();
        }
    }
}
