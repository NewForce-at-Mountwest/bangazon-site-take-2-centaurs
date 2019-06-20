using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class dbticket3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f64501bd-5c99-45c6-8b20-233ae2cd2cba", "AQAAAAEAACcQAAAAENtTnxfDq742HdjyHUxlkOpKWRWSNzTGEka+A9rbrFxZE+FXql3bi8TGlXq7klOncA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95614617-ebe7-42c1-a2d7-bfefc928c102", "AQAAAAEAACcQAAAAEMd1aKZOexC5HF+4qT6hIXFx465XNRiZYvmocf/NdOu/KgdGpSzkBtvxRFahGJqXBA==" });
        }
    }
}
