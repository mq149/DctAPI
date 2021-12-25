using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface ISanPhamRepository:IRepositoryBase<SanPhamEntity>
    {
        public SanPhamEntity GetSanPhamById(int id);
        public List<SanPhamEntity> GetSanPhamByName(string name);
        public Task<SanPhamEntity> CreateSanPham(SanPhamEntity sp);
        //public Task<SanPhamEntity> UpdateSanPham(SanPhamEntity sp);
        public bool UpdateSanPham(SanPhamEntity sp);
        public bool DeleteSanPham(int id);

    }
}
