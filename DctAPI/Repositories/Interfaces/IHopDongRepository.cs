using DctApi.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Interfaces {
    public interface IHopDongRepository {
        public Task<int?> Upsert(HopDongEntity hopdong);
    }
}
