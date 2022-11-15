using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class attributesToCharacteristicsRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Attributes_AttributesId",
                table: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.RenameColumn(
                name: "AttributesId",
                table: "CharacterSheets",
                newName: "CharacteristicsId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterSheets_AttributesId",
                table: "CharacterSheets",
                newName: "IX_CharacterSheets_CharacteristicsId");

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WeaponSkill = table.Column<int>(type: "integer", nullable: false),
                    WeaponSkillAdv = table.Column<int>(type: "integer", nullable: false),
                    BallisticSkill = table.Column<int>(type: "integer", nullable: false),
                    BallisticSkillAdv = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    StrengthAdv = table.Column<int>(type: "integer", nullable: false),
                    Toughness = table.Column<int>(type: "integer", nullable: false),
                    ToughnessAdv = table.Column<int>(type: "integer", nullable: false),
                    Initiattive = table.Column<int>(type: "integer", nullable: false),
                    InitiattiveAdv = table.Column<int>(type: "integer", nullable: false),
                    Agility = table.Column<int>(type: "integer", nullable: false),
                    AgilityAdv = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    DexterityAdv = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    IntelligenceAdv = table.Column<int>(type: "integer", nullable: false),
                    Willpower = table.Column<int>(type: "integer", nullable: false),
                    WillpowerAdv = table.Column<int>(type: "integer", nullable: false),
                    Fellowship = table.Column<int>(type: "integer", nullable: false),
                    FellowshipAdv = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Characteristics_CharacteristicsId",
                table: "CharacterSheets",
                column: "CharacteristicsId",
                principalTable: "Characteristics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Characteristics_CharacteristicsId",
                table: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.RenameColumn(
                name: "CharacteristicsId",
                table: "CharacterSheets",
                newName: "AttributesId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterSheets_CharacteristicsId",
                table: "CharacterSheets",
                newName: "IX_CharacterSheets_AttributesId");

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Agility = table.Column<int>(type: "integer", nullable: false),
                    AgilityAdv = table.Column<int>(type: "integer", nullable: false),
                    BallisticSkill = table.Column<int>(type: "integer", nullable: false),
                    BallisticSkillAdv = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    DexterityAdv = table.Column<int>(type: "integer", nullable: false),
                    Fellowship = table.Column<int>(type: "integer", nullable: false),
                    FellowshipAdv = table.Column<int>(type: "integer", nullable: false),
                    Initiattive = table.Column<int>(type: "integer", nullable: false),
                    InitiattiveAdv = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    IntelligenceAdv = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    StrengthAdv = table.Column<int>(type: "integer", nullable: false),
                    Toughness = table.Column<int>(type: "integer", nullable: false),
                    ToughnessAdv = table.Column<int>(type: "integer", nullable: false),
                    WeaponSkill = table.Column<int>(type: "integer", nullable: false),
                    WeaponSkillAdv = table.Column<int>(type: "integer", nullable: false),
                    Willpower = table.Column<int>(type: "integer", nullable: false),
                    WillpowerAdv = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Attributes_AttributesId",
                table: "CharacterSheets",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id");
        }
    }
}
