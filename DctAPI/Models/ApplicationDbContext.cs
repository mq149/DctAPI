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

        internal object Set<T>(object sanPham)
        {
            throw new NotImplementedException();
        }

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
            modelBuilder.Entity<LoaiSanPhamEntity>()
               .HasData(

                    new LoaiSanPhamEntity { ID = 1, Ten = "Thức ăn", },
                    new LoaiSanPhamEntity { ID = 2, Ten = "Nước Giải Khát" },
                    new LoaiSanPhamEntity { ID = 3, Ten = "Thực phẩm chức năng" },
                    new LoaiSanPhamEntity { ID = 4, Ten = "Hải sản" },
                    new LoaiSanPhamEntity { ID = 5, Ten = "Đồ dùng" }
               );

            modelBuilder.Entity<DiaChiEntity>()
               .HasData(
                   new DiaChiEntity
                   {
                       Id = 1,
                       SoNhaTo = "29",
                       Duong = "Hoàng Diệu",
                       XaPhuong = "Phường 1",
                       QuanHuyen = "Quận 4",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity
                   {
                       Id = 2,
                       SoNhaTo = "69",
                       Duong = "Ba Tháng Hai",
                       XaPhuong = "Phường 10",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity
                   {
                       Id = 3,
                       SoNhaTo = "19",
                       Duong = "Lý Thường Kiệt",
                       XaPhuong = "Phường 3",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity
                   {
                       Id = 4,
                       SoNhaTo = "12",
                       Duong = "K3",
                       XaPhuong = "Vĩnh Sơn",
                       QuanHuyen = "Vĩnh Thạnh",
                       TinhTP = "Bình Định"
                   }
               );

            modelBuilder.Entity<PhuongThucThanhToanEntity>()
               .HasData(
                   new PhuongThucThanhToanEntity { ID = 1, Ten = "Tiền mặt" },
                   new PhuongThucThanhToanEntity { ID = 2, Ten = "Thẻ ATM" },
                   new PhuongThucThanhToanEntity { ID = 3, Ten = "Ví điện tử" }
               );

            modelBuilder.Entity<NhaSanXuatEntity>()
              .HasData(
                   new NhaSanXuatEntity { ID = 1, Ten = "Công ty TNHH X", DiaChiId = 1 },
                   new NhaSanXuatEntity { ID = 2, Ten = "Công ty Y", DiaChiId = 2 },
                   new NhaSanXuatEntity { ID = 3, Ten = "Công ty Z", DiaChiId = 3 }
                  );

            modelBuilder.Entity<SanPhamEntity>()
              .HasData(
                   new SanPhamEntity
                   {
                       ID = 1,
                       Ten = "Cá Thu",
                       GiaSP = 120000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "Rất ngon và rẻ",
                       HinhAnhID = 1,
                       LoaiSPID = 4,
                       NSXID = 1
                   },
                   new SanPhamEntity
                   {
                       ID = 2,
                       Ten = "Cà Rốt",
                       GiaSP = 12000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "Không ngon đâu",
                       HinhAnhID = 1,
                       LoaiSPID = 1,
                       NSXID = 1
                   },
                   new SanPhamEntity
                   {
                       ID = 3,
                       Ten = "Vitamin C",
                       GiaSP = 120000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "C",
                       HinhAnhID = 1,
                       LoaiSPID = 3,
                       NSXID = 1
                   }
                    );

            modelBuilder.Entity<UserEntity>()
               .HasData(
                    new UserEntity
                    {
                        Id = 1,
                        RoleId = 1,
                        SDT = "0123",
                        Email = "x@gmail.com",
                        MatKhau = "123",
                        HoTen = "Nguyễn Văn X",
                        GioiTinh = "Nam",
                        NgaySinh = new DateTime(1999, 1, 1),

                    },
                    new UserEntity
                    {
                        Id = 2,
                        RoleId = 2,
                        SDT = "0123",
                        Email = "y@gmail.com",
                        MatKhau = "123",
                        HoTen = "Nguyễn Văn Y",
                        GioiTinh = "Nam",
                        NgaySinh = new DateTime(1999, 1, 1),

                    },
                    new UserEntity
                    {
                        Id = 3,
                        RoleId = 3,
                        SDT = "0123",
                        Email = "z@gmail.com",
                        MatKhau = "123",
                        HoTen = "Nguyễn Văn Z",
                        GioiTinh = "Nam",
                        NgaySinh = new DateTime(1999, 1, 1),

                    },
                    new UserEntity
                    {
                        Id = 4,
                        RoleId = 4,
                        SDT = "0123",
                        Email = "t@gmail.com",
                        MatKhau = "123",
                        HoTen = "Nguyễn Văn T",
                        GioiTinh = "Nữ",
                        NgaySinh = new DateTime(1999, 1, 1),

                    });
            modelBuilder.Entity<KhachHangEntity>()
               .HasData(
                   new KhachHangEntity { ID = 1, CMND = "18219821", UserID = 4 });

            modelBuilder.Entity<ShipperEntity>()
                .HasData(
                   new ShipperEntity { ID = 1, KichHoat = true, CMND = "18277821", UserID = 3, BienSo = "85D2-12111", DongXe = "Wave" });

            modelBuilder.Entity<CuaHangEntity>()
                .HasData(
                    new CuaHangEntity { ID = 1, TrangThaiKichHoat = true, TenCuaHang = "Bách Hóa X", LoaiCHID = 1, UserID = 2 });

            modelBuilder.Entity<LoaiDanhGiaEntity>()
                .HasData(
                    new LoaiDanhGiaEntity { ID = 1, Ten = "Shipper" },
                    new LoaiDanhGiaEntity { ID = 2, Ten = "Cửa hàng" });

            modelBuilder.Entity<LoaiCuaHangEntity>()
                .HasData(
                    new LoaiCuaHangEntity { ID = 1, Ten = "Bán sỉ" },
                    new LoaiCuaHangEntity { ID = 2, Ten = "Bán lẻ" },
                    new LoaiCuaHangEntity { ID = 3, Ten = "Bán quà lưu niệm" },
                    new LoaiCuaHangEntity { ID = 4, Ten = "Bán online" });

            modelBuilder.Entity<DonHangEntity>()
                .HasData(
                  new DonHangEntity
                  {
                      ID = 1,
                      KhachHangID = 1,
                      CuaHangID = 1,
                      ShipperID = 1,
                      DiaChiGiaoId = 1,
                      TTDHId = 1,
                      PTTTId = 1,
                      TongTien = 87000,
                      NgayGiao = new DateTime(2021, 12, 12),
                      NgayMuaHang = new DateTime(2021, 11, 1)
                  },
                  new DonHangEntity
                  {
                      ID = 2,
                      KhachHangID = 1,
                      CuaHangID = 1,
                      ShipperID = 1,
                      DiaChiGiaoId = 2,
                      TTDHId = 2,
                      PTTTId = 1,
                      TongTien = 920000,
                      NgayGiao = new DateTime(2021, 12, 12),
                      NgayMuaHang = new DateTime(2021, 11, 1)
                  }
                );
            modelBuilder.Entity<ChiTietDonHangEntity>()
                .HasData(
                   new ChiTietDonHangEntity
                   {
                       ID = 1,
                       DonHangID = 1,
                       SanPhamID = 1,
                       DonGia = 37000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       ID = 2,
                       DonHangID = 1,
                       SanPhamID = 2,
                       DonGia = 25000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   });

            modelBuilder.Entity<DanhGiaEntity>()
                .HasData(
                    new DanhGiaEntity { ID = 1, DonHangID = 1, LoaiDGID = 1, NoiDung = "Tốt", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 5 },
                    new DanhGiaEntity { ID = 2, DonHangID = 1, LoaiDGID = 2, NoiDung = "Tạm được", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 4 }
                    );
        }
    }
}
