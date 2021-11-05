using Microsoft.EntityFrameworkCore.Migrations;

namespace Godel.Microservice.CurrencyRates.Migrations
{
    public partial class MigrationRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrencyName",
                table: "Currencies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CurrencyCode",
                table: "Currencies",
                newName: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Currencies",
                newName: "CurrencyName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Currencies",
                newName: "CurrencyCode");
        }
    }
}
