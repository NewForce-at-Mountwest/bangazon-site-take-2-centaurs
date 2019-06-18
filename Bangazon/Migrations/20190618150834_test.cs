using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dad111b-826a-44f0-8823-af3843078e1e", "AQAAAAEAACcQAAAAEPmbPZvavTMVBIyV9YrDfa3eRR0q8w2SkpdPP0AMmsRJSl2wqqdXxAwlptCEqrj+pQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbe7b71f-079f-4cc6-b42b-a5ff55f6b421", "AQAAAAEAACcQAAAAEFQTVNnuI+qyncr3t2cszs9EwY/kGKCp/XTpWwKw4v4RqoN8tRm6HoIqbM1MgHJHPA==" });
        }
    }
}
