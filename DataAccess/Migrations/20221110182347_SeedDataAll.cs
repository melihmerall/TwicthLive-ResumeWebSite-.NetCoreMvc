using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "GraduationAverage", "SchoolName", "StartDate", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4562), "Güzel bir okuldu", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78f, "DenemeOkulu", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Name", "StartDate", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4595), "Yazılım", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deneme iş Yeri", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4607), "Yürüyüş gezi", "Dağcılık", true });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedDate", "Description", "Level", "Name", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4618), "Akıcı şekilde konuşuyor", "10", "İngilizce", true });

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Name", "StarDate", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4630), "Web sitesi yapımı", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cv Projesi", new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "Id", "CreatedDate", "Description", "JobTitle", "NameSurname", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4649), "iyi bir öğrenci", "Veri Bilimci", "Tolga Boroğlu", true });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Status", "Url" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4660), "Twitter Adresim", "Twitter", true, "https://twitter.com/melihmerall" });

            migrationBuilder.InsertData(
                table: "Talents",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Rate", "Status" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 21, 23, 47, 336, DateTimeKind.Local).AddTicks(4674), "orta derece bilgi sahibi", "C#", "10", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Talents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 10, 21, 5, 41, 627, DateTimeKind.Local).AddTicks(3798));
        }
    }
}
