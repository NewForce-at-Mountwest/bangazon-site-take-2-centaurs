using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class localdeliveryfalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b0413fa-5cf4-450a-9c75-2d7c83a3239e", "AQAAAAEAACcQAAAAEChK3E8O7VPt4IoDt+fDVzuehOpN2RadC0kUHdZFq/M86VubnMm3n5/1kkXXcEfUrA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b3339ee-1671-4313-ab89-68b6c10c0096", "AQAAAAEAACcQAAAAEEiE6XaqO87LF8QH+9YY6RvCWaixTC0+oHzK/e4ShgQz0jIGStZgRpvMekRrX8w4qw==" });
        }
    }
}
