using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DctAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Role = table.Column<int>(nullable: false),
                    SDT = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MatKhau = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    GioiTinh = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: true),
                    AvataId = table.Column<int>(nullable: true),
                    DiaChiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CMND = table.Column<string>(nullable: false),
                    UserEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_KhachHang_User_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_UserEntityId",
                table: "KhachHang",
                column: "UserEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
