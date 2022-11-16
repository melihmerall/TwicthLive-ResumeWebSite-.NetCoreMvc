using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Age", "BirthDate", "CreatedDate", "Description", "Email", "Name", "PhoneNumber", "Status", "Surname" },
                values: new object[] { 2, "23", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(846), "Emin durukan hakkında sayfası", "emin@gmail.com", "Emin", "00000000000", true, "Durukan" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "GraduationAverage", "SchoolName", "StartDate", "Status" },
                values: new object[] { 2, new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1029), "Hoş bir Okul", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Atü", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

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
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 16, 17, 930, DateTimeKind.Local).AddTicks(1158));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2);

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
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 14, 40, 57, 734, DateTimeKind.Local).AddTicks(8077));

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
    }
}
