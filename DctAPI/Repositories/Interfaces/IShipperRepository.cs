using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IShipperRepository : IRepositoryBase<ShipperEntity>
    {
        public Task<ShipperEntity> GetShipper(int shipper);
        public Task<Object> GetShipper(int userId, string sdt, string email);
    }
}
