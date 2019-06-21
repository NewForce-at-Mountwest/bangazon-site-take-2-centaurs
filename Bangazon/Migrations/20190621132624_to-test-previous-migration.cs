using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class totestpreviousmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64adecf3-c60e-4694-a55e-a458d2fcb265", "AQAAAAEAACcQAAAAEPxsVzplaJ0pX8Amt9kkb+h6+cIWlR7znYkttIEKNcASz9l/E1ss0sIkRHUmV165Jg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16bbcb99-5af0-499c-8e51-bb4a4e139750", "AQAAAAEAACcQAAAAEOrCCiBa5NSym0UmWQmgkSz9ubB7Pf6ckQNO/EXmg+IA9XNm7spayuvz6JSwqrDCig==" });
        }
    }
}
