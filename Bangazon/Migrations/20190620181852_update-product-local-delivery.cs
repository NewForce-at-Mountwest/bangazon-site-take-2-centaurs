using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class updateproductlocaldelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0efd94e2-cf0c-4a2e-9a44-4958915955f0", "AQAAAAEAACcQAAAAEFQeaIfPRMV2g5LFQZZlAd7WbReIk8YFbi7x2z1RqgjgkDWvP79flgLTajXcwqkT/w==" });
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
