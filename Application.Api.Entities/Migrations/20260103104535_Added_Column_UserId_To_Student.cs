using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_Column_UserId_To_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Student",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 3, 16, 15, 34, 356, DateTimeKind.Local).AddTicks(8272), new DateTime(2026, 1, 3, 16, 15, 34, 356, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 3, 16, 15, 34, 356, DateTimeKind.Local).AddTicks(8397), new DateTime(2026, 1, 3, 16, 15, 34, 356, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserId",
                table: "Student",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_UserId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Student");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7700), new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7826), new DateTime(2026, 1, 3, 12, 18, 24, 257, DateTimeKind.Local).AddTicks(7827) });
        }
    }
}
