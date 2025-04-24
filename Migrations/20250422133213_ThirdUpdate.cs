using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNHA.Migrations
{
    /// <inheritdoc />
    public partial class ThirdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "Powers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Powers_HeroId",
                table: "Powers",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_SchoolId",
                table: "Heroes",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Schools_SchoolId",
                table: "Heroes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Schools_SchoolId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_Powers_HeroId",
                table: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_SchoolId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Heroes");
        }
    }
}
