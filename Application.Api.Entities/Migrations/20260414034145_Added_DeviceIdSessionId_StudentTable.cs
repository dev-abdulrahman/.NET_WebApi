using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_DeviceIdSessionId_StudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoundDeviceId",
                table: "Student",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentSessionId",
                table: "Student",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(190), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(229), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(43), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(166), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(245), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(213), new DateTime(2026, 4, 14, 9, 11, 44, 371, DateTimeKind.Local).AddTicks(214) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoundDeviceId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CurrentSessionId",
                table: "Student");

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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9091), new DateTime(2026, 4, 13, 15, 35, 38, 476, DateTimeKind.Local).AddTicks(9092) });
        }
    }
}
