using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DctAPI.Migrations
{
    public partial class Initialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CauHoiTracNghiem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoiDung = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoiTracNghiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SoNhaTo = table.Column<string>(nullable: true),
                    Duong = table.Column<string>(nullable: true),
                    XaPhuong = table.Column<string>(nullable: true),
                    QuanHuyen = table.Column<string>(nullable: true),
                    TinhTP = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoaDaoTao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoiDung = table.Column<string>(nullable: true),
                    HuongDan = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaDaoTao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiCuaHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiCuaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDanhGia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDanhGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDonHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDonHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LuaChonTracNghiem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoiDung = table.Column<string>(nullable: false),
                    Dung = table.Column<bool>(nullable: false),
                    CauHoiId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuaChonTracNghiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuaChonTracNghiem_CauHoiTracNghiem_CauHoiId",
                        column: x => x.CauHoiId,
                        principalTable: "CauHoiTracNghiem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhaSanXuat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    DiaChiId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhaSanXuat_DiaChi_DiaChiId",
                        column: x => x.DiaChiId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    SDT = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    HoTen = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: true),
                    AvatarId = table.Column<int>(nullable: true),
                    DiaChiId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_HinhAnh_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_DiaChi_DiaChiId",
                        column: x => x.DiaChiId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrangThaiKichHoat = table.Column<bool>(nullable: false),
                    TenCuaHang = table.Column<string>(nullable: true),
                    LoaiCHId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuaHang_LoaiCuaHang_LoaiCHId",
                        column: x => x.LoaiCHId,
                        principalTable: "LoaiCuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuaHang_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CMND = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHang_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KichHoat = table.Column<bool>(nullable: false),
                    CMND = table.Column<string>(nullable: false),
                    BienSo = table.Column<string>(nullable: false),
                    DongXe = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipper_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoanNganHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenChuTk = table.Column<string>(nullable: true),
                    SoTK = table.Column<string>(nullable: true),
                    TenNganHang = table.Column<string>(nullable: true),
                    MaNganHang = table.Column<string>(nullable: true),
                    LienKet = table.Column<bool>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoanNganHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaiKhoanNganHang_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KhachHangId = table.Column<int>(nullable: false),
                    CuaHangId = table.Column<int>(nullable: false),
                    ShipperId = table.Column<int>(nullable: true),
                    DiaChiGiaoId = table.Column<int>(nullable: false),
                    TTDHId = table.Column<int>(nullable: false),
                    SDT = table.Column<string>(nullable: true),
                    NguoiNhan = table.Column<string>(nullable: true),
                    PTTTId = table.Column<int>(nullable: false),
                    TongTien = table.Column<float>(nullable: false),
                    NgayMuaHang = table.Column<DateTime>(nullable: false),
                    NgayGiao = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonHang_CuaHang_CuaHangId",
                        column: x => x.CuaHangId,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_DiaChi_DiaChiGiaoId",
                        column: x => x.DiaChiGiaoId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_PhuongThucThanhToan_PTTTId",
                        column: x => x.PTTTId,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHang_TrangThaiDonHang_TTDHId",
                        column: x => x.TTDHId,
                        principalTable: "TrangThaiDonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoSoShipper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShipperId = table.Column<int>(nullable: false),
                    NgheNghiep = table.Column<string>(nullable: true),
                    CMNDMatTruocId = table.Column<int>(nullable: true),
                    CMNDMatSauId = table.Column<int>(nullable: true),
                    CMNDNgayCap = table.Column<DateTime>(nullable: true),
                    CMNDNoiCap = table.Column<string>(nullable: true),
                    BLXSo = table.Column<string>(nullable: true),
                    BLXHang = table.Column<string>(nullable: true),
                    BLXMatTruocId = table.Column<int>(nullable: true),
                    BLXMatSauId = table.Column<int>(nullable: true),
                    PhuongTienHinhDauId = table.Column<int>(nullable: true),
                    PhuongTienHinhDuoiId = table.Column<int>(nullable: true),
                    GiayKiemTraXeId = table.Column<int>(nullable: true),
                    GiayDKXMatTruocId = table.Column<int>(nullable: true),
                    GiayDKXMatSauId = table.Column<int>(nullable: true),
                    NamSXXe = table.Column<int>(nullable: true),
                    BHXMatTruocId = table.Column<int>(nullable: true),
                    BHXMatSauId = table.Column<int>(nullable: true),
                    DiemBaiKiemTra = table.Column<decimal>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoShipper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BHXMatSauId",
                        column: x => x.BHXMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BHXMatTruocId",
                        column: x => x.BHXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BLXMatSauId",
                        column: x => x.BLXMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BLXMatTruocId",
                        column: x => x.BLXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_CMNDMatSauId",
                        column: x => x.CMNDMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_CMNDMatTruocId",
                        column: x => x.CMNDMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayDKXMatSauId",
                        column: x => x.GiayDKXMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayDKXMatTruocId",
                        column: x => x.GiayDKXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayKiemTraXeId",
                        column: x => x.GiayKiemTraXeId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_PhuongTienHinhDauId",
                        column: x => x.PhuongTienHinhDauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_PhuongTienHinhDuoiId",
                        column: x => x.PhuongTienHinhDuoiId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonHangId = table.Column<int>(nullable: false),
                    LoaiDGId = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayDanhGia = table.Column<DateTime>(nullable: false),
                    SoDiem = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhGia_DonHang_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGia_LoaiDanhGia_LoaiDGId",
                        column: x => x.LoaiDGId,
                        principalTable: "LoaiDanhGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    GiaSP = table.Column<float>(nullable: false),
                    NgaySanXuat = table.Column<DateTime>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    HinhSanPhamId = table.Column<int>(nullable: false),
                    LoaiSPId = table.Column<int>(nullable: false),
                    NSXId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    DonHangEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_DonHang_DonHangEntityId",
                        column: x => x.DonHangEntityId,
                        principalTable: "DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPham_HinhAnh_HinhSanPhamId",
                        column: x => x.HinhSanPhamId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSPId",
                        column: x => x.LoaiSPId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_NhaSanXuat_NSXId",
                        column: x => x.NSXId,
                        principalTable: "NhaSanXuat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonHangId = table.Column<int>(nullable: false),
                    SanPhamId = table.Column<int>(nullable: false),
                    DonGia = table.Column<float>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    KhoiLuong = table.Column<float>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuaHangSanPham",
                columns: table => new
                {
                    CuaHangId = table.Column<int>(nullable: false),
                    SanPhamId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHangSanPham", x => new { x.CuaHangId, x.SanPhamId });
                    table.ForeignKey(
                        name: "FK_CuaHangSanPham_CuaHang_CuaHangId",
                        column: x => x.CuaHangId,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuaHangSanPham_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AvatarId",
                table: "AspNetUsers",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DiaChiId",
                table: "AspNetUsers",
                column: "DiaChiId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_DonHangId",
                table: "ChiTietDonHang",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_SanPhamId",
                table: "ChiTietDonHang",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_LoaiCHId",
                table: "CuaHang",
                column: "LoaiCHId");

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_UserId",
                table: "CuaHang",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CuaHangSanPham_SanPhamId",
                table: "CuaHangSanPham",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_DonHangId",
                table: "DanhGia",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_LoaiDGId",
                table: "DanhGia",
                column: "LoaiDGId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_CuaHangId",
                table: "DonHang",
                column: "CuaHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_DiaChiGiaoId",
                table: "DonHang",
                column: "DiaChiGiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_KhachHangId",
                table: "DonHang",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_PTTTId",
                table: "DonHang",
                column: "PTTTId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_ShipperId",
                table: "DonHang",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_TTDHId",
                table: "DonHang",
                column: "TTDHId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_BHXMatSauId",
                table: "HoSoShipper",
                column: "BHXMatSauId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_BHXMatTruocId",
                table: "HoSoShipper",
                column: "BHXMatTruocId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_BLXMatSauId",
                table: "HoSoShipper",
                column: "BLXMatSauId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_BLXMatTruocId",
                table: "HoSoShipper",
                column: "BLXMatTruocId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_CMNDMatSauId",
                table: "HoSoShipper",
                column: "CMNDMatSauId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_CMNDMatTruocId",
                table: "HoSoShipper",
                column: "CMNDMatTruocId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_GiayDKXMatSauId",
                table: "HoSoShipper",
                column: "GiayDKXMatSauId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_GiayDKXMatTruocId",
                table: "HoSoShipper",
                column: "GiayDKXMatTruocId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_GiayKiemTraXeId",
                table: "HoSoShipper",
                column: "GiayKiemTraXeId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_PhuongTienHinhDauId",
                table: "HoSoShipper",
                column: "PhuongTienHinhDauId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_PhuongTienHinhDuoiId",
                table: "HoSoShipper",
                column: "PhuongTienHinhDuoiId");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoShipper_ShipperId",
                table: "HoSoShipper",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_UserId",
                table: "KhachHang",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LuaChonTracNghiem_CauHoiId",
                table: "LuaChonTracNghiem",
                column: "CauHoiId");

            migrationBuilder.CreateIndex(
                name: "IX_NhaSanXuat_DiaChiId",
                table: "NhaSanXuat",
                column: "DiaChiId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DonHangEntityId",
                table: "SanPham",
                column: "DonHangEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_HinhSanPhamId",
                table: "SanPham",
                column: "HinhSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSPId",
                table: "SanPham",
                column: "LoaiSPId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_NSXId",
                table: "SanPham",
                column: "NSXId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipper_UserId",
                table: "Shipper",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanNganHang_UserId",
                table: "TaiKhoanNganHang",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "CuaHangSanPham");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "HoSoShipper");

            migrationBuilder.DropTable(
                name: "KhoaDaoTao");

            migrationBuilder.DropTable(
                name: "LuaChonTracNghiem");

            migrationBuilder.DropTable(
                name: "TaiKhoanNganHang");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiDanhGia");

            migrationBuilder.DropTable(
                name: "CauHoiTracNghiem");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");

            migrationBuilder.DropTable(
                name: "CuaHang");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "TrangThaiDonHang");

            migrationBuilder.DropTable(
                name: "LoaiCuaHang");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "DiaChi");
        }
    }
}
