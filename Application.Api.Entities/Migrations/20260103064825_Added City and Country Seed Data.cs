using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class AddedCityandCountrySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7700), true, 1, new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7710), "Nanded" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7826), true, 1, new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7827), "India" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
