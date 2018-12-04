using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class CarChangeInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInHQ",
                table: "Cars",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInHQ",
                table: "Cars");
        }
    }
}
