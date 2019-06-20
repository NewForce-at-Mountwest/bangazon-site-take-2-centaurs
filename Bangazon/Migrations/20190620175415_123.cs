using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0c06c73-d765-42be-86d5-69a875f0a0f8", "AQAAAAEAACcQAAAAEOq0L+v30aZnwn1HK9ZnbM3HW2tMSSd1hPshJHABzhjU1P6JNH/lgwTJ8fnwk7wopg==" });
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
