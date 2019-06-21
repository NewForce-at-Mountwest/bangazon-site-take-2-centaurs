using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class refactorproducttoacceptimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Product");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProductImage",
                table: "Product",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16bbcb99-5af0-499c-8e51-bb4a4e139750", "AQAAAAEAACcQAAAAEOrCCiBa5NSym0UmWQmgkSz9ubB7Pf6ckQNO/EXmg+IA9XNm7spayuvz6JSwqrDCig==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Product",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95614617-ebe7-42c1-a2d7-bfefc928c102", "AQAAAAEAACcQAAAAEMd1aKZOexC5HF+4qT6hIXFx465XNRiZYvmocf/NdOu/KgdGpSzkBtvxRFahGJqXBA==" });
        }
    }
}
