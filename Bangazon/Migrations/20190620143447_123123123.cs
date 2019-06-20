using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class _123123123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a8758ab-111a-4a75-9b9a-3e1b0dc8cc43", "AQAAAAEAACcQAAAAEEqjTeUot4eddkUqIT8DuVoxG7JUG1E5Xo0CLDYzUGnSlldumIfyzsTCupHk3LgHpQ==" });
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
