using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class skillTypesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Skills");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacteristicId",
                table: "Skills",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Skills",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "SkillTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillTypes_Translations_NameId",
                        column: x => x.NameId,
                        principalTable: "Translations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacteristicId",
                table: "Skills",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TypeId",
                table: "Skills",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTypes_NameId",
                table: "SkillTypes",
                column: "NameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Characteristics_CharacteristicId",
                table: "Skills",
                column: "CharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillTypes_TypeId",
                table: "Skills",
                column: "TypeId",
                principalTable: "SkillTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Characteristics_CharacteristicId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillTypes_TypeId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "SkillTypes");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CharacteristicId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_TypeId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Skills",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
