using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_Seed_For_BranchSubjectChapterLesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "BranchId", "CreatedBy", "CreatedDate", "Description", "IsActive", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7284), "", true, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7285), "Civil Engineering" });

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

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectId", "BranchId", "CreatedBy", "CreatedDate", "Description", "IsActive", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, 1, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7325), "", true, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7326), "Engineering Mechanics" });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "ChapterId", "Content", "CreatedBy", "CreatedDate", "IsActive", "LastModifiedBy", "LastModifiedDate", "Order", "SubjectId", "Title" },
                values: new object[] { 1, "", 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7353), true, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7354), 1, 1, "Chapter-1" });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "LessonId", "ChapterId", "CreatedBy", "CreatedDate", "Description", "IsActive", "LastModifiedBy", "LastModifiedDate", "LessonType", "Title" },
                values: new object[] { 1, 1, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7378), "Lesson on Mechanics", true, 1, new DateTime(2026, 1, 6, 21, 47, 14, 627, DateTimeKind.Local).AddTicks(7379), 1, "Lesson-1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1);

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
        }
    }
}
