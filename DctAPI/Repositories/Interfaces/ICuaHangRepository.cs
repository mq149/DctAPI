using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace DctAPI.Repositories.Interfaces
{
    public interface ICuaHangRepository : IRepositoryBase<CuaHangEntity> {

        Task<CuaHangEntity> GetCuaHang(int cuahang);
        Task<CuaHangEntity> GetCuaHangByUserId(int UserId);
        Task<bool> KiemTraCuaHang(int UserId);

  
        public IEnumerable<CuaHangEntity> GetAllCuaHang();

    }
}
