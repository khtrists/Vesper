using Microsoft.EntityFrameworkCore.Migrations;

namespace Vesper.Migrations
{
    public partial class ServiceTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Services",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Services",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
