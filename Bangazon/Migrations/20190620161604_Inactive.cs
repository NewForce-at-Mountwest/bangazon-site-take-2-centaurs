using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class Inactive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "PaymentType",
                newName: "Inactive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95614617-ebe7-42c1-a2d7-bfefc928c102", "AQAAAAEAACcQAAAAEMd1aKZOexC5HF+4qT6hIXFx465XNRiZYvmocf/NdOu/KgdGpSzkBtvxRFahGJqXBA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inactive",
                table: "PaymentType",
                newName: "IsActive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd437459-34b6-4d57-bed7-33c9726286a8", "AQAAAAEAACcQAAAAECZDYAswKgp0esdbjeq0yK2Ed6sAgR7oTZjOTMZ2mWN8/Y7tFqfwVlXCgRJnTk40yQ==" });
        }
    }
}
