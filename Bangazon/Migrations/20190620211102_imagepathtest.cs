using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class imagepathtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3abc606a-c6d9-47eb-b226-0d3b0f415839", "AQAAAAEAACcQAAAAEIE13cyzPsXqpOUSA+8K4k0BTo2DejJWL/Zx8e6+leApATEwRXUXFePE5wc3MdjPGg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f763bdd7-1757-446f-95d1-20ac885a6a52", "AQAAAAEAACcQAAAAEGgmEsZMqhogV/HHHVHyJ9Wi9aYAV/IUHrnmYRg17v2C290puCcIqV7KKRqsXty4xg==" });
        }
    }
}
