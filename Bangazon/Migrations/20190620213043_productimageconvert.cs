using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class productimageconvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Product",
                newName: "ProductImage");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36e8b214-8a92-40d3-bc04-36130cd796f9", "AQAAAAEAACcQAAAAEPmwP4si/rcW/BpJSlrV2ke1l0IzuzSOMdWUM8BGS/hPYJGTYcY9ZFfMsIPQt+R/wQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductImage",
                table: "Product",
                newName: "ImagePath");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d62e279f-ea11-468c-932a-cf575c4c3589", "AQAAAAEAACcQAAAAEMeTItc4PQWiCi63tfUaboiyUYyzigEvs3En3B2jqC3bfnm0W/bf2T0LpXL/DFL6QQ==" });
        }
    }
}
