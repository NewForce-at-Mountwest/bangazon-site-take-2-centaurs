using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class imagepath2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f763bdd7-1757-446f-95d1-20ac885a6a52", "AQAAAAEAACcQAAAAEGgmEsZMqhogV/HHHVHyJ9Wi9aYAV/IUHrnmYRg17v2C290puCcIqV7KKRqsXty4xg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7f782bd-dc64-44d1-9ca7-f37569fa85ba", "AQAAAAEAACcQAAAAEEYVWkp44Kh3U9H/McoXGdVPboKeb0JtO0lqD+Wz5M8SC/+xT7vZh1X0HGXvYVflGw==" });
        }
    }
}
