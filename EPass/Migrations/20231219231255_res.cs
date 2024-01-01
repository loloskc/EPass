using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPass.Migrations
{
    public partial class res : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "passLabId",
                table: "Responsibles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pass_ResponsibleId",
                table: "Pass",
                column: "ResponsibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pass_Responsibles_ResponsibleId",
                table: "Pass",
                column: "ResponsibleId",
                principalTable: "Responsibles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pass_Responsibles_ResponsibleId",
                table: "Pass");

            migrationBuilder.DropIndex(
                name: "IX_Pass_ResponsibleId",
                table: "Pass");

            migrationBuilder.DropColumn(
                name: "passLabId",
                table: "Responsibles");
        }
    }
}
