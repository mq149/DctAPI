using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DctAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PTTTID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TTDHID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_DonHang_KhachhangEntityID",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_KhachhangEntityID",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "KhachhangEntityID",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TTDHID",
                table: "DonHang",
                newName: "TTDHId");

            migrationBuilder.RenameColumn(
                name: "PTTTID",
                table: "DonHang",
                newName: "PTTTId");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_TTDHID",
                table: "DonHang",
                newName: "IX_DonHang_TTDHId");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_PTTTID",
                table: "DonHang",
                newName: "IX_DonHang_PTTTId");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperID",
                table: "DonHang",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "PhuongThucThanhToan",
                columns: new[] { "ID", "Ten" },
                values: new object[,]
                {
                    { 1, "online" },
                    { 2, "Tiền Mặt" }
                });

            migrationBuilder.InsertData(
                table: "DonHang",
                columns: new[] { "ID", "CuaHangID", "DiaChiGiaoId", "KhachHangID", "NgayGiao", "NgayMuaHang", "PTTTId", "ShipperID", "TTDHId", "TongTien" },
                values: new object[] { 1, 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 0f });

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PTTTId",
                table: "DonHang",
                column: "PTTTId",
                principalTable: "PhuongThucThanhToan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TTDHId",
                table: "DonHang",
                column: "TTDHId",
                principalTable: "TrangThaiDonHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PTTTId",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TTDHId",
                table: "DonHang");

            migrationBuilder.DeleteData(
                table: "DonHang",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "TTDHId",
                table: "DonHang",
                newName: "TTDHID");

            migrationBuilder.RenameColumn(
                name: "PTTTId",
                table: "DonHang",
                newName: "PTTTID");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_TTDHId",
                table: "DonHang",
                newName: "IX_DonHang_TTDHID");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_PTTTId",
                table: "DonHang",
                newName: "IX_DonHang_PTTTID");

            migrationBuilder.AddColumn<int>(
                name: "KhachhangEntityID",
                table: "SanPham",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShipperID",
                table: "DonHang",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_KhachhangEntityID",
                table: "SanPham",
                column: "KhachhangEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhuongThucThanhToan_PTTTID",
                table: "DonHang",
                column: "PTTTID",
                principalTable: "PhuongThucThanhToan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_TrangThaiDonHang_TTDHID",
                table: "DonHang",
                column: "TTDHID",
                principalTable: "TrangThaiDonHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_DonHang_KhachhangEntityID",
                table: "SanPham",
                column: "KhachhangEntityID",
                principalTable: "DonHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
