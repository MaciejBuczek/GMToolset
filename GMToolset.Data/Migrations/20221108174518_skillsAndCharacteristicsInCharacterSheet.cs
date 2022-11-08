using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class skillsAndCharacteristicsInCharacterSheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Characteristics_CharacteristicsId",
                table: "CharacterSheets");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_CharacteristicsId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "CharacteristicsId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Agility",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "AgilityAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "BallisticSkill",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "BallisticSkillAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "DexterityAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Fellowship",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "FellowshipAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Initiattive",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "InitiattiveAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "IntelligenceAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "StrengthAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Toughness",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "ToughnessAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "WeaponSkill",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "WeaponSkillAdv",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Willpower",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "WillpowerAdv",
                table: "Characteristics");

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NameId",
                table: "Characteristics",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CharacterCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CharacteristicsId = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseValue = table.Column<int>(type: "integer", nullable: false),
                    Advancement = table.Column<int>(type: "integer", nullable: false),
                    CharacterSheetId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterCharacteristics_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterCharacteristics_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseValue = table.Column<int>(type: "integer", nullable: false),
                    Advancement = table.Column<int>(type: "integer", nullable: false),
                    CharacterSheetId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_NameId",
                table: "Characteristics",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCharacteristics_CharacteristicsId",
                table: "CharacterCharacteristics",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCharacteristics_CharacterSheetId",
                table: "CharacterCharacteristics",
                column: "CharacterSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_CharacterSheetId",
                table: "CharacterSkills",
                column: "CharacterSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Translations_NameId",
                table: "Characteristics",
                column: "NameId",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Translations_NameId",
                table: "Characteristics");

            migrationBuilder.DropTable(
                name: "CharacterCharacteristics");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_NameId",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Characteristics");

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacteristicsId",
                table: "CharacterSheets",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Agility",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgilityAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BallisticSkill",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BallisticSkillAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DexterityAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fellowship",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FellowshipAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initiattive",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InitiattiveAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StrengthAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Toughness",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToughnessAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkill",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkillAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Willpower",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WillpowerAdv",
                table: "Characteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_CharacteristicsId",
                table: "CharacterSheets",
                column: "CharacteristicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Characteristics_CharacteristicsId",
                table: "CharacterSheets",
                column: "CharacteristicsId",
                principalTable: "Characteristics",
                principalColumn: "Id");
        }
    }
}
