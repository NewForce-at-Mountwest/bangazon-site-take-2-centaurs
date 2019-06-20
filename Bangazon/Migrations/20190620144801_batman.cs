using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class batman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd437459-34b6-4d57-bed7-33c9726286a8", "AQAAAAEAACcQAAAAECZDYAswKgp0esdbjeq0yK2Ed6sAgR7oTZjOTMZ2mWN8/Y7tFqfwVlXCgRJnTk40yQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfb841c1-87bc-440c-9012-60eccd02b710", "AQAAAAEAACcQAAAAEOAsk/pAzBvQ0CaT6/vKUwTxRbVOLWwXV0zeKMml82K3Lx2+3F+YRGgPEx3TDM1LZg==" });
        }
    }
}
