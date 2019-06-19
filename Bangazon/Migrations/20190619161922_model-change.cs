using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class modelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4af1b7f9-f6a9-42fd-a561-b598c9e92321", "AQAAAAEAACcQAAAAEAWN9N4Fo3Ek3He3vmmQSZmwfSlLGMFj0Fg0WzsSuzOcONMVRiQKny21HEGwuH7gCw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d248695c-fd3d-4d1c-8a25-d7bf3a92e1c9", "AQAAAAEAACcQAAAAEG7XjH1YahDXW6rII2hLbQgqha8lARNisa2Ii7PPTRdkWUhV9rtNGdahYtDCBRUi+g==" });
        }
    }
}
