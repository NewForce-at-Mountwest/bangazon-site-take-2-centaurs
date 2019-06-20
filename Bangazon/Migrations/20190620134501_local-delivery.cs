using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class localdelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "localDeliveryAvailable",
                table: "Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ad6ac42-a932-444a-a080-f5ac95b428cf", "AQAAAAEAACcQAAAAEKQygjrMDFglBkwbJHhGB5EZOxV3dizDjuxg7dTX7pIWnQo/N7I+1FVunq7c/8sTvQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "localDeliveryAvailable",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfb841c1-87bc-440c-9012-60eccd02b710", "AQAAAAEAACcQAAAAEOAsk/pAzBvQ0CaT6/vKUwTxRbVOLWwXV0zeKMml82K3Lx2+3F+YRGgPEx3TDM1LZg==" });
        }
    }
}
