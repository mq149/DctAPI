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
    public class HinhAnhRepository : RepositoryBase<HinhAnhEntity>, IHinhAnhRepository
    {
        private readonly ApplicationDbContext context;

        public HinhAnhRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<int?> Upsert(HinhAnhEntity hinhAnh)
        {
            var _hinhAnh = context.HinhAnh
                .Where(ha => ha.Ten == hinhAnh.Ten)
                .FirstOrDefault();
            if (_hinhAnh == null)
            {
                context.Entry(hinhAnh).State = EntityState.Added;
                try
                {
                    var newHinhAnh = await context.AddAsync(hinhAnh);
                    await context.SaveChangesAsync();
                    return newHinhAnh.Entity.Id;
                }
                catch (DbUpdateConcurrencyException)
                {
                    return null;
                }
            } else
            {
                _hinhAnh.Ten = hinhAnh.Ten;
                _hinhAnh.Url = hinhAnh.Url;
                context.Entry(_hinhAnh).State = EntityState.Modified;
                try
                {
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return null;
                }
                return _hinhAnh.Id;
            }
        }
    }
}
