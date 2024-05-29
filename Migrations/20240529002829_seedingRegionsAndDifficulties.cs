using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Walks.Migrations
{
    /// <inheritdoc />
    public partial class seedingRegionsAndDifficulties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2201c851-ba47-47ea-aadf-bb9b7ac80216"), "Easy" },
                    { new Guid("45359600-275a-4179-a2d3-c375b7a3dca8"), "Hard" },
                    { new Guid("8d8e7199-0409-4cea-8d33-6eabdaeb7d50"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("1b8e159e-5345-42aa-be45-57dec1ed71bd"), "RIX", "Riga", "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("8b9399fc-980d-44fd-aafa-e896f9637103"), "LAR", "Larnaca", "https://images.unsplash.com/photo-1515896480369-9c67a87f4ca8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("dc1cae41-d002-4ae6-a829-0065c17ed534"), "VNO", "Vilnius", "https://images.unsplash.com/photo-1542601904570-411afe2eab2a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("e7dd40f4-32a8-4e97-978e-281764a355e6"), "KLA", "Klaipeda", "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2201c851-ba47-47ea-aadf-bb9b7ac80216"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("45359600-275a-4179-a2d3-c375b7a3dca8"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("8d8e7199-0409-4cea-8d33-6eabdaeb7d50"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b8e159e-5345-42aa-be45-57dec1ed71bd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8b9399fc-980d-44fd-aafa-e896f9637103"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dc1cae41-d002-4ae6-a829-0065c17ed534"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e7dd40f4-32a8-4e97-978e-281764a355e6"));
        }
    }
}
