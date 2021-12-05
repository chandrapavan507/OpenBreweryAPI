using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenBreweryAPI.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Address2", "Address3", "City", "Latitude", "Longitude", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 2, "", "", "Bend", -121.2809536, 44.0912109, "Oregon", "62950 NE 18th St", "97701-9847" },
                    { 3, "", "", "Boise", -116.202929, 43.618516, "Idaho", "826 W Bannock St", "83702-5857" }
                });

            migrationBuilder.InsertData(
                table: "BreweryCategorys",
                columns: new[] { "BreweryCategoryId", "Type" },
                values: new object[,]
                {
                    { 1, "medium" },
                    { 2, "micro" },
                    { 3, "large" }
                });

            migrationBuilder.InsertData(
                table: "Brewerys",
                columns: new[] { "BreweryId", "AddressId", "BreweryCategoryId", "CreatedAt", "Name", "Phone", "UpdatedAt", "WebSiteURL" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(6853), "10-barrel-brewing-co-bend-1", "5415851007", null, "http://www.10barrel.com" });

            migrationBuilder.InsertData(
                table: "Brewerys",
                columns: new[] { "BreweryId", "AddressId", "BreweryCategoryId", "CreatedAt", "Name", "Phone", "UpdatedAt", "WebSiteURL" },
                values: new object[] { 2, 2, 2, new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(7319), "10 Torr Distilling and Brewing", "5415851007", null, "http://www.10barrel.com" });

            migrationBuilder.InsertData(
                table: "Brewerys",
                columns: new[] { "BreweryId", "AddressId", "BreweryCategoryId", "CreatedAt", "Name", "Phone", "UpdatedAt", "WebSiteURL" },
                values: new object[] { 3, 3, 3, new DateTime(2021, 12, 3, 19, 28, 41, 316, DateTimeKind.Utc).AddTicks(7322), "10 Barrel Brewing Co - Bend Pub", "5415851007", null, "http://www.10barrel.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brewerys",
                keyColumn: "BreweryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brewerys",
                keyColumn: "BreweryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brewerys",
                keyColumn: "BreweryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BreweryCategorys",
                keyColumn: "BreweryCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BreweryCategorys",
                keyColumn: "BreweryCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BreweryCategorys",
                keyColumn: "BreweryCategoryId",
                keyValue: 3);
        }
    }
}
