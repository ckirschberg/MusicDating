using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class userinstruments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01ad1f1b-0b1a-45b4-bc84-763f521dd4b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8574d573-9428-498a-bbac-556dd13f93d1");

            migrationBuilder.CreateTable(
                name: "UserInstruments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstruments", x => new { x.Id, x.InstrumentId });
                    table.ForeignKey(
                        name: "FK_UserInstruments_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInstruments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bc12a777-0aed-4c54-8b15-75c478937bf4", 0, "820fad0e-adee-4977-840d-3aede56c10ec", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@daniel.dk", false, "Daniel", "Something", false, null, null, null, null, null, false, "9f5eb2ca-30a2-4982-a9c2-2d4609ae7bfa", false, "daniel@daniel.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6e2ef46b-5927-48d4-ba4f-95f34e8a0dcb", 0, "9b13cafa-8a02-4321-b496-b892475d099c", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simone@simone.dk", false, "Simone", "Something else", false, null, null, null, null, null, false, "038c10e3-b96c-48c8-a4f7-c2caed1b7d10", false, "simone@simone.dk" });

            migrationBuilder.CreateIndex(
                name: "IX_UserInstruments_InstrumentId",
                table: "UserInstruments",
                column: "InstrumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInstruments");

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
                values: new object[] { "01ad1f1b-0b1a-45b4-bc84-763f521dd4b5", 0, "20609db4-60ef-4dc1-93d7-45fe46d79ef9", new DateTime(2020, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel@daniel.dk", false, "Daniel", "Something", false, null, null, null, null, null, false, "a52eff03-b949-47ba-93a1-604d8dbd7bcd", false, "daniel@daniel.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8574d573-9428-498a-bbac-556dd13f93d1", 0, "822ee828-6ad1-4a03-a636-6610c32b59c9", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simone@simone.dk", false, "Simone", "Something else", false, null, null, null, null, null, false, "5e37d2dd-27e2-4dc5-b277-741b4bab8394", false, "simone@simone.dk" });
        }
    }
}
