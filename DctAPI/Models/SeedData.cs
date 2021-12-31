using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Models {
    public static class SeedData {

        public static void Seed(ApplicationDbContext _context, UserManager<UserEntity> _userManage, RoleManager<RoleEntity> _roleManage) {
            SeedDataDiaChi(_context);
            SeedDataCauhoiTracNghiem(_context);
            SeedDataLuaChonTracNghiem(_context);
            SeedDataTrangThaiDonHang(_context);
            SeedDataKhoaDaoTao(_context);
            SeedDataHinhAnh(_context);
            SeedDataLoaiSanPham(_context);
            SeedDataPhuongThucThanhToan(_context);
            SeedDataNhaSanXuat(_context);
            SeedDataSanPham(_context);
            SeedRole(_roleManage);
            SeedUser(_userManage);
            SeedDataLoaiCuaHang(_context);
            SeedDataCuaHang(_context);
            SeedDataShipper(_context);
            SeedDataKhachHang(_context);
            SeedDataLoaiDanhGia(_context);
            SeedDataDonHang(_context);
            SeedDataChiTietDonHang(_context);
            SeedDataDanhGia(_context);
        }
        public static void SeedUser(UserManager<UserEntity> _userManage) {
            if (_userManage.FindByNameAsync("123456789").Result == null) {
                var user1 = new UserEntity() {
                    UserName = "123456789",
                    NormalizedUserName = "123456789",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "123456789",
                    HoTen = "Admin",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 1

                };
                var result = _userManage.CreateAsync(user1, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user1, RoleName.Admin).Wait();
                }

                var user2 = new UserEntity() {
                    UserName = "0123456789",
                    NormalizedUserName = "0123456789",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "0123456789",
                    HoTen = "KhachHang",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 1
                };
                var result2 = _userManage.CreateAsync(user2, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user2, RoleName.Store).Wait();
                }

                var user3 = new UserEntity() {
                    UserName = "987654321",
                    NormalizedUserName = "987654321",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "987654321",
                    HoTen = "KhachHang",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 5
                };
                var result3 = _userManage.CreateAsync(user3, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user2, RoleName.Customer).Wait();
                }

                var user4 = new UserEntity() {
                    UserName = "9876543210",
                    NormalizedUserName = "0123456789",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "9876543210",
                    HoTen = "KhachHang",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 6
                };
                var result4 = _userManage.CreateAsync(user4, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user4, RoleName.Store).Wait();
                }

                var user5 = new UserEntity() {
                    UserName = "12344321",
                    NormalizedUserName = "12344321",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "12344321",
                    HoTen = "KhachHang",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 1
                };
                var result5 = _userManage.CreateAsync(user5, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user5, RoleName.Shipper).Wait();
                }

                var user6 = new UserEntity() {
                    UserName = "567898765",
                    NormalizedUserName = "567898765",
                    Email = "Admin@gmail.com",
                    NormalizedEmail = "Admin@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    SDT = "567898765",
                    HoTen = "KhachHang",
                    GioiTinh = "Nam",
                    NgaySinh = DateTime.Now,
                    DiaChiId = 3
                };
                var result6 = _userManage.CreateAsync(user6, "Admin@123").Result;
                if (result.Succeeded) {
                    _userManage.AddToRoleAsync(user6, RoleName.Customer).Wait();
                }
            }
        }

        public static void SeedRole(RoleManager<RoleEntity> _roleManage) {
            if (!_roleManage.RoleExistsAsync(RoleName.Admin).Result) {
                var role = new RoleEntity() {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Ten = "Admin"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Store).Result) {
                var role = new RoleEntity() {
                    Name = "CuaHang",
                    NormalizedName = "CuaHang",
                    Ten = "CuaHang"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Shipper).Result) {
                var role = new RoleEntity() {
                    Name = "Shipper",
                    NormalizedName = "Shipper",
                    Ten = "Shipper"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Customer).Result) {
                var role = new RoleEntity() {
                    Name = "KhachHang",
                    NormalizedName = "KhachHang",
                    Ten = "KhachHang"
                };
                _roleManage.CreateAsync(role).Wait();
            }
        }
        public static void SeedDataCauhoiTracNghiem(ApplicationDbContext _context) {
            if (!_context.CauHoiTracNghiem.Any()) {
                _context.CauHoiTracNghiem.AddRange(new CauHoiTracNghiemEntity { Id = 1, NoiDung = "Sơ đồ nào sau đây phù hợp với thiết kế động?" },
                    new CauHoiTracNghiemEntity { Id = 2, NoiDung = "1+2=?" },
                    new CauHoiTracNghiemEntity { Id = 3, NoiDung = "Vai trò nào không có trong ĐI CHỢ THUÊ" },
                    new CauHoiTracNghiemEntity { Id = 4, NoiDung = "Trong sơ đồ class, quan hệ aggregration được thể hiện bằng" },
                    new CauHoiTracNghiemEntity { Id = 5, NoiDung = "Trong mô hình MVC, View đóng vai trò" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLuaChonTracNghiem(ApplicationDbContext _context) {
            if (!_context.LuaChonTracNghiem.Any()) {
                _context.LuaChonTracNghiem.AddRange(new LuaChonTracNghiemEntity { Id = 1, NoiDung = "Class diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { Id = 2, NoiDung = "Sequence diagram", Dung = true, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { Id = 3, NoiDung = "Use case diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { Id = 4, NoiDung = "Package diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { Id = 5, NoiDung = "1", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { Id = 6, NoiDung = "2", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { Id = 7, NoiDung = "3", Dung = true, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { Id = 8, NoiDung = "4", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { Id = 9, NoiDung = "Shipper", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { Id = 10, NoiDung = "Khách hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { Id = 11, NoiDung = "Nhân viên kho", Dung = true, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { Id = 12, NoiDung = "Cửa hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { Id = 13, NoiDung = "Mũi tên", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { Id = 14, NoiDung = "Đường nối", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { Id = 15, NoiDung = "Hình thoi đen", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { Id = 16, NoiDung = "Hình thoi trắng", Dung = true, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { Id = 17, NoiDung = "Gửi request đến và nhận response từ Controller", Dung = true, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity { Id = 18, NoiDung = "Cập nhật giao diện", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity { Id = 19, NoiDung = "Kiểm tra logic dữ liệu", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity { Id = 20, NoiDung = "Lưu trữ dữ liệu vào database", Dung = false, CauHoiId = 5 });
            }
            _context.SaveChanges();
        }
        public static void SeedDataTrangThaiDonHang(ApplicationDbContext _context) {
            if (!_context.TrangThaiDonHang.Any()) {
                _context.TrangThaiDonHang.AddRange(
                    new TrangThaiDonHangEntity { Id = 1, Ten = "Chờ xác nhận" },
                    new TrangThaiDonHangEntity { Id = 2, Ten = "Cửa hàng đã xác nhận" },
                    new TrangThaiDonHangEntity { Id = 3, Ten = "Đang lấy hàng" },
                    new TrangThaiDonHangEntity { Id = 4, Ten = "Đang giao hàng" },
                    new TrangThaiDonHangEntity { Id = 5, Ten = "Đã giao hàng" },
                    new TrangThaiDonHangEntity { Id = 6, Ten = "Đã huỷ" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataKhoaDaoTao(ApplicationDbContext _context) {
            if (!_context.KhoaDaoTao.Any()) {
                _context.KhoaDaoTao.AddRange(new KhoaDaoTaoEntity {
                    ID = 1,
                    NoiDung = "Khoá đào tạo shipper Đi Chợ Thuê",
                    HuongDan = "Vui lòng xem video hướng dẫn để làm bài kiểm tra.",
                    URL = "https://www.youtube.com/embed/LcRG816Syvc"
                });
            }
            _context.SaveChanges();
        }
        public static void SeedDataHinhAnh(ApplicationDbContext _context) {
            if (!_context.HinhAnh.Any()) {
                _context.HinhAnh.AddRange(
                    new HinhAnhEntity {
                        Id = 1,
                        Ten = "shorts",
                        Url = "https://i.ibb.co/4ZN1Rqd/shorts.png"
                    },
                       new HinhAnhEntity {
                           Id = 2,
                           Ten = "trousers",
                           Url = "https://i.ibb.co/JpWst3h/trousers.png"
                       },
                         new HinhAnhEntity {
                             Id = 3,
                             Ten = "shirt",
                             Url = "https://i.ibb.co/KDm7xG1/shirt.png"
                         },
                           new HinhAnhEntity {
                               Id = 4,
                               Ten = "tie",
                               Url = "https://i.ibb.co/YpxxV8L/tie.png"
                           },
                             new HinhAnhEntity {
                                 Id = 5,
                                 Ten = "sweater",
                                 Url = "https://i.ibb.co/hY1ft7r/sweater1.png"
                             },
                               new HinhAnhEntity {
                                   Id = 6,
                                   Ten = "shoes",
                                   Url = "https://i.ibb.co/djqfkpN/shoes.png"
                               });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLoaiSanPham(ApplicationDbContext _context) {
            if (!_context.LoaiSanPham.Any()) {
                _context.LoaiSanPham.AddRange(
                     new LoaiSanPhamEntity { Id = 1, Ten = "Thức ăn", },
                    new LoaiSanPhamEntity { Id = 2, Ten = "Nước Giải Khát" },
                    new LoaiSanPhamEntity { Id = 3, Ten = "Thực phẩm chức năng" },
                    new LoaiSanPhamEntity { Id = 4, Ten = "Hải sản" },
                    new LoaiSanPhamEntity { Id = 5, Ten = "Đồ dùng" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataDiaChi(ApplicationDbContext _context) {
            if (!_context.DiaChi.Any()) {
                _context.DiaChi.AddRange(new DiaChiEntity {
                    Id = 1,
                    SoNhaTo = "29",
                    Duong = "Hoàng Diệu",
                    XaPhuong = "Phường 1",
                    QuanHuyen = "Quận 4",
                    TinhTP = "TP Hồ Chí Minh"
                },
                   new DiaChiEntity {
                       Id = 2,
                       SoNhaTo = "69",
                       Duong = "Ba Tháng Hai",
                       XaPhuong = "Phường 10",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity {
                       Id = 3,
                       SoNhaTo = "19",
                       Duong = "Lý Thường Kiệt",
                       XaPhuong = "Phường 3",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity {
                       Id = 4,
                       SoNhaTo = "12",
                       Duong = "K3",
                       XaPhuong = "Vĩnh Sơn",
                       QuanHuyen = "Vĩnh Thạnh",
                       TinhTP = "Bình Định"
                   },
                   new DiaChiEntity {
                       Id = 5,
                       SoNhaTo = "227",
                       Duong = "Nguyễn Văn Cừ",
                       XaPhuong = "Phường 4",
                       QuanHuyen = "Quận 5",
                       TinhTP = "TP. HCM"
                   },
                   new DiaChiEntity {
                       Id = 6,
                       SoNhaTo = "189C",
                       Duong = "Cống Quỳnh",
                       XaPhuong = "Nguyễn Cư Trinh",
                       QuanHuyen = "Quận 1",
                       TinhTP = "TP. HCM"
                   });
            }
            _context.SaveChanges();
        }
        public static void SeedDataPhuongThucThanhToan(ApplicationDbContext _context) {
            if (!_context.PhuongThucThanhToan.Any()) {
                _context.PhuongThucThanhToan.AddRange(
                     new PhuongThucThanhToanEntity { Id = 1, Ten = "Tiền mặt" },
                   new PhuongThucThanhToanEntity { Id = 2, Ten = "Thẻ ATM" },
                   new PhuongThucThanhToanEntity { Id = 3, Ten = "Ví điện tử" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataNhaSanXuat(ApplicationDbContext _context) {
            if (!_context.NhaSanXuat.Any()) {
                _context.NhaSanXuat.AddRange(new NhaSanXuatEntity { Id = 1, Ten = "Công ty TNHH X", DiaChiId = 1 },
                   new NhaSanXuatEntity { Id = 2, Ten = "Công ty Y", DiaChiId = 2 },
                   new NhaSanXuatEntity { Id = 3, Ten = "Công ty Z", DiaChiId = 3 });
            }
            _context.SaveChanges();
        }
        public static void SeedDataSanPham(ApplicationDbContext _context) {
            if (!_context.SanPham.Any()) {
                _context.SanPham.AddRange(new SanPhamEntity {
                    Id = 1,
                    Ten = "Cá Thu",
                    GiaSP = 120000,
                    NgaySanXuat = new DateTime(2015, 12, 25),
                    MoTa = "Rất ngon và rẻ",

                    HinhSanPhamId = 1,
                    LoaiSPId = 4,
                    NSXId = 1

                },
                   new SanPhamEntity {
                       Id = 2,
                       Ten = "Cà Rốt",
                       GiaSP = 12000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "Không ngon đâu",

                       HinhSanPhamId = 1,
                       LoaiSPId = 1,
                       NSXId = 2
                   },
                   new SanPhamEntity {
                       Id = 3,
                       Ten = "Vitamin C",
                       GiaSP = 120000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "C",

                       HinhSanPhamId = 1,
                       LoaiSPId = 3,
                       NSXId = 1

                   });
            }
            _context.SaveChanges();
        }
        public static void SeedDataCuaHang(ApplicationDbContext _context) {
            if (!_context.CuaHang.Any()) {
                _context.CuaHang.AddRange(new CuaHangEntity { Id = 1, UserId = 2, LoaiCHId = 1, TenCuaHang = "Bách Hóa X", TrangThaiKichHoat = true },
                    new CuaHangEntity { Id = 2, UserId = 4, LoaiCHId = 1, TenCuaHang = "Co-op Mart Cống Quỳnh", TrangThaiKichHoat = true });
            }
            _context.SaveChanges();
        }
        public static void SeedDataShipper(ApplicationDbContext _context) {
            if (!_context.Shipper.Any()) {
                _context.Shipper.AddRange(new ShipperEntity { Id = 1, UserId = 3, KichHoat = true, CMND = "18277821", BienSo = "85D2-12111", DongXe = "Wave" },
                    new ShipperEntity { Id = 2, UserId = 5, KichHoat = true, CMND = "000111222", BienSo = "00A0-0000", DongXe = "Honda Wave" });
            }
            _context.SaveChanges();
        }

        public static void SeedDataKhachHang(ApplicationDbContext _context) {
            if (!_context.KhachHang.Any()) {
                _context.KhachHang.AddRange(new KhachHangEntity { Id = 1, UserId = 3, CMND = "18219821" },
                    new KhachHangEntity { Id = 2, UserId = 6, CMND = "5361152421" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLoaiDanhGia(ApplicationDbContext _context) {
            if (!_context.LoaiDanhGia.Any()) {
                _context.LoaiDanhGia.AddRange(new LoaiDanhGiaEntity { Id = 1, Ten = "Shipper" },
                    new LoaiDanhGiaEntity { Id = 2, Ten = "Cửa hàng" });
            }
            _context.SaveChanges();
        }

        public static void SeedDataLoaiCuaHang(ApplicationDbContext _context) {
            if (!_context.LoaiCuaHang.Any()) {
                _context.LoaiCuaHang.AddRange(new LoaiCuaHangEntity { Id = 1, Ten = "Bán sỉ" },
                    new LoaiCuaHangEntity { Id = 2, Ten = "Bán lẻ" },
                    new LoaiCuaHangEntity { Id = 3, Ten = "Bán quà lưu niệm" },
                    new LoaiCuaHangEntity { Id = 4, Ten = "Bán online" });
            }
            _context.SaveChanges();
        }

        public static void SeedDataDonHang(ApplicationDbContext _context) {
            if (!_context.DonHang.Any()) {
                _context.DonHang.AddRange(new DonHangEntity {
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
                  new DonHangEntity {
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
                  new DonHangEntity {
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
                  });
            }
            _context.SaveChanges();
        }

        public static void SeedDataChiTietDonHang(ApplicationDbContext _context) {
            if (!_context.ChiTietDonHang.Any()) {
                _context.ChiTietDonHang.AddRange(new ChiTietDonHangEntity {
                    Id = 1,
                    DonHangId = 1,
                    SanPhamId = 1,
                    DonGia = 37000,
                    SoLuong = 1,
                    KhoiLuong = 1
                },
                   new ChiTietDonHangEntity {
                       Id = 2,
                       DonHangId = 1,
                       SanPhamId = 2,
                       DonGia = 25000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity {
                       Id = 3,
                       DonHangId = 2,
                       SanPhamId = 1,
                       DonGia = 500000,
                       SoLuong = 5,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity {
                       Id = 4,
                       DonHangId = 2,
                       SanPhamId = 2,
                       DonGia = 210000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity {
                       Id = 5,
                       DonHangId = 2,
                       SanPhamId = 3,
                       DonGia = 210000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity {
                       Id = 6,
                       DonHangId = 3,
                       SanPhamId = 1,
                       DonGia = 43000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   });
            }
            _context.SaveChanges();
        }

        public static void SeedDataDanhGia(ApplicationDbContext _context) {
            if (!_context.DanhGia.Any()) {
                _context.DanhGia.AddRange(new DanhGiaEntity { Id = 1, DonHangId = 1, LoaiDGId = 1, NoiDung = "Tốt", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 5 },
                    new DanhGiaEntity { Id = 2, DonHangId = 1, LoaiDGId = 2, NoiDung = "Tạm được", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 4 });
            }
            _context.SaveChanges();
        }
    }
}
