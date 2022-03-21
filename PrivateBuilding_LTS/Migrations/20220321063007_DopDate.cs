using Microsoft.EntityFrameworkCore.Migrations;

namespace PrivateBuilding_LTS.Migrations
{
    public partial class DopDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "News");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
