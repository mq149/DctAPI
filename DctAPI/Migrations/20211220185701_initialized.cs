using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DctAPI.Migrations
{
    public partial class initialized : Migration
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
                name: "ChiTietDonHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonHangID = table.Column<int>(nullable: false),
                    SanPhamID = table.Column<int>(nullable: false),
                    DonGia = table.Column<float>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    KhoiLuong = table.Column<float>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CuaHangSanPham",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CuaHangID = table.Column<int>(nullable: false),
                    SanPhamID = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHangSanPham", x => x.ID);
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
                    Id = table.Column<string>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiCuaHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDanhGia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDanhGia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDonHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDonHang", x => x.ID);
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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    DiaChiId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhaSanXuat_DiaChi_DiaChiId",
                        column: x => x.DiaChiId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
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
                    HoTen = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: true),
                    AvatarIdId = table.Column<string>(nullable: true),
                    DiaChiIdId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_HinhAnh_AvatarIdId",
                        column: x => x.AvatarIdId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_DiaChi_DiaChiIdId",
                        column: x => x.DiaChiIdId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoSoShipper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NgheNghiep = table.Column<string>(nullable: true),
                    CMNDMatTruocId = table.Column<string>(nullable: false),
                    CMNDMatSauId = table.Column<string>(nullable: false),
                    CMNDNgayCap = table.Column<DateTime>(nullable: false),
                    CMNDNoiCap = table.Column<string>(nullable: false),
                    BLXSo = table.Column<string>(nullable: false),
                    BLXHang = table.Column<string>(nullable: false),
                    BLXMatTruocId = table.Column<string>(nullable: false),
                    BLXMatSauId = table.Column<string>(nullable: false),
                    PhuongTienHinhDauId = table.Column<string>(nullable: false),
                    PhuongTienHinhDuoiId = table.Column<string>(nullable: false),
                    GiayKiemTraXeId = table.Column<string>(nullable: false),
                    GiayDKXMatTruocId = table.Column<string>(nullable: false),
                    GiayDKXMatSauId = table.Column<string>(nullable: false),
                    NamSxXe = table.Column<int>(nullable: false),
                    BHXMatTruocId = table.Column<string>(nullable: false),
                    BHXMatSauId = table.Column<string>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BHXMatTruocId",
                        column: x => x.BHXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BLXMatSauId",
                        column: x => x.BLXMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_BLXMatTruocId",
                        column: x => x.BLXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_CMNDMatSauId",
                        column: x => x.CMNDMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_CMNDMatTruocId",
                        column: x => x.CMNDMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayDKXMatSauId",
                        column: x => x.GiayDKXMatSauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayDKXMatTruocId",
                        column: x => x.GiayDKXMatTruocId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_GiayKiemTraXeId",
                        column: x => x.GiayKiemTraXeId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_PhuongTienHinhDauId",
                        column: x => x.PhuongTienHinhDauId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoShipper_HinhAnh_PhuongTienHinhDuoiId",
                        column: x => x.PhuongTienHinhDuoiId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KhachHangID = table.Column<int>(nullable: false),
                    CuaHangID = table.Column<int>(nullable: false),
                    ShipperID = table.Column<int>(nullable: false),
                    DiaChiGiaoId = table.Column<int>(nullable: false),
                    TTDHID = table.Column<int>(nullable: true),
                    PTTTID = table.Column<int>(nullable: false),
                    TongTien = table.Column<float>(nullable: false),
                    NgayMuaHang = table.Column<DateTime>(nullable: false),
                    NgayGiao = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DonHang_DiaChi_DiaChiGiaoId",
                        column: x => x.DiaChiGiaoId,
                        principalTable: "DiaChi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_PhuongThucThanhToan_PTTTID",
                        column: x => x.PTTTID,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHang_TrangThaiDonHang_TTDHID",
                        column: x => x.TTDHID,
                        principalTable: "TrangThaiDonHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ten = table.Column<string>(nullable: true),
                    GiaSP = table.Column<float>(nullable: false),
                    NgaySanXuat = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    HinhSanPhamId = table.Column<string>(nullable: true),
                    LoaiSPID = table.Column<int>(nullable: true),
                    NSXID = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_HinhAnh_HinhSanPhamId",
                        column: x => x.HinhSanPhamId,
                        principalTable: "HinhAnh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSPID",
                        column: x => x.LoaiSPID,
                        principalTable: "LoaiSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPham_NhaSanXuat_NSXID",
                        column: x => x.NSXID,
                        principalTable: "NhaSanXuat",
                        principalColumn: "ID",
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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrangThaiKichHoat = table.Column<bool>(nullable: false),
                    TenCuaHang = table.Column<string>(nullable: true),
                    LoaiCHID = table.Column<int>(nullable: true),
                    UserEntityId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CuaHang_LoaiCuaHang_LoaiCHID",
                        column: x => x.LoaiCHID,
                        principalTable: "LoaiCuaHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CuaHang_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CMND = table.Column<string>(nullable: false),
                    UserEntityId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KhachHang_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KichHoat = table.Column<bool>(nullable: false),
                    CMND = table.Column<string>(nullable: false),
                    BienSo = table.Column<string>(nullable: false),
                    DongXe = table.Column<string>(nullable: true),
                    UserEntityId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shipper_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    LienKet = table.Column<bool>(nullable: false),
                    UserEntityId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoanNganHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaiKhoanNganHang_AspNetUsers_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonHangID = table.Column<int>(nullable: false),
                    LoaiDGID = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    NgayDanhGia = table.Column<DateTime>(nullable: false),
                    SoDiem = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DanhGia_DonHang_DonHangID",
                        column: x => x.DonHangID,
                        principalTable: "DonHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGia_LoaiDanhGia_LoaiDGID",
                        column: x => x.LoaiDGID,
                        principalTable: "LoaiDanhGia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CauHoiTracNghiem",
                columns: new[] { "Id", "NoiDung" },
                values: new object[,]
                {
                    { 1, "Sơ đồ nào sau đây phù hợp với thiết kế động?" },
                    { 2, "1+2=?" },
                    { 3, "Vai trò nào không có trong ĐI CHỢ THUÊ" },
                    { 4, "Trong sơ đồ class, quan hệ aggregration được thể hiện bằng" },
                    { 5, "Trong mô hình MVC, View đóng vai trò" }
                });

            migrationBuilder.InsertData(
                table: "KhoaDaoTao",
                columns: new[] { "ID", "HuongDan", "NoiDung", "URL" },
                values: new object[] { 1, "Vui lòng xem video hướng dẫn để làm bài kiểm tra.", "Khoá đào tạo shipper Đi Chợ Thuê", "www.google.com" });

            migrationBuilder.InsertData(
                table: "TrangThaiDonHang",
                columns: new[] { "ID", "Ten" },
                values: new object[,]
                {
                    { 1, "Chờ xác nhận" },
                    { 2, "Cửa hàng đã xác nhận" },
                    { 3, "Đang lấy hàng" },
                    { 4, "Đang giao hàng" },
                    { 5, "Đã giao hàng" },
                    { 6, "Đã huỷ" }
                });

            migrationBuilder.InsertData(
                table: "LuaChonTracNghiem",
                columns: new[] { "Id", "CauHoiId", "Dung", "NoiDung" },
                values: new object[,]
                {
                    { 1, 1, false, "Class diagram" },
                    { 18, 5, false, "Cập nhật giao diện" },
                    { 17, 5, true, "Gửi request đến và nhận response từ Controller" },
                    { 16, 4, true, "Hình thoi trắng" },
                    { 15, 4, false, "Hình thoi đen" },
                    { 14, 4, false, "Đường nối" },
                    { 13, 4, false, "Mũi tên" },
                    { 12, 3, false, "Cửa hàng" },
                    { 11, 3, true, "Nhân viên kho" },
                    { 10, 3, false, "Khách hàng" },
                    { 9, 3, false, "Shipper" },
                    { 8, 2, false, "4" },
                    { 7, 2, true, "3" },
                    { 6, 2, false, "2" },
                    { 5, 2, false, "1" },
                    { 4, 1, false, "Package diagram" },
                    { 3, 1, false, "Use case diagram" },
                    { 2, 1, true, "Sequence diagram" },
                    { 19, 5, false, "Kiểm tra logic dữ liệu" },
                    { 20, 5, false, "Lưu trữ dữ liệu vào database" }
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
                name: "IX_AspNetUsers_AvatarIdId",
                table: "AspNetUsers",
                column: "AvatarIdId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DiaChiIdId",
                table: "AspNetUsers",
                column: "DiaChiIdId");

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
                name: "IX_CuaHang_LoaiCHID",
                table: "CuaHang",
                column: "LoaiCHID");

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_UserEntityId",
                table: "CuaHang",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_DonHangID",
                table: "DanhGia",
                column: "DonHangID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_LoaiDGID",
                table: "DanhGia",
                column: "LoaiDGID");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_DiaChiGiaoId",
                table: "DonHang",
                column: "DiaChiGiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_PTTTID",
                table: "DonHang",
                column: "PTTTID");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_TTDHID",
                table: "DonHang",
                column: "TTDHID");

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
                name: "IX_KhachHang_UserEntityId",
                table: "KhachHang",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_LuaChonTracNghiem_CauHoiId",
                table: "LuaChonTracNghiem",
                column: "CauHoiId");

            migrationBuilder.CreateIndex(
                name: "IX_NhaSanXuat_DiaChiId",
                table: "NhaSanXuat",
                column: "DiaChiId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_HinhSanPhamId",
                table: "SanPham",
                column: "HinhSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSPID",
                table: "SanPham",
                column: "LoaiSPID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_NSXID",
                table: "SanPham",
                column: "NSXID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipper_UserEntityId",
                table: "Shipper",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanNganHang_UserEntityId",
                table: "TaiKhoanNganHang",
                column: "UserEntityId");
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
                name: "CuaHang");

            migrationBuilder.DropTable(
                name: "CuaHangSanPham");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "HoSoShipper");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhoaDaoTao");

            migrationBuilder.DropTable(
                name: "LuaChonTracNghiem");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "TaiKhoanNganHang");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LoaiCuaHang");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "LoaiDanhGia");

            migrationBuilder.DropTable(
                name: "CauHoiTracNghiem");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "TrangThaiDonHang");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "DiaChi");
        }
    }
}
