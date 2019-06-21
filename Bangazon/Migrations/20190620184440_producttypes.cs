using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class producttypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5480d6f4-85f3-4ee6-b963-857de6aaf724", "AQAAAAEAACcQAAAAEFgDoq46vdFSvVQDBI5xXVm0uoIovrXrCmPgiFZkoUhLijIXEBtC+LXN8iu+LXeVbg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f64501bd-5c99-45c6-8b20-233ae2cd2cba", "AQAAAAEAACcQAAAAENtTnxfDq742HdjyHUxlkOpKWRWSNzTGEka+A9rbrFxZE+FXql3bi8TGlXq7klOncA==" });
        }
    }
}
