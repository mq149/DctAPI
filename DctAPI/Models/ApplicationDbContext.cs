using DctApi.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<UserEntity> User { get; set; }
        public DbSet<KhachHangEntity> KhachHang { get; set; }
        public DbSet<ShipperEntity> Shippers { get; set; }
        public DbSet<HinhAnhEntity> HinhAnh { get; set; }
        public DbSet<DiaChiEntity> DiaChi { get; set; }
        public DbSet<HoSoShipperEntity> HoSoShipper { get; set; }
        public DbSet<TaiKhoanNganHangEntity> TaiKhoanNganHang { get; set; }

        public DbSet<LoaiCuaHangEntity> LoaiCuaHang { get; set; }
        public DbSet<LoaiDanhGiaEntity> LoaiDanhGia { get; set; }
        public DbSet<LoaiSanPhamEntity> LoaiSanPham { get; set; }
        public DbSet<CuaHangEntity> CuaHang { get; set; }
        public DbSet<NhaSanXuatEntity> NhaSanXuat { get; set; }
        public DbSet<SanPhamEntity> SanPham { get; set; }
        public DbSet<CuaHangSanPhamEntity> CuaHangSanPham { get; set; }
        public DbSet<PhuongThucThanhToanEntity> PhuongThucThanhToan { get; set; }
        public DbSet<TrangThaiDonHangEntity> TrangThaiDonHang { get; set; }
        public DbSet<DonHangEntity> DonHang { get; set; }
        public DbSet<ChiTietDonHangEntity> ChiTietDonHang { get; set; }
        public DbSet<DanhGiaEntity> DanhGia { get; set; }


    }
}
