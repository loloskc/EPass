using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPass.Migrations
{
    public partial class newAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressLabId",
                table: "Pass",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLabId",
                table: "Pass");
        }
    }
}
