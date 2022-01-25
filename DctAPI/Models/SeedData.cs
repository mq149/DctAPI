using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Models
{
    public static class SeedData
    {

        public static void Seed(ApplicationDbContext _context, UserManager<UserEntity> _userManage, RoleManager<RoleEntity> _roleManage)
        {
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
            SeedDataCuaHangSanPham(_context);
            SeedDataShipper(_context);
            SeedDataKhachHang(_context);
            SeedDataLoaiDanhGia(_context);
            SeedDataDonHang(_context);
            SeedDataChiTietDonHang(_context);
            SeedDataDanhGia(_context);
        }
        public static void SeedUser(UserManager<UserEntity> _userManage)
        {
            if (_userManage.FindByNameAsync("123456789").Result == null)
            {
                var user1 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user1, RoleName.Admin).Wait();
                }

                var user2 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user2, RoleName.Store).Wait();
                }

                var user3 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user2, RoleName.Customer).Wait();
                }

                var user4 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user4, RoleName.Store).Wait();
                }

                var user5 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user5, RoleName.Shipper).Wait();
                }

                var user6 = new UserEntity()
                {
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
                if (result.Succeeded)
                {
                    _userManage.AddToRoleAsync(user6, RoleName.Customer).Wait();
                }
            }
        }

        public static void SeedRole(RoleManager<RoleEntity> _roleManage)
        {
            if (!_roleManage.RoleExistsAsync(RoleName.Admin).Result)
            {
                var role = new RoleEntity()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Ten = "Admin"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Store).Result)
            {
                var role = new RoleEntity()
                {
                    Name = "CuaHang",
                    NormalizedName = "CuaHang",
                    Ten = "CuaHang"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Shipper).Result)
            {
                var role = new RoleEntity()
                {
                    Name = "Shipper",
                    NormalizedName = "Shipper",
                    Ten = "Shipper"
                };
                _roleManage.CreateAsync(role).Wait();
            }
            if (!_roleManage.RoleExistsAsync(RoleName.Customer).Result)
            {
                var role = new RoleEntity()
                {
                    Name = "KhachHang",
                    NormalizedName = "KhachHang",
                    Ten = "KhachHang"
                };
                _roleManage.CreateAsync(role).Wait();
            }
        }
        public static void SeedDataCauhoiTracNghiem(ApplicationDbContext _context)
        {
            if (!_context.CauHoiTracNghiem.Any())
            {
                _context.CauHoiTracNghiem.AddRange(new CauHoiTracNghiemEntity { /*Id = 1,*/ NoiDung = "Sơ đồ nào sau đây phù hợp với thiết kế động?" },
                    new CauHoiTracNghiemEntity { /*Id = 2,*/ NoiDung = "1+2=?" },
                    new CauHoiTracNghiemEntity { /*Id = 3,*/ NoiDung = "Vai trò nào không có trong ĐI CHỢ THUÊ" },
                    new CauHoiTracNghiemEntity {/* Id = 4,*/ NoiDung = "Trong sơ đồ class, quan hệ aggregration được thể hiện bằng" },
                    new CauHoiTracNghiemEntity { /*Id = 5, */NoiDung = "Trong mô hình MVC, View đóng vai trò" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLuaChonTracNghiem(ApplicationDbContext _context)
        {
            if (!_context.LuaChonTracNghiem.Any())
            {
                _context.LuaChonTracNghiem.AddRange(new LuaChonTracNghiemEntity { NoiDung = "Class diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { /*Id = 2,*/ NoiDung = "Sequence diagram", Dung = true, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { /*Id = 3,*/ NoiDung = "Use case diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity { /*Id = 4,*/ NoiDung = "Package diagram", Dung = false, CauHoiId = 1 },
                    new LuaChonTracNghiemEntity {/* Id = 5,*/ NoiDung = "1", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity {/* Id = 6,*/ NoiDung = "2", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { /*Id = 7,*/ NoiDung = "3", Dung = true, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { /*Id = 8,*/ NoiDung = "4", Dung = false, CauHoiId = 2 },
                    new LuaChonTracNghiemEntity { /*Id = 9,*/ NoiDung = "Shipper", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity {/* Id = 10, */NoiDung = "Khách hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { /*Id = 11,*/ NoiDung = "Nhân viên kho", Dung = true, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { /*Id = 12, */NoiDung = "Cửa hàng", Dung = false, CauHoiId = 3 },
                    new LuaChonTracNghiemEntity { /*Id = 13,*/ NoiDung = "Mũi tên", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { /*Id = 14,*/ NoiDung = "Đường nối", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { /*Id = 15,*/ NoiDung = "Hình thoi đen", Dung = false, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity { /*Id = 16,*/ NoiDung = "Hình thoi trắng", Dung = true, CauHoiId = 4 },
                    new LuaChonTracNghiemEntity {/* Id = 17, */NoiDung = "Gửi request đến và nhận response từ Controller", Dung = true, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity { /*Id = 18, */NoiDung = "Cập nhật giao diện", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity { /*Id = 19,*/ NoiDung = "Kiểm tra logic dữ liệu", Dung = false, CauHoiId = 5 },
                    new LuaChonTracNghiemEntity {/* Id = 20,*/ NoiDung = "Lưu trữ dữ liệu vào database", Dung = false, CauHoiId = 5 });
            }
            _context.SaveChanges();
        }
        public static void SeedDataTrangThaiDonHang(ApplicationDbContext _context)
        {
            if (!_context.TrangThaiDonHang.Any())
            {
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
        public static void SeedDataKhoaDaoTao(ApplicationDbContext _context)
        {
            if (!_context.KhoaDaoTao.Any())
            {
                _context.KhoaDaoTao.AddRange(new KhoaDaoTaoEntity
                {
                    NoiDung = "Khoá đào tạo shipper Đi Chợ Thuê",
                    HuongDan = "Vui lòng xem video hướng dẫn để làm bài kiểm tra.",
                    URL = "https://www.youtube.com/embed/LcRG816Syvc"
                });
            }
            _context.SaveChanges();
        }
        public static void SeedDataHinhAnh(ApplicationDbContext _context)
        {
            if (!_context.HinhAnh.Any())
            {
                _context.HinhAnh.AddRange(
                new HinhAnhEntity
                {
                    Ten = "BapCaiXanh",
                    Url = "https://mamnonhoami.edu.vn/wp-content/uploads/2015/03/bap-cai-xanh-tho-thieu-nhi.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "CaHoi",
                    Url = "https://product.hstatic.net/1000030244/product/04-01_1345365a69c74be0b219a8b041900ae5.png"
                },
                new HinhAnhEntity
                {
                    Ten = "XucXichYummy",
                    Url = "https://cdn.tgdd.vn/Products/Images/7618/228108/bhx/xuc-xich-yummy-la-cusina-goi-200g-202104081103125618.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "BinhNuoc",
                    Url = "https://rangdong.com.vn/uploads/product/Phich/07_P1/07P1-1.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "DuaChuot",
                    Url = "https://orfarm.com.vn/images/products/2020/07/11/original/27_f102291_rau_muong_3962a35b44254dcda56c59ebc01f7594_large_1594444582.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "KemDanhRangBamboo",
                    Url = "https://cdn.tgdd.vn/Products/Images/2446/201929/bhx/kem-danh-rang-bamboo-salt-muoi-hong-himalaya-huong-hoa-bac-ha-100g-202105180930592924.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "KemDanhRangSensodyne",
                    Url = "https://vn-test-11.slatic.net/p/762831f2f357b8987398573274d906b8.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "Chanh",
                    Url = "https://photo-cms-baonghean.zadn.vn/w1000/Uploaded/2022/nkdkswkqoc/201710/original/images2041493_bna_59f1a310655cf.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "CaChua",
                    Url = "https://vtechfarms.com/UploadedFiles/Products/ca%20chua%20(9)_cecp.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "GiayVeSinhSoftly",
                    Url = "https://cdn.tgdd.vn/Products/Images/9081/230825/bhx/10-cuon-giay-ve-sinh-khong-loi-softly-2-lop-202011191535559156.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "BanhDanisa",
                    Url = "https://product.hstatic.net/200000040878/product/banh-quy-bo-danisa-hop-454g-202001091614293310_eaf2eaea88ac4ddc8ba13782c3955be0.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "BanhCustas",
                    Url = "https://www.minhcaumart.vn/media/com_eshop/products/8936036024647%201.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "THKhongDuong",
                    Url = "https://bizweb.dktcdn.net/100/036/299/products/28609619.jpg?v=1543814228377"
                },
                new HinhAnhEntity
                {
                    Ten = "THTraiCay",
                    Url = "https://www.thmilk.vn/wp-content/uploads/2019/11/SCA-trai-cay-800x800.png"
                },
                new HinhAnhEntity
                {
                    Ten = "VinamilkTranChau",
                    Url = "https://cf.shopee.vn/file/9939fe2ac1f2903696afec5f87d05f31"
                },
                new HinhAnhEntity
                {
                    Ten = "DauCa",
                    Url = "https://salt.tikicdn.com/ts/tmp/9a/a0/2c/b6dd861d2a3ee166a22e2f9cf033fe7d.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "CocaCola",
                    Url = "https://cdn.tgdd.vn/Products/Images/2443/248535/bhx/nuoc-ngot-coca-cola-chai-300ml-202110200815513983.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "C2",
                    Url = "https://cdn.tgdd.vn/Products/Images/8938/198132/bhx/hong-tra-dao-c2-455ml-202106230922322630.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "CaRot",
                    Url = "https://phanbonhuunghi.vn/wp-content/uploads/2021/01/image7.png"
                },
                new HinhAnhEntity
                {
                    Ten = "VitaminC",
                    Url = "https://product.hstatic.net/1000304564/product/vitamin-c-500mg-1_d09b948acb4146fc95c74e5fe1e9fe31_master.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "CaThu",
                    Url = "https://cdn.tgdd.vn/2021/06/CookProduct/BeFunky-collage(18)-1200x676.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "BotGiat",
                    Url = "https://storage.googleapis.com/mm-online-bucket/ecommerce-website/uploads/media/53020.jpg"
                },

                new HinhAnhEntity
                {
                    Ten = "RauCu",
                    Url = "https://photo-cms-baonghean.zadn.vn/w607/Uploaded/2021/nkdkswkqoc/201604/original/images1516345_cu_qua_2.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "BachHoaTongHop",
                    Url = "https://posm.asia/wp-content/uploads/2020/10/Thiet-ke-thi-cong-sieu-thi-bach-hoa-xanh-7.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "HaiSan",
                    Url = "https://haisanhoanglong.com/wp-content/uploads/2018/06/hai-san-tuoi-song.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "SieuThiMini",
                    Url = "https://gs25.com.vn/media/1049/cuahang.jpg"
                },
                new HinhAnhEntity
                {
                    Ten = "shoes",
                    Url = "https://i.ibb.co/djqfkpN/shoes.png"
                },
                new HinhAnhEntity
                {
                    Ten = "sweater",
                    Url = "https://i.ibb.co/hY1ft7r/sweater1.png"
                },
                new HinhAnhEntity
                {
                    Ten = "tie",
                    Url = "https://i.ibb.co/YpxxV8L/tie.png"
                },
                new HinhAnhEntity
                {
                    Ten = "shirt",
                    Url = "https://i.ibb.co/KDm7xG1/shirt.png"
                }, new HinhAnhEntity
                {
                    Ten = "trousers",
                    Url = "https://i.ibb.co/JpWst3h/trousers.png"
                },
                new HinhAnhEntity
                {
                    Ten = "shorts",
                    Url = "https://i.ibb.co/4ZN1Rqd/shorts.png"
                });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLoaiSanPham(ApplicationDbContext _context)
        {
            if (!_context.LoaiSanPham.Any())
            {
                _context.LoaiSanPham.AddRange(
                     new LoaiSanPhamEntity { Id = 1, Ten = "Thức ăn", },
                    new LoaiSanPhamEntity { Id = 2, Ten = "Nước Giải Khát" },
                    new LoaiSanPhamEntity { Id = 3, Ten = "Thực phẩm chức năng" },
                    new LoaiSanPhamEntity { Id = 4, Ten = "Hải sản" },
                    new LoaiSanPhamEntity { Id = 5, Ten = "Rau củ" },
                    new LoaiSanPhamEntity { Id = 6, Ten = "Bánh" },
                    new LoaiSanPhamEntity { Id = 7, Ten = "Đồ dùng" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataDiaChi(ApplicationDbContext _context)
        {
            if (!_context.DiaChi.Any())
            {
                _context.DiaChi.AddRange(new DiaChiEntity
                {
                    SoNhaTo = "29",
                    Duong = "Hoàng Diệu",
                    XaPhuong = "Phường 1",
                    QuanHuyen = "Quận 4",
                    TinhTP = "TP Hồ Chí Minh"
                },
                   new DiaChiEntity
                   {
                       SoNhaTo = "69",
                       Duong = "Ba Tháng Hai",
                       XaPhuong = "Phường 10",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity
                   {
                       SoNhaTo = "19",
                       Duong = "Lý Thường Kiệt",
                       XaPhuong = "Phường 3",
                       QuanHuyen = "Quận 10",
                       TinhTP = "TP Hồ Chí Minh"
                   },
                   new DiaChiEntity
                   {
                       SoNhaTo = "12",
                       Duong = "K3",
                       XaPhuong = "Vĩnh Sơn",
                       QuanHuyen = "Vĩnh Thạnh",
                       TinhTP = "Bình Định"
                   },
                   new DiaChiEntity
                   {
                       SoNhaTo = "227",
                       Duong = "Nguyễn Văn Cừ",
                       XaPhuong = "Phường 4",
                       QuanHuyen = "Quận 5",
                       TinhTP = "TP. HCM"
                   },
                   new DiaChiEntity
                   {
                       SoNhaTo = "189C",
                       Duong = "Cống Quỳnh",
                       XaPhuong = "Nguyễn Cư Trinh",
                       QuanHuyen = "Quận 1",
                       TinhTP = "TP. HCM"
                   });
            }
            _context.SaveChanges();
        }
        public static void SeedDataPhuongThucThanhToan(ApplicationDbContext _context)
        {
            if (!_context.PhuongThucThanhToan.Any())
            {
                _context.PhuongThucThanhToan.AddRange(
                     new PhuongThucThanhToanEntity { Ten = "Tiền mặt" },
                   new PhuongThucThanhToanEntity { Ten = "Thẻ ATM" },
                   new PhuongThucThanhToanEntity { Ten = "Ví điện tử" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataNhaSanXuat(ApplicationDbContext _context)
        {
            if (!_context.NhaSanXuat.Any())
            {
                _context.NhaSanXuat.AddRange(new NhaSanXuatEntity {/* Id = 1, */Ten = "Công ty TNHH X", DiaChiId = 1 },
                   new NhaSanXuatEntity { Ten = "Công ty Y", DiaChiId = 2 },
                   new NhaSanXuatEntity { Ten = "Công ty Z", DiaChiId = 3 });
            }
            _context.SaveChanges();
        }
        public static void SeedDataSanPham(ApplicationDbContext _context)
        {
            if (!_context.SanPham.Any())
            {
                _context.SanPham.AddRange(new SanPhamEntity
                {
                    Id = 1,
                    Ten = "Cá Thu",
                    GiaSP = 120000,
                    NgaySanXuat = new DateTime(2015, 12, 25),
                    MoTa = "Rất ngon và rẻ",

                    HinhSanPhamId = 21,
                    LoaiSPId = 4,
                    NSXId = 1

                },
                   new SanPhamEntity
                   {
                       Id = 2,
                       Ten = "Cà Rốt",
                       GiaSP = 12000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "Không ngon đâu",

                       HinhSanPhamId = 19,
                       LoaiSPId = 5,
                       NSXId = 2
                   },
                   new SanPhamEntity
                   {
                       Id = 3,
                       Ten = "Vitamin C",
                       GiaSP = 120000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "C",

                       HinhSanPhamId = 20,
                       LoaiSPId = 3,
                       NSXId = 1

                   },
                   new SanPhamEntity
                   {
                       Id = 4,
                       Ten = "Rau cải xanh",
                       GiaSP = 40000,
                       NgaySanXuat = new DateTime(2015, 12, 25),
                       MoTa = "Tăng cường sức khỏe tim mạch, giàu đạm, hỗ trợ tốt trong giảm cân",

                       HinhSanPhamId = 1,
                       LoaiSPId = 5,
                       NSXId = 1

                   },
                    new SanPhamEntity
                    {
                        Id = 5,
                        Ten = "Cá hồi",
                        GiaSP = 40000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Ít chất béo bão hòa, nhiều protein tốt. Vitamin B12 trong cá hồi giữ cho các tế bào máu và thần kinh hoạt động tốt, giúp tạo DNA.",

                        HinhSanPhamId = 2,
                        LoaiSPId = 4,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 6,
                        Ten = "Xúc xích Yummy",
                        GiaSP = 55000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Chứa rất nhiều protein, bổ sung nhiều khoáng chất có lợi cho cơ thể: sắt, kẽm, canxi, vitamin B6, B12,…giúp tránh tình trạng thiếu máu",

                        HinhSanPhamId = 3,
                        LoaiSPId = 1,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 7,
                        Ten = "Bình nước cầm tay",
                        GiaSP = 154000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Dung tích 700ml, làm từ nhựa PC cao cấp, độ bền cao, giữ nhiệt tốt",

                        HinhSanPhamId = 4,
                        LoaiSPId = 7,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 8,
                        Ten = "Bột giặt Omo 6kg",
                        GiaSP = 226000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Xoáy bay vết bẩn cứng đầu, lưu lại hương thơm bền lâu trên quần áo như được dùng với nước xả. Ưu đãi đến 122.000 đồng",

                        HinhSanPhamId = 22,
                        LoaiSPId = 7,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 9,
                        Ten = "Dưa chuột",
                        GiaSP = 12000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Dưa chuột có nhiều loại vitamin và khoáng chất mà cơ thể cần như vitamin A, B, C, canxi, kẽm",

                        HinhSanPhamId = 5,
                        LoaiSPId = 5,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 10,
                        Ten = "Kem đánh răng Bamboo hoa bạc 100g",
                        GiaSP = 47000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Được chiết xuất từ các thành phần muối tre, bảo vệ bên ngoài những vùng bị tổn thương, cải thiện tình trạng răng ê buốt chỉ trong 3 ngày",

                        HinhSanPhamId = 6,
                        LoaiSPId = 7,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 11,
                        Ten = "Kem đánh răng Sensodyne Multi Care 100g",
                        GiaSP = 60000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Giúp loại bỏ mảng bám, công thức có chứa fluoride giúp ngăn ngừa sâu răng, giúp nướu chắc khỏe",

                        HinhSanPhamId = 7,
                        LoaiSPId = 7,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 12,
                        Ten = "Chanh",
                        GiaSP = 18000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Chanh có nhiều vitamin C, chất xơ và các hợp chất thực vật có lợi khác nhau",

                        HinhSanPhamId = 8,
                        LoaiSPId = 5,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 13,
                        Ten = "Cà chua",
                        GiaSP = 13000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Giàu vitamin, khoáng chất và các loại dưỡng chất quan trọng bao gồm vitamin A, C, K, B6, folate và thiamin",

                        HinhSanPhamId = 9,
                        LoaiSPId = 5,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 14,
                        Ten = "Giấy vệ sinh Softly không lõi",
                        GiaSP = 45000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Chất giấy mềm mại, thấm hút tốt, dùng để vệ sinh cá nhân còn có công dụng lau chùi khu nấu ăn",

                        HinhSanPhamId = 10,
                        LoaiSPId = 7,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 15,
                        Ten = "Hộp bánh Danisa 454g",
                        GiaSP = 72000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Bột lúa mì, đường, bơ (18.67%), dầu thực vật, glucose syrup, trứng, dừa sấy, nho kho, bột sữa tách béo, muối, E503, hương vani tổng hợp.",

                        HinhSanPhamId = 11,
                        LoaiSPId = 6,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 16,
                        Ten = "Bánh Custas",
                        GiaSP = 56000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = " Bánh kem sữa có hương vị nhân kem sữa kiểu mới, được làm từ các nguyên liệu tự nhiên, mang đến hương vị thơm ngon, hấp dẫn",

                        HinhSanPhamId = 12,
                        LoaiSPId = 6,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 17,
                        Ten = "Sữa chua TH không đường 1 lốc 4 hộp",
                        GiaSP = 24500,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Sữa chua TH sử dụng hoàn toàn sữa tươi sạch nguyên chất của trang trại TH, lên men tự nhiên",

                        HinhSanPhamId = 13,
                        LoaiSPId = 1,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 18,
                        Ten = "Sữa chua TH trái cây 1 lốc 4 hộp",
                        GiaSP = 28000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Sữa chua TH sử dụng hoàn toàn sữa tươi sạch nguyên chất của trang trại TH, lên men tự nhiên",

                        HinhSanPhamId = 14,
                        LoaiSPId = 1,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 19,
                        Ten = "Sữa chua Vinamilk trân châu 1 lốc 4 hộp",
                        GiaSP = 28000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Sữa chua Vinamilk sánh mịn hòa quyện cùng hương vị đường đen thơm ngon, trân châu giòn dai ngon miệng",

                        HinhSanPhamId = 15,
                        LoaiSPId = 1,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 20,
                        Ten = "Viên uống Dầu cá Kirkland Fish Oil - 1000mg - 400 viên",
                        GiaSP = 39000,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Giúp mang lại rất nhiều tác dụng trong việc phòng ngừa và cải thiện các vấn đề liên quan đến tim mạch, gan, thị lực,…",

                        HinhSanPhamId = 16,
                        LoaiSPId = 3,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 21,
                        Ten = "Hồng trà đào C2 455ml",
                        GiaSP = 9500,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Giúp giải nhanh cơn khát, bổ sung năng lượng cho ngày dài năng động và sảng khoái",

                        HinhSanPhamId = 18,
                        LoaiSPId = 2,
                        NSXId = 1

                    },
                    new SanPhamEntity
                    {
                        Id = 22,
                        Ten = "Coca cola",
                        GiaSP = 5500,
                        NgaySanXuat = new DateTime(2015, 12, 25),
                        MoTa = "Giúp xua tan nhanh mọi cảm giác mệt mỏi, căng thẳng, đặc biệt thích hợp sử dụng với các hoạt động ngoài trời",

                        HinhSanPhamId = 17,
                        LoaiSPId = 2,
                        NSXId = 1

                    }
                   );
            }
            _context.SaveChanges();
        }
        public static void SeedDataCuaHang(ApplicationDbContext _context)
        {
            if (!_context.CuaHang.Any())
            {
                _context.CuaHang.AddRange(new CuaHangEntity {/* Id = 1, */UserId = 2, LoaiCHId = 1, TenCuaHang = "Bách Hóa X", TrangThaiKichHoat = true, LoaiHinhDangKy = 1 },
                    new CuaHangEntity {/* Id = 2, */UserId = 4, LoaiCHId = 1, TenCuaHang = "Co-op Mart Cống Quỳnh", TrangThaiKichHoat = true, LoaiHinhDangKy = 2 });

            }
            _context.SaveChanges();
        }

        public static void SeedDataCuaHangSanPham(ApplicationDbContext _context)
        {
            if (!_context.CuaHangSanPham.Any())
            {
                _context.CuaHangSanPham.AddRange(


                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 22, SoLuong = 70 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 21, SoLuong = 190 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 20, SoLuong = 300 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 18, SoLuong = 354 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 16, SoLuong = 300 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 14, SoLuong = 470 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 12, SoLuong = 32 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 10, SoLuong = 210 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 8, SoLuong = 350 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 6, SoLuong = 16 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 4, SoLuong = 12 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 17, SoLuong = 320 },
                    new CuaHangSanPhamEntity { CuaHangId = 1, SanPhamId = 2, SoLuong = 300 },

                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 19, SoLuong = 500 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 15, SoLuong = 167 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 13, SoLuong = 312 },

                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 11, SoLuong = 440 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 9, SoLuong = 540 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 7, SoLuong = 33 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 5, SoLuong = 17 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 3, SoLuong = 411 },
                    new CuaHangSanPhamEntity { CuaHangId = 2, SanPhamId = 1, SoLuong = 13 }


                    );
            }
            _context.SaveChanges();
        }
        public static void SeedDataShipper(ApplicationDbContext _context)
        {
            if (!_context.Shipper.Any())
            {
                _context.Shipper.AddRange(new ShipperEntity { /*Id = 1,*/ UserId = 3, KichHoat = true, CMND = "18277821", BienSo = "85D2-12111", DongXe = "Wave" },
                    new ShipperEntity {/* Id = 2, */UserId = 5, KichHoat = true, CMND = "000111222", BienSo = "00A0-0000", DongXe = "Honda Wave" });
            }
            _context.SaveChanges();
        }

        public static void SeedDataKhachHang(ApplicationDbContext _context)
        {
            if (!_context.KhachHang.Any())
            {
                _context.KhachHang.AddRange(new KhachHangEntity { /*Id = 1,*/ UserId = 3, CMND = "18219821", GioiTinh = "Nữ", NgaySinh = new DateTime(1999, 1, 1), HoTen = "Nguyễn Thị X", SDT = "0933113113" },
                    new KhachHangEntity {/* Id = 2,*/ UserId = 6, CMND = "5361152421", GioiTinh = "Nam", NgaySinh = new DateTime(1988, 1, 1), HoTen = "Nguyễn Văn Y", SDT = "0944114114" });
            }
            _context.SaveChanges();
        }
        public static void SeedDataLoaiDanhGia(ApplicationDbContext _context)
        {
            if (!_context.LoaiDanhGia.Any())
            {
                _context.LoaiDanhGia.AddRange(new LoaiDanhGiaEntity { /*Id = 1,*/ Ten = "Shipper" },
                    new LoaiDanhGiaEntity { /*Id = 2,*/ Ten = "Cửa hàng" });
            }
            _context.SaveChanges();
        }

        public static void SeedDataLoaiCuaHang(ApplicationDbContext _context)
        {
            if (!_context.LoaiCuaHang.Any())
            {
                _context.LoaiCuaHang.AddRange(new LoaiCuaHangEntity { /*Id = 1, */Ten = "Siêu Thị Mini", DienGiai = "Kinh doanh tổng hợp các loại mặt hàng thiết yếu, đồ ăn, thức uống và nhu yếu phẩm, v.v", HinhAnhId = 26 },
                    new LoaiCuaHangEntity {/* Id = 2,*/ Ten = "Hải Sản", DienGiai = "Kinh doanh hải sản tươi sống như mực, tôm, cua, ghẹ, cá các loại, v.v", HinhAnhId = 25 },
                    new LoaiCuaHangEntity {/* Id = 3,*/ Ten = "Bách Hóa Tổng Hợp", DienGiai = "Kinh doanh các loại thực phẩm tươi sống như thịt, cá, trứng đến các loại thực phẩm rau củ quả và nhu yếu phẩm, v.v", HinhAnhId = 24 },
                    new LoaiCuaHangEntity {/* Id = 4,*/ Ten = "Rau Củ", DienGiai = "Kinh doanh các loại rau củ quả sạch, v.v", HinhAnhId = 23 });
            }
            _context.SaveChanges();
        }

        public static void SeedDataDonHang(ApplicationDbContext _context)
        {
            if (!_context.DonHang.Any())
            {
                _context.DonHang.AddRange(new DonHangEntity
                {
                    //Id = 1,
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
                      //Id = 2,
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
                      //Id = 3,
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

        public static void SeedDataChiTietDonHang(ApplicationDbContext _context)
        {
            if (!_context.ChiTietDonHang.Any())
            {
                _context.ChiTietDonHang.AddRange(new ChiTietDonHangEntity
                {
                    //Id = 1,
                    DonHangId = 1,
                    SanPhamId = 1,
                    DonGia = 37000,
                    SoLuong = 1,
                    KhoiLuong = 1
                },
                   new ChiTietDonHangEntity
                   {
                       //Id = 2,
                       DonHangId = 1,
                       SanPhamId = 2,
                       DonGia = 25000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       //Id = 3,
                       DonHangId = 2,
                       SanPhamId = 1,
                       DonGia = 500000,
                       SoLuong = 5,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       //Id = 4,
                       DonHangId = 2,
                       SanPhamId = 2,
                       DonGia = 210000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       //Id = 5,
                       DonHangId = 2,
                       SanPhamId = 3,
                       DonGia = 210000,
                       SoLuong = 2,
                       KhoiLuong = 1
                   },
                   new ChiTietDonHangEntity
                   {
                       //Id = 6,
                       DonHangId = 3,
                       SanPhamId = 1,
                       DonGia = 43000,
                       SoLuong = 1,
                       KhoiLuong = 1
                   });
            }
            _context.SaveChanges();
        }

        public static void SeedDataDanhGia(ApplicationDbContext _context)
        {
            if (!_context.DanhGia.Any())
            {
                _context.DanhGia.AddRange(new DanhGiaEntity { /*Id = 1, */DonHangId = 1, LoaiDGId = 1, NoiDung = "Tốt", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 5 },
                    new DanhGiaEntity {/* Id = 2, */DonHangId = 1, LoaiDGId = 2, NoiDung = "Tạm được", NgayDanhGia = new DateTime(2021, 12, 12), SoDiem = 4 });
            }
            _context.SaveChanges();
        }
    }
}
