using Microsoft.EntityFrameworkCore.Migrations;

namespace UAPA.FactConsultorio.Data.Migrations
{
    public partial class AddedReceiptClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserRole",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserRole",
                value: 1);
        }
    }
}
