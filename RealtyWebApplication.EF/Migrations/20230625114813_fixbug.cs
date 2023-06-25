using Microsoft.EntityFrameworkCore.Migrations;

namespace RealtyWebApplication.EF.Migrations
{
    public partial class fixbug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerName",
                table: "Owners",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OwnerName",
                table: "Owners",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
