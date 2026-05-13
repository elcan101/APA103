using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace _27_FrontToBackSqlConnection.Migrations
{
    public partial class AddSliderSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreatedAt", "Desc", "Image", "Order", "Subtitle", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Pronia, With 100% Natural, Organic & Plant Shop.", "1-1-524x617.png", 1, "Discover Now", "Plant For Healthy", false },
                    { 2, new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Pronia, With 100% Natural, Organic & Plant Shop.", "1-2-524x617.png", 2, "Discover Now", "Fresh Your Mind", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
