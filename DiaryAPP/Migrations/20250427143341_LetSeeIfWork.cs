using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryAPP.Migrations
{
    /// <inheritdoc />
    public partial class LetSeeIfWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Hiking", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go on Hiking" },
                    { 2, "Shop", new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go on Shopping" },
                    { 3, "Ski", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go on Skiing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryEntries");
        }
    }
}
