using Microsoft.EntityFrameworkCore.Migrations;

namespace DctAPI.Migrations
{
    public partial class Update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KhoaDaoTaoEntity",
                table: "KhoaDaoTaoEntity");

            migrationBuilder.RenameTable(
                name: "KhoaDaoTaoEntity",
                newName: "KhoaDaoTao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhoaDaoTao",
                table: "KhoaDaoTao",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KhoaDaoTao",
                table: "KhoaDaoTao");

            migrationBuilder.RenameTable(
                name: "KhoaDaoTao",
                newName: "KhoaDaoTaoEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhoaDaoTaoEntity",
                table: "KhoaDaoTaoEntity",
                column: "ID");
        }
    }
}
