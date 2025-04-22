using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNHA.Migrations
{
    /// <inheritdoc />
    public partial class FourthUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_Powers_HeroId",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Powers");

            migrationBuilder.CreateTable(
                name: "HeroPower",
                columns: table => new
                {
                    OwnersId = table.Column<int>(type: "int", nullable: false),
                    PowersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroPower", x => new { x.OwnersId, x.PowersId });
                    table.ForeignKey(
                        name: "FK_HeroPower_Heroes_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroPower_Powers_PowersId",
                        column: x => x.PowersId,
                        principalTable: "Powers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroPower_PowersId",
                table: "HeroPower",
                column: "PowersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroPower");

            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "Powers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Powers_HeroId",
                table: "Powers",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id");
        }
    }
}
