using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements {
    public class HopDongRepository:RepositoryBase<HopDongEntity>,IHopDongRepository {

        private readonly ApplicationDbContext _context;

        public HopDongRepository(ApplicationDbContext context) : base(context) {
            _context = context;
        }
        public async Task<int?> Upsert(HopDongEntity hopdong) {
            var _hopdong = _context.HopDong
                .Where(hd => hd.Url == hopdong.Url)
                .FirstOrDefault();
            if (_hopdong == null) {
                _context.Entry(hopdong).State = EntityState.Added;
                try {
                    var newhopdong = await _context.AddAsync(hopdong);
                    await _context.SaveChangesAsync();
                    return newhopdong.Entity.Id;
                }
                catch (DbUpdateConcurrencyException) {
                    return null;
                }
            }
            else {
                _hopdong.Url = hopdong.Url;
                _context.Entry(_hopdong).State = EntityState.Modified;
                try {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    return null;
                }
                return _hopdong.Id;
            }
        }
    }
}
