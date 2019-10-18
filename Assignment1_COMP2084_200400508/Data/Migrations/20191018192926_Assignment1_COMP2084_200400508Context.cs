using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1_COMP2084_200400508.Data.Migrations
{
    public partial class Assignment1_COMP2084_200400508Context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tome",
                columns: table => new
                {
                    TomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Pages = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsRented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tome", x => x.TomeId);
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    SpellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TomeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Art = table.Column<string>(nullable: true),
                    Difficulty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.SpellId);
                    table.ForeignKey(
                        name: "FK_Spell_Tome_TomeId",
                        column: x => x.TomeId,
                        principalTable: "Tome",
                        principalColumn: "TomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spell_TomeId",
                table: "Spell",
                column: "TomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "Tome");
        }
    }
}
