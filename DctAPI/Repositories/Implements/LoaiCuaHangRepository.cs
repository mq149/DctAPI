using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements {
    public class LoaiCuaHangRepository:RepositoryBase<LoaiCuaHangEntity>,ILoaiCuaHangRepository {
        private readonly ApplicationDbContext _context;
        public LoaiCuaHangRepository(ApplicationDbContext context) : base(context) {
            this._context = context;
        }
    }
}
