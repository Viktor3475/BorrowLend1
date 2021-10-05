using Microsoft.EntityFrameworkCore.Migrations;

namespace BorrowLend.Migrations
{
    public partial class qwer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Items1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items1",
                table: "Items1",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items1",
                table: "Items1");

            migrationBuilder.RenameTable(
                name: "Items1",
                newName: "Items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");
        }
    }
}
