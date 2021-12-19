using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DctAPI.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChiTietDonHang",
                columns: new[] { "ID", "DonGia", "DonHangID", "KhoiLuong", "SanPhamID", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1223f, 2, 1213f, 1, 1212 },
                    { 2, 1223f, 2, 1213f, 1, 1212 }
                });

            migrationBuilder.InsertData(
                table: "DonHang",
                columns: new[] { "ID", "CuaHangID", "DiaChiGiaoId", "KhachHangID", "NgayGiao", "NgayMuaHang", "PTTTId", "ShipperID", "TTDHId", "TongTien" },
                values: new object[] { 2, 1, 1, 1, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 23424f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChiTietDonHang",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChiTietDonHang",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DonHang",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
