using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DctAPI.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CauHoiTracNghiem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoiDung = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoiTracNghiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LuaChonTracNghiem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NoiDung = table.Column<string>(nullable: false),
                    Dung = table.Column<bool>(nullable: false),
                    CauHoiId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_LuaChonTracNghiem_CauHoiId",
                table: "LuaChonTracNghiem",
                column: "CauHoiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LuaChonTracNghiem");

            migrationBuilder.DropTable(
                name: "CauHoiTracNghiem");
        }
    }
}
