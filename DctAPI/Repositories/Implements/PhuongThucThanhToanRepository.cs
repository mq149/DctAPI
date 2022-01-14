using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements
{
    public class PhuongThucThanhToanRepository : RepositoryBase<PhuongThucThanhToanEntity>, IPhuongThucThanhToanRepository
    {
        private readonly ApplicationDbContext context;

        public PhuongThucThanhToanRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
