using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_Duration_Column_To_Lesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Lesson",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2522), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2586), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2393), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2504), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Duration", "LastModifiedDate", "VideoUrl" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2604), null });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2569), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2570) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Lesson");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9391), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9544), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9106), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9573), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9430), new DateTime(2026, 1, 14, 19, 7, 8, 757, DateTimeKind.Local).AddTicks(9431) });
        }
    }
}
