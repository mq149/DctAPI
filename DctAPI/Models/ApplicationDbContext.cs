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
        public DbSet<ShipperEntity> Shipper { get; set; }
        public DbSet<RoleEntity> Role { get; set; }
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
        public DbSet<CauHoiTracNghiemEntity> CauHoiTracNghiem { get; set; }
        public DbSet<LuaChonTracNghiemEntity> LuaChonTracNghiem { get; set; }
        public DbSet<KhoaDaoTaoEntity> KhoaDaoTao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CauHoiTracNghiemEntity>()
                .HasData(
                   new CauHoiTracNghiemEntity { Id = 1, NoiDung = "Sơ đồ nào sau đây phù hợp với thiết kế động?" },
                    new CauHoiTracNghiemEntity { Id = 2, NoiDung = "1+2=?" },
                    new CauHoiTracNghiemEntity { Id = 3, NoiDung = "Vai trò nào không có trong ĐI CHỢ THUÊ" },
                    new CauHoiTracNghiemEntity { Id = 4, NoiDung = "Trong sơ đồ class, quan hệ aggregration được thể hiện bằng" },
                    new CauHoiTracNghiemEntity { Id = 5, NoiDung = "Trong mô hình MVC, View đóng vai trò" }
                );
            modelBuilder.Entity<LuaChonTracNghiemEntity>()
                .HasData(
                    new LuaChonTracNghiemEntity {Id = 1, NoiDung = "Class diagram", Dung = false, CauHoiId = 1},
                    new LuaChonTracNghiemEntity {Id = 2, NoiDung = "Sequence diagram", Dung = true, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity {Id = 3, NoiDung = "Use case diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity {Id = 4, NoiDung = "Package diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity {Id = 5, NoiDung = "1", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity {Id = 6, NoiDung = "2", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity {Id = 7, NoiDung = "3", Dung = true, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity {Id = 8, NoiDung = "4", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity {Id = 9, NoiDung = "Shipper", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity {Id = 10, NoiDung = "Khách hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity {Id = 11, NoiDung = "Nhân viên kho", Dung = true, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity {Id = 12, NoiDung = "Cửa hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity {Id = 13, NoiDung = "Mũi tên", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity {Id = 14, NoiDung = "Đường nối", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity {Id = 15, NoiDung = "Hình thoi đen", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity {Id = 16, NoiDung = "Hình thoi trắng", Dung = true, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity {Id = 17, NoiDung = "Gửi request đến và nhận response từ Controller", Dung = true, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity {Id = 18, NoiDung = "Cập nhật giao diện", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity {Id = 19, NoiDung = "Kiểm tra logic dữ liệu", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity {Id = 20, NoiDung = "Lưu trữ dữ liệu vào database", Dung = false, CauHoiId = 5 }
                );
            modelBuilder.Entity<TrangThaiDonHangEntity>()
                .HasData(
                    new TrangThaiDonHangEntity { Id = 1, Ten = "Chờ xác nhận"},
                    new TrangThaiDonHangEntity { Id = 2, Ten = "Cửa hàng đã xác nhận" },
                    new TrangThaiDonHangEntity { Id = 3, Ten = "Đang lấy hàng" },
                    new TrangThaiDonHangEntity { Id = 4, Ten = "Đang giao hàng" },
                    new TrangThaiDonHangEntity { Id = 5, Ten = "Đã giao hàng" },
                    new TrangThaiDonHangEntity { Id = 6, Ten = "Đã huỷ" }
                );
            modelBuilder.Entity<RoleEntity>()
               .HasData(
                   new RoleEntity { Id = 1, Ten = "Admin" },
                   new RoleEntity { Id = 2, Ten = "Cửa Hàng" },
                   new RoleEntity { Id = 3, Ten = "Shipper" },
                   new RoleEntity { Id = 4, Ten = "Khách Hàng" }
               );

            modelBuilder.Entity<KhoaDaoTaoEntity>()
                .HasData(
                    new KhoaDaoTaoEntity { ID = 1,
                        NoiDung = "Khoá đào tạo shipper Đi Chợ Thuê",
                        HuongDan = "Vui lòng xem video hướng dẫn để làm bài kiểm tra.",
                        URL = "www.google.com"}
                );
            modelBuilder.Entity<PhuongThucThanhToanEntity>()
                .HasData(
                    new PhuongThucThanhToanEntity { Id = 1, Ten = "Tiền mặt" },
                    new PhuongThucThanhToanEntity { Id = 2, Ten = "Thẻ ngân hàng" }
                );
            modelBuilder.Entity<DiaChiEntity>()
               .HasData(
                   new DiaChiEntity
                   {
                       Id = 1,
                       SoNhaTo = "189C",
                       Duong = "Cống Quỳnh",
                       XaPhuong = "Nguyễn Cư Trinh",
                       QuanHuyen = "Quận 1",
                       TinhTP = "TP. HCM"
                   },
                   new DiaChiEntity
                   {
                       Id = 2,
                       SoNhaTo = "227",
                       Duong = "Nguyễn Văn Cừ",
                       XaPhuong = "Phường 4",
                       QuanHuyen = "Quận 5",
                       TinhTP = "TP. HCM"
                   }
               );
            modelBuilder.Entity<UserEntity>()
                .HasData(
                    new UserEntity
                    {
                        Id = 1,
                        RoleId = 2,
                        HoTen = "Cua Hang Co-op Mart",
                        DiaChiId = 1,
                        SDT = "0123456789",
                        Email = "cuahangcoop@email.com",
                        MatKhau = "123456"
                    },
                    new UserEntity
                    {
                        Id = 2,
                        RoleId = 3,
                        HoTen = "Bùi Minh Quân",
                        DiaChiId = 2,
                        SDT = "0123333444",
                        Email = "shipper@email.com",
                        MatKhau = "123456"
                    },
                    new UserEntity
                    {
                        Id = 3,
                        RoleId = 4,
                        HoTen = "Khách hàng A",
                        DiaChiId = 2,
                        SDT = "0123123123",
                        Email = "khachhangA@email.com",
                        MatKhau = "123456"
                    }
                );
            modelBuilder.Entity<CuaHangEntity>()
                .HasData( new CuaHangEntity { Id = 1, UserId = 1, TenCuaHang = "Co-op Mart Cống Quỳnh", TrangThaiKichHoat = true } );

            modelBuilder.Entity<ShipperEntity>()
                .HasData( new ShipperEntity { Id = 1, UserId = 2, CMND = "000111222", BienSo = "00A0-0000", DongXe = "Honda Wave", KichHoat = true } );

            modelBuilder.Entity<KhachHangEntity>()
                .HasData( new KhachHangEntity { Id = 1, UserId = 3, CMND = "123444222" } );

            modelBuilder.Entity<DonHangEntity>()
                .HasData(
                    new DonHangEntity 
                    { 
                        Id = 1, 
                        CuaHangId = 1, 
                        KhachHangId = 1, 
                        ShipperId = null, 
                        DiaChiGiaoId = 2, 
                        NgayGiao = DateTime.Now, 
                        NgayMuaHang = DateTime.Now,
                        PTTTId = 1,
                        TTDHId = 2,
                        TongTien = 500000
                    } 
                );
        }
    }
}
