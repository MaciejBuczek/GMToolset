using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class AddedUserToQuickSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "QuickSessions",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuickSessions_UserId",
                table: "QuickSessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuickSessions_AspNetUsers_UserId",
                table: "QuickSessions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuickSessions_AspNetUsers_UserId",
                table: "QuickSessions");

            migrationBuilder.DropIndex(
                name: "IX_QuickSessions_UserId",
                table: "QuickSessions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuickSessions");

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "CharacterCharacteristics",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
