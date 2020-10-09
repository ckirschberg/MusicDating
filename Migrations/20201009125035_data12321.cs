using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class data12321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01ad1f1b-0b1a-45b4-bc84-763f521dd4b5", 0, "20609db4-60ef-4dc1-93d7-45fe46d79ef9", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@daniel.dk", false, "Daniel", "Something", false, null, null, null, null, null, false, "a52eff03-b949-47ba-93a1-604d8dbd7bcd", false, "daniel@daniel.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8574d573-9428-498a-bbac-556dd13f93d1", 0, "822ee828-6ad1-4a03-a636-6610c32b59c9", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simone@simone.dk", false, "Simone", "Something else", false, null, null, null, null, null, false, "5e37d2dd-27e2-4dc5-b277-741b4bab8394", false, "simone@simone.dk" });

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 1,
                column: "Name",
                value: "Spice Girls");

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 2,
                column: "Name",
                value: "U2");

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 3,
                column: "Name",
                value: "3 doors down");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01ad1f1b-0b1a-45b4-bc84-763f521dd4b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8574d573-9428-498a-bbac-556dd13f93d1");

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 1,
                column: "Name",
                value: "Ensemble 1");

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 2,
                column: "Name",
                value: "Ensemble 2");

            migrationBuilder.UpdateData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 3,
                column: "Name",
                value: "Ensemble 3");
        }
    }
}
