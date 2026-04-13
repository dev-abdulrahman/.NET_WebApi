using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Api.Entities.Migrations
{
    /// <inheritdoc />
    public partial class Added_FirstNameLastName_Columns_StudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Student",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "BranchId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5676), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "ChapterId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5731), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5548), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5658), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5745), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 4, 13, 11, 46, 38, 350, DateTimeKind.Local).AddTicks(5697) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "FullName");

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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2604), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2569), new DateTime(2026, 2, 11, 20, 10, 52, 858, DateTimeKind.Local).AddTicks(2570) });
        }
    }
}
