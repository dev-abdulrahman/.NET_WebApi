using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_PriceDiscount_Subject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Subject",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Subject",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9073), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9108), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(8952), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9056), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9123), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Discount", "LastModifiedDate", "Price" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9091), null, new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9092), 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Subject");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7005), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7044), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(6868), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(6985), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7061), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7026), new DateTime(2026, 4, 13, 15, 28, 4, 294, DateTimeKind.Local).AddTicks(7026) });
        }
    }
}
