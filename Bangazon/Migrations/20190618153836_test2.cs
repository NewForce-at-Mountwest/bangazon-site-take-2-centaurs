using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f6ef066-e378-44a6-9f63-7e35749bb0d0", "AQAAAAEAACcQAAAAEH91/luOqkRl4DyvVCFjuW13Vxi7ehGX50vefqjWscxJH3nvtb3hm9BSJhsU9PFqMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dad111b-826a-44f0-8823-af3843078e1e", "AQAAAAEAACcQAAAAEPmbPZvavTMVBIyV9YrDfa3eRR0q8w2SkpdPP0AMmsRJSl2wqqdXxAwlptCEqrj+pQ==" });
        }
    }
}
