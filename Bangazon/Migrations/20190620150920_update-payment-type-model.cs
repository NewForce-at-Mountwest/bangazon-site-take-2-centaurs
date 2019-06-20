using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class updatepaymenttypemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51fdcfb6-68a5-4758-85e0-98d1165bb47f", "AQAAAAEAACcQAAAAENzxHUvd+zJZ7gJUQmbjGdLLHkU1nzFeMx1A7fhCpjoRmr6QcCRs67bvugOFlSdhHg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd437459-34b6-4d57-bed7-33c9726286a8", "AQAAAAEAACcQAAAAECZDYAswKgp0esdbjeq0yK2Ed6sAgR7oTZjOTMZ2mWN8/Y7tFqfwVlXCgRJnTk40yQ==" });
        }
    }
}
