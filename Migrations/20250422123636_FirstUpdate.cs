using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNHA.Migrations
{
    /// <inheritdoc />
    public partial class FirstUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rank",
                table: "Heroes",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Heroes");
        }
    }
}
