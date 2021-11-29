using Microsoft.EntityFrameworkCore.Migrations;

namespace DctAPI.Migrations
{
    public partial class Update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_User_UserEntityId",
                table: "Shippers");

            migrationBuilder.DropForeignKey(
                name: "FK_User_RoleEntity_RoleID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shippers",
                table: "Shippers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleEntity",
                table: "RoleEntity");

            migrationBuilder.RenameTable(
                name: "Shippers",
                newName: "Shipper");

            migrationBuilder.RenameTable(
                name: "RoleEntity",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_Shippers_UserEntityId",
                table: "Shipper",
                newName: "IX_Shipper_UserEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipper_User_UserEntityId",
                table: "Shipper",
                column: "UserEntityId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipper_User_UserEntityId",
                table: "Shipper");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "Shipper",
                newName: "Shippers");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "RoleEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Shipper_UserEntityId",
                table: "Shippers",
                newName: "IX_Shippers_UserEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shippers",
                table: "Shippers",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleEntity",
                table: "RoleEntity",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_User_UserEntityId",
                table: "Shippers",
                column: "UserEntityId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_RoleEntity_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "RoleEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
