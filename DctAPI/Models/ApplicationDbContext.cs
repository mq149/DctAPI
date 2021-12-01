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
                    new TrangThaiDonHangEntity { ID = 1, Ten = "Chờ xác nhận"},
                    new TrangThaiDonHangEntity { ID = 2, Ten = "Cửa hàng đã xác nhận" },
                    new TrangThaiDonHangEntity { ID = 3, Ten = "Đang lấy hàng" },
                    new TrangThaiDonHangEntity { ID = 4, Ten = "Đang giao hàng" },
                    new TrangThaiDonHangEntity { ID = 5, Ten = "Đã giao hàng" },
                    new TrangThaiDonHangEntity { ID = 6, Ten = "Đã huỷ" }
                );
            modelBuilder.Entity<RoleEntity>()
               .HasData(
                   new RoleEntity { ID = 1, Ten = "Admin" },
                   new RoleEntity { ID = 2, Ten = "Cửa Hàng" },
                   new RoleEntity { ID = 3, Ten = "Shipper" },
                   new RoleEntity { ID = 4, Ten = "Khách Hàng" }
               );

            modelBuilder.Entity<KhoaDaoTaoEntity>()
                .HasData(
                    new KhoaDaoTaoEntity { ID = 1,
                        NoiDung = "Khoá đào tạo shipper Đi Chợ Thuê",
                        HuongDan = "Vui lòng xem video hướng dẫn để làm bài kiểm tra.",
                        URL = "www.google.com"}
                );
        }
    }
}
