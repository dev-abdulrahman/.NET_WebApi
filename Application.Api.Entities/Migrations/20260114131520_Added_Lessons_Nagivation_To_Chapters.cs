using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_Lessons_Nagivation_To_Chapters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6940), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6989), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6726), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6918), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(7009), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6966), new DateTime(2026, 1, 14, 18, 45, 19, 361, DateTimeKind.Local).AddTicks(6967) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7284), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7353), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(6992), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7254), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7378), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7325), new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7326) });
        }
    }
}
