using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class paymenttypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PaymentType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbe7b71f-079f-4cc6-b42b-a5ff55f6b421", "AQAAAAEAACcQAAAAEFQTVNnuI+qyncr3t2cszs9EwY/kGKCp/XTpWwKw4v4RqoN8tRm6HoIqbM1MgHJHPA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PaymentType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d248695c-fd3d-4d1c-8a25-d7bf3a92e1c9", "AQAAAAEAACcQAAAAEG7XjH1YahDXW6rII2hLbQgqha8lARNisa2Ii7PPTRdkWUhV9rtNGdahYtDCBRUi+g==" });
        }
    }
}
