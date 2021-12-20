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
                        URL = "https://www.youtube.com/embed/LcRG816Syvc"
                    }
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
                   },
                   new DiaChiEntity
                   {
                       Id = 5,
                       SoNhaTo = "227",
                       Duong = "Nguyễn Văn Cừ",
                       XaPhuong = "Phường 4",
                       QuanHuyen = "Quận 5",
                       TinhTP = "TP. HCM"
                   },
                   new DiaChiEntity
                   {
                       Id = 6,
                       SoNhaTo = "189C",
                       Duong = "Cống Quỳnh",
                       XaPhuong = "Nguyễn Cư Trinh",
                       QuanHuyen = "Quận 1",
                       TinhTP = "TP. HCM"
                   }
               );
            
            modelBuilder.Entity<PhuongThucThanhToanEntity>()
               .HasData(
                   new PhuongThucThanhToanEntity { Id = 1, Ten = "Tiền mặt" },
                   new PhuongThucThanhToanEntity { Id = 2, Ten = "Thẻ ATM" },
                   new PhuongThucThanhToanEntity { Id = 3, Ten = "Ví điện tử" }
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
                        DiaChiId = 1,
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
                        DiaChiId = 1,
                        NgaySinh = new DateTime(1999, 1, 1),
                    },
                    new UserEntity
                    {
                        Id = 3,
                        RoleId = 4,
                        HoTen = "Khách hàng A",
                        DiaChiId = 5,
                        SDT = "0123123123",
                        Email = "khachhangA@email.com",
                        MatKhau = "123456"
                    },
                    new UserEntity
                    {
                        Id = 4,
                        RoleId = 2,
                        HoTen = "Cua Hang Co-op Mart",
                        DiaChiId = 6,
                        SDT = "0123456789",
                        Email = "cuahangcoop@email.com",
                        MatKhau = "123456"
                    },
                    new UserEntity
                    {
                        Id = 5,
                        RoleId = 3,
                        HoTen = "Bùi Minh Quân",
                        DiaChiId = 1,
                        SDT = "0124759324",
                        Email = "shipper687@email.com",
                        MatKhau = "123456"
                    },
                    new UserEntity
                    {
                        Id = 6,
                        RoleId = 4,
                        HoTen = "Khách hàng B",
                        DiaChiId = 3,
                        SDT = "0482745323",
                        Email = "khachhangB@email.com",
                        MatKhau = "123456"
                    }
                );
            modelBuilder.Entity<CuaHangEntity>()
                .HasData(
                    new CuaHangEntity { Id = 1, UserId = 2, LoaiCHID = 1, TenCuaHang = "Bách Hóa X",TrangThaiKichHoat = true },
                    new CuaHangEntity { Id = 2, UserId = 4, LoaiCHID = 1, TenCuaHang = "Co-op Mart Cống Quỳnh", TrangThaiKichHoat = true } 
                );

            modelBuilder.Entity<ShipperEntity>()
                .HasData( 
                    new ShipperEntity { Id = 1, UserId = 3, KichHoat = true, CMND = "18277821",BienSo = "85D2-12111", DongXe = "Wave" },
                    new ShipperEntity { Id = 2, UserId = 5, KichHoat = true, CMND = "000111222", BienSo = "00A0-0000", DongXe = "Honda Wave"}
                );

            modelBuilder.Entity<KhachHangEntity>()
                .HasData(
                    new KhachHangEntity { Id = 1, UserId = 3, CMND = "18219821"},
                    new KhachHangEntity { Id = 2, UserId = 6, CMND = "5361152421" }
                );

            modelBuilder.Entity<LoaiDanhGiaEntity>()
                .HasData(
                    new LoaiDanhGiaEntity { ID = 1, Ten = "Shipper" },
                    new LoaiDanhGiaEntity { ID = 2, Ten = "Cửa hàng" });

            modelBuilder.Entity<LoaiCuaHangEntity>()
                .HasData(
                    new LoaiCuaHangEntity { Id = 1, Ten = "Bán sỉ" },
                    new LoaiCuaHangEntity { Id = 2, Ten = "Bán lẻ" },
                    new LoaiCuaHangEntity { Id = 3, Ten = "Bán quà lưu niệm" },
                    new LoaiCuaHangEntity { Id = 4, Ten = "Bán online" });

            modelBuilder.Entity<DonHangEntity>()
                .HasData(
                  new DonHangEntity
                  {
                      Id = 1,
                      KhachHangId = 1,
                      CuaHangId = 1,
                      ShipperId = 1,
                      DiaChiGiaoId = 1,
                      TTDHId = 5,
                      PTTTId = 1,
                      TongTien = 87000,
                      NgayGiao = new DateTime(2021, 12, 12),
                      NgayMuaHang = new DateTime(2021, 11, 1)
                  },
                  new DonHangEntity
                  {
                      Id = 2,
                      KhachHangId = 1,
                      CuaHangId = 1,
                      ShipperId = null,
                      DiaChiGiaoId = 2,
                      TTDHId = 2,
                      PTTTId = 1,
                      TongTien = 920000,
                      NgayGiao = new DateTime(2021, 12, 12),
                      NgayMuaHang = new DateTime(2021, 11, 1)
                  },
                  new DonHangEntity
                  {
                      Id = 3,
                      KhachHangId = 2,
                      CuaHangId = 2,
                      ShipperId = null,
                      DiaChiGiaoId = 2,
                      TTDHId = 2,
                      PTTTId = 2,
                      TongTien = 43000,
                      NgayGiao = new DateTime(2021, 12, 12),
                      NgayMuaHang = new DateTime(2021, 11, 1)
                  }
                );
            modelBuilder.Entity<ChiTietDonHangEntity>()
                .HasData(
                   new ChiTietDonHangEntity
                   {
                       Id = 1,
                       DonHangId = 1,
                       SanPhamId = 1,
                       DonGia = 37000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       Id = 2,
                       DonHangId = 1,
                       SanPhamId = 2,
                       DonGia = 25000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       Id = 3,
                       DonHangId = 2,
                       SanPhamId = 1,
                       DonGia = 500000,
                       SoLuong = 5,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       Id = 4,
                       DonHangId = 2,
                       SanPhamId = 2,
                       DonGia = 210000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       Id = 5,
                       DonHangId = 2,
                       SanPhamId = 3,
                       DonGia = 210000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       Id = 6,
                       DonHangId = 3,
                       SanPhamId = 1,
                       DonGia = 43000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   }
               );

            modelBuilder.Entity<DanhGiaEntity>()
                .HasData(
                    new DanhGiaEntity { ID = 1, DonHangId = 1, LoaiDGId = 1, NoiDung = "Tốt", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 5 },
                    new DanhGiaEntity { ID = 2, DonHangId = 1, LoaiDGId = 2, NoiDung = "Tạm được", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 4 }
                    );
        }
}
}
