using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces
{
    public interface IHinhAnhRepository : IRepositoryBase<HinhAnhEntity>
    {
        public Task<int?> Upsert(HinhAnhEntity hinhAnh);
    }
}
