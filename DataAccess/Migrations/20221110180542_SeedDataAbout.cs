using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Age", "BirthDate", "CreatedDate", "Description", "Email", "Name", "PhoneNumber", "Status", "Surname" },
                values: new object[] { 1, "24", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 21, 5, 41, 627, DateTimeKind.Local).AddTicks(3798), "Deneme Açıklama", "tolgaboroğlu@gmail.com", "Tolga", "05000000000", true, "Boroğlu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
