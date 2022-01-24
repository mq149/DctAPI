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
                .Where(dh => dh.ShipperId == null && dh.TTDHId == (int)TrangThaiDonHang.CuaHangDaXacNhan)
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
                    .ThenInclude(ch => ch.User.DiaChi)
                .Include(dh => dh.KhachHang)
                    .ThenInclude(ch => ch.User.DiaChi)
                .Include(dh => dh.DiaChiGiao)
                .Include(dh => dh.PTTT)
                .Include(dh => dh.TTDH)
                .FirstAsync();
        }

        public async Task<bool> ShipperDangCoDonHang(int shipperId)
        {
            var dsDonHang = await context.DonHang
                .Where(dh => dh.ShipperId == shipperId)
                .Where(dh => (dh.TTDHId == (int)TrangThaiDonHang.DaGiaoHang
                    || dh.TTDHId == (int)TrangThaiDonHang.DangLayHang))
                .ToListAsync();
            return dsDonHang.Count > 0;
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
            return await GetDonHang(donHang.Id);
        }

        public async Task<DonHangEntity> ShipperHuyDonHang(DonHangEntity donHang, string lyDoHuy)
        {
            donHang.TTDHId = (int)TrangThaiDonHang.DaHuy;
            donHang.LyDoHuy = lyDoHuy;
            context.Entry(donHang).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return await GetDonHang(donHang.Id);
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
        public async Task<DonHangEntity> GetDonHang(int user, int id)
        {
            return await context.DonHang
                .Where(dh => dh.KhachHangId == user && dh.Id == id)
                .Include(x => x.CuaHang).ThenInclude(k => k.User)
                .Include(x => x.Shipper).ThenInclude(k => k.User)
                .Include(x => x.DiaChiGiao)
                .Include(x => x.PTTT)
                .Include(x => x.TTDH)
                .FirstAsync();
                //.FirstOrDefault();

        }
        //        public List<DonHangEntity> GetAllDonHangByUser(int user)

        public async Task<List<DonHangEntity>> GetAllDonHang()
        {
            return await context.DonHang
                .OrderBy(dh => dh.NgayMuaHang)
                .ToListAsync();
            //.ToListAsync();
        }
        public async Task<List<DonHangEntity>> GetAllDonHangByUser(int user)
        {
            return await context.DonHang
                .Where(dh => dh.KhachHangId == user)
                .Include(x => x.Shipper).ThenInclude(k => k.User)
                .Include(x => x.CuaHang).ThenInclude(k => k.User)
                .Include(x=>x.DiaChiGiao)
                .Include(x=> x.PTTT)
                .Include(x=>x.TTDH)
                .OrderBy(dh => dh.NgayMuaHang)
                .ToListAsync();
                //.ToListAsync();
        }
        public async Task<List<DonHangEntity>> GetAllDonHangByCuaHang(int cuahang)
        {
            return await context.DonHang
                .Where(dh => dh.CuaHangId ==cuahang)
                .Include(x => x.Shipper).ThenInclude(k => k.User)
                .Include(x => x.KhachHang).ThenInclude(k => k.User)
                .Include(x => x.DiaChiGiao)
                .Include(x => x.PTTT)
                .Include(x => x.TTDH)
                .OrderBy(dh => dh.NgayMuaHang)
                .ToListAsync();
        }
        public async Task<List<DonHangEntity>> GetAllDonHangByShipper(int shipper)
        {
            return await context.DonHang
                .Where(dh => dh.ShipperId == shipper)
                .Include(x => x.Shipper).ThenInclude(k => k.User)
                .Include(x => x.CuaHang).ThenInclude(k => k.User)
                .Include(x => x.DiaChiGiao)
                .Include(x => x.PTTT)
                .Include(x => x.TTDH)
                .OrderBy(dh => dh.NgayMuaHang)
                .ToListAsync();
        }
        public async Task<DonHangEntity> ShipperDangGiaoHang(DonHangEntity donHang, ShipperEntity shipper)
        {
            if(donHang !=null & shipper != null)
            {
                donHang.ShipperId = shipper.Id;
                donHang.TTDHId = (int)TrangThaiDonHang.DangGiaoHang;
                await context.SaveChangesAsync();
                return donHang;
            }    
            return null;

        }
        public async Task<DonHangEntity> ShipperGiaoThanhCong(DonHangEntity donHang, ShipperEntity shipper)
        {
            if (donHang != null & shipper != null)
            {
                donHang.ShipperId = shipper.Id;
                donHang.TTDHId = (int)TrangThaiDonHang.DaGiaoHang;
                await context.SaveChangesAsync();
                return donHang;
            }
            return null;
        }
    }
}
