using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMToolset.Data.Migrations
{
    public partial class SplitAttriburesFromCharacterSheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agility",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "AgilityAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "BallisticSkill",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "BallisticSkillAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "DexterityAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Fellowship",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "FellowshipAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Initiattive",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "InitiattiveAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "IntelligenceAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "StrengthAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Toughness",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "ToughnessAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "WeaponSkill",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "WeaponSkillAdv",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Willpower",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "WillpowerAdv",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Hair",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Eyes",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<Guid>(
                name: "AttributesId",
                table: "CharacterSheets",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attributes",
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
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_AttributesId",
                table: "CharacterSheets",
                column: "AttributesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Attributes_AttributesId",
                table: "CharacterSheets",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Attributes_AttributesId",
                table: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_AttributesId",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "AttributesId",
                table: "CharacterSheets");

            migrationBuilder.AlterColumn<string>(
                name: "Motivation",
                table: "CharacterSheets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hair",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Eyes",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "CharacterSheets",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Agility",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgilityAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BallisticSkill",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BallisticSkillAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DexterityAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fellowship",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FellowshipAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initiattive",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InitiattiveAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StrengthAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Toughness",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToughnessAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkill",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponSkillAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Willpower",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WillpowerAdv",
                table: "CharacterSheets",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
