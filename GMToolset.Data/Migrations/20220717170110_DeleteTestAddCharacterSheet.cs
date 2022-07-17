using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class DeleteTestAddCharacterSheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestModels");

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Species = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Class = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Career = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CarrierTier = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CareerPath = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Height = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Hair = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Eyes = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
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
                    FellowshipAdv = table.Column<int>(type: "integer", nullable: false),
                    Wounds = table.Column<int>(type: "integer", nullable: false),
                    Fate = table.Column<int>(type: "integer", nullable: false),
                    Fortune = table.Column<int>(type: "integer", nullable: false),
                    Resilience = table.Column<int>(type: "integer", nullable: false),
                    Resolve = table.Column<int>(type: "integer", nullable: false),
                    Motivation = table.Column<string>(type: "text", nullable: false),
                    ExpCurrent = table.Column<int>(type: "integer", nullable: false),
                    ExpSpent = table.Column<int>(type: "integer", nullable: false),
                    Movement = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSheets");

            migrationBuilder.CreateTable(
                name: "TestModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestModels", x => x.Id);
                });
        }
    }
}
