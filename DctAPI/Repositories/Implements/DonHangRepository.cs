using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Repositories.Implements
{
    public class DonHangRepository : RepositoryBase<DonHangEntity>, IDonHangRepository
    {
        private readonly ApplicationDbContext context;

        public DonHangRepository(ApplicationDbContext context) :base(context)
        {
            this.context = context;
        }

        public List<DonHangEntity> GetChoXacNhan()
        {
            return context.DonHang
                .Where(dh => dh.ShipperId == null)
                .Include(dh => dh.CuaHang)
                    .ThenInclude(ch => ch.User.DiaChi)
                .Include(dh => dh.KhachHang)
                .Include(dh => dh.DiaChiGiao)
                .Include(dh => dh.PTTT)
                .Include(dh => dh.TTDH)
                .ToList();
        }


        public async Task<DonHangEntity> GetDonHang(int id)
        {
            return await context.DonHang
                .Where(dh => dh.Id == id)
                .Include(dh => dh.CuaHang)
                .Include(dh => dh.KhachHang)
                .Include(dh => dh.DiaChiGiao)
                .Include(dh => dh.PTTT)
                .Include(dh => dh.TTDH)
                .FirstAsync();
        }

        public async Task<DonHangEntity> ShipperXacNhanDonHang(DonHangEntity donHang, ShipperEntity shipper)
        {
            donHang.ShipperId = shipper.Id;
            donHang.TTDHId = (int)TrangThaiDonHang.DangLayHang;
            context.Entry(donHang).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            } 
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return donHang;
        }

        public async Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang)
        {
            donHang.TTDHId = (int)TrangThaiDonHang.DaHuy;
            context.Entry(donHang).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return donHang;
        }

        public async Task<DonHangEntity> KhachHangDatHang(DonHangEntity dh)
        {
           

            await context.Set<DonHangEntity>().AddAsync(dh);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return dh;
        }
        public async Task<DonHangEntity> PostDonHang(DonHangEntity dh)
        {
            context.Set<DonHangEntity>().Add(dh);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return dh;
        }
        //public async Task<DonHangEntity> GetDonHang(int user, int id)
        public DonHangEntity GetDonHang(int user, int id)
        {
            return  context.DonHang
                .Where(dh => dh.KhachHangId == user && dh.Id == id)
                .Include(x => x.CuaHang).ThenInclude(k => k.User)
                .Include(x => x.Shipper).ThenInclude(k=>k.User)
                .Include(x => x.DiaChiGiao)
                .Include(x => x.PTTT)
                .Include(x => x.TTDH)
              
                .FirstOrDefault();
           // var donhang = (from dh in context.DonHang where dh.KhachHangId == user && dh.Id == id select dh).FirstOrDefault<DonHangEntity>();
           // return donhang;
            //return donhang;
        }
        //        public List<DonHangEntity> GetAllDonHangByUser(int user)

        public List<DonHangEntity> GetAllDonHangByUser(int user)
        {
            return context.DonHang
                .Where(dh => dh.KhachHangId == user)
                .Include(x => x.Shipper).ThenInclude(k => k.User)
                .Include(x => x.CuaHang).ThenInclude(k => k.User)
                .Include(x=>x.DiaChiGiao)
                .Include(x=> x.PTTT)
                .Include(x=>x.TTDH)
<<<<<<< HEAD

=======
             
>>>>>>> master
                .OrderBy(dh => dh.NgayMuaHang)
                .ToList();
                //.ToListAsync();
        }
        public List<DonHangEntity> GetAllDonHang()
        {
            return context.DonHang.ToList();

        }
    }
}
