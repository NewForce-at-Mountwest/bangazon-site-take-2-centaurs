using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b3339ee-1671-4313-ab89-68b6c10c0096", "AQAAAAEAACcQAAAAEEiE6XaqO87LF8QH+9YY6RvCWaixTC0+oHzK/e4ShgQz0jIGStZgRpvMekRrX8w4qw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ad6ac42-a932-444a-a080-f5ac95b428cf", "AQAAAAEAACcQAAAAEKQygjrMDFglBkwbJHhGB5EZOxV3dizDjuxg7dTX7pIWnQo/N7I+1FVunq7c/8sTvQ==" });
        }
    }
}
