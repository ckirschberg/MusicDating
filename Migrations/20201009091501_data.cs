using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ensemble",
                columns: new[] { "EnsembleId", "CoverImage", "Description", "Name" },
                values: new object[] { 1, null, null, "Ensemble 1" });

            migrationBuilder.InsertData(
                table: "Ensemble",
                columns: new[] { "EnsembleId", "CoverImage", "Description", "Name" },
                values: new object[] { 2, null, null, "Ensemble 2" });

            migrationBuilder.InsertData(
                table: "Ensemble",
                columns: new[] { "EnsembleId", "CoverImage", "Description", "Name" },
                values: new object[] { 3, null, null, "Ensemble 3" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 1, "Classical" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 2, "Rock" });

            migrationBuilder.InsertData(
                table: "GenreEnsemble",
                columns: new[] { "GenreId", "EnsembleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "GenreEnsemble",
                columns: new[] { "GenreId", "EnsembleId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "GenreEnsemble",
                columns: new[] { "GenreId", "EnsembleId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenreEnsemble",
                keyColumns: new[] { "GenreId", "EnsembleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GenreEnsemble",
                keyColumns: new[] { "GenreId", "EnsembleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "GenreEnsemble",
                keyColumns: new[] { "GenreId", "EnsembleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ensemble",
                keyColumn: "EnsembleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);
        }
    }
}
