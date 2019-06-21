using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class imagepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ImagePath",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7f782bd-dc64-44d1-9ca7-f37569fa85ba", "AQAAAAEAACcQAAAAEEYVWkp44Kh3U9H/McoXGdVPboKeb0JtO0lqD+Wz5M8SC/+xT7vZh1X0HGXvYVflGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Product",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5480d6f4-85f3-4ee6-b963-857de6aaf724", "AQAAAAEAACcQAAAAEFgDoq46vdFSvVQDBI5xXVm0uoIovrXrCmPgiFZkoUhLijIXEBtC+LXN8iu+LXeVbg==" });
        }
    }
}
