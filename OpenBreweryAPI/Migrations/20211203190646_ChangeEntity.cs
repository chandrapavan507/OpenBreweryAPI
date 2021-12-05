using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenBreweryAPI.Migrations
{
    public partial class ChangeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Addresses",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Addresses",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Address2", "Address3", "City", "Latitude", "Longitude", "State", "Street", "ZipCode" },
                values: new object[] { 1, "", "", "Knox", -86.627954000000003, 41.289715000000001, "Indiana", "400 Brown Cir", "46534" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.AlterColumn<float>(
                name: "Longitude",
                table: "Addresses",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Latitude",
                table: "Addresses",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
