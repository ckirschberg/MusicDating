using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class userinstrumentsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e2ef46b-5927-48d4-ba4f-95f34e8a0dcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc12a777-0aed-4c54-8b15-75c478937bf4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "129814ff-40ba-4dde-a09f-e5c4a463624d", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@daniel.dk", false, "Daniel", "Something", false, null, null, null, null, null, false, "a9169e85-4392-4b12-b70b-ace7ea5c50b0", false, "daniel@daniel.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "22d51e8f-9dce-483b-aedd-924b15f819f2", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simone@simone.dk", false, "Simone", "Something else", false, null, null, null, null, null, false, "95468be8-1fe1-40b7-8313-7689c1d35c29", false, "simone@simone.dk" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 7, "Violin" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 8, "Guitar" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 9, "Piano" });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "1", 7, 3 });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "1", 8, 5 });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "1", 9, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "UserInstruments",
                keyColumns: new[] { "Id", "InstrumentId" },
                keyValues: new object[] { "1", 7 });

            migrationBuilder.DeleteData(
                table: "UserInstruments",
                keyColumns: new[] { "Id", "InstrumentId" },
                keyValues: new object[] { "1", 8 });

            migrationBuilder.DeleteData(
                table: "UserInstruments",
                keyColumns: new[] { "Id", "InstrumentId" },
                keyValues: new object[] { "1", 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bc12a777-0aed-4c54-8b15-75c478937bf4", 0, "820fad0e-adee-4977-840d-3aede56c10ec", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@daniel.dk", false, "Daniel", "Something", false, null, null, null, null, null, false, "9f5eb2ca-30a2-4982-a9c2-2d4609ae7bfa", false, "daniel@daniel.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e2ef46b-5927-48d4-ba4f-95f34e8a0dcb", 0, "9b13cafa-8a02-4321-b496-b892475d099c", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simone@simone.dk", false, "Simone", "Something else", false, null, null, null, null, null, false, "038c10e3-b96c-48c8-a4f7-c2caed1b7d10", false, "simone@simone.dk" });
        }
    }
}
