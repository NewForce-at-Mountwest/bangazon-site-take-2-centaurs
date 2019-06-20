using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6639c9c8-38ab-4f59-be2f-93dbaa8bdc8d", "AQAAAAEAACcQAAAAEE6J3gLfcwxYXowa+VkzFcMKcWAUFBTiQ3TSIa7ImCxwoB1XiiNEeBRSmxfk1is79g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd437459-34b6-4d57-bed7-33c9726286a8", "AQAAAAEAACcQAAAAECZDYAswKgp0esdbjeq0yK2Ed6sAgR7oTZjOTMZ2mWN8/Y7tFqfwVlXCgRJnTk40yQ==" });
        }
    }
}
