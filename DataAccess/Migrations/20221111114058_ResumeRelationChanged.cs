using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ResumeRelationChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarDate" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(8127));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarDate" },
                values: new object[] { new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4630), new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4674));
        }
    }
}
