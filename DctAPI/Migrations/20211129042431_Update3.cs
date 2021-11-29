using Microsoft.EntityFrameworkCore.Migrations;

namespace DctAPI.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrangThaiDonHang",
                keyColumn: "ID",
                keyValue: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
