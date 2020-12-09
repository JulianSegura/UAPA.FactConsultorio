using Microsoft.EntityFrameworkCore.Migrations;

namespace UAPA.FactConsultorio.Data.Migrations
{
    public partial class addedCashierUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "SYSADMIN");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Enabled", "Locked", "Name", "Password", "UserName", "UserRole" },
                values: new object[] { 2, true, false, "CASHIER", "????n????:b??????]Z?????:?l?", "CAJERO", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: null);
        }
    }
}
