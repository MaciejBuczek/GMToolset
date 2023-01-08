using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class SkillForaignKeyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillTypes_TypeId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Skills",
                newName: "SkillTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_TypeId",
                table: "Skills",
                newName: "IX_Skills_SkillTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillTypes_SkillTypeId",
                table: "Skills",
                column: "SkillTypeId",
                principalTable: "SkillTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillTypes_SkillTypeId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "SkillTypeId",
                table: "Skills",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_SkillTypeId",
                table: "Skills",
                newName: "IX_Skills_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillTypes_TypeId",
                table: "Skills",
                column: "TypeId",
                principalTable: "SkillTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
