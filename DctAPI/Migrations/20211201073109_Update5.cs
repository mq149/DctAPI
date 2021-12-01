using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DctAPI.Migrations
{
    public partial class Update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaDaoTaoEntity",
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
                    table.PrimaryKey("PK_KhoaDaoTaoEntity", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "KhoaDaoTaoEntity",
                columns: new[] { "ID", "HuongDan", "NoiDung", "URL" },
                values: new object[] { 1, "Vui lòng xem video hướng dẫn để làm bài kiểm tra.", "Khoá đào tạo shipper Đi Chợ Thuê", "www.google.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhoaDaoTaoEntity");
        }
    }
}
