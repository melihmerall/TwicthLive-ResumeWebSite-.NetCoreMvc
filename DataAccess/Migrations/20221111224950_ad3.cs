using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ad3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarDate" },
                values: new object[] { new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3085));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StarDate" },
                values: new object[] { new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1158), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1201));
        }
    }
}
