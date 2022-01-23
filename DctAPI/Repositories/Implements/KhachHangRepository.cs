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
    }
}
