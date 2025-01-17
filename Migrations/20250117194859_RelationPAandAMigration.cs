using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RelationPAandAMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerActions_PlayerId",
                table: "PlayerActions",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerActions_Players_PlayerId",
                table: "PlayerActions",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerActions_Players_PlayerId",
                table: "PlayerActions");

            migrationBuilder.DropIndex(
                name: "IX_PlayerActions_PlayerId",
                table: "PlayerActions");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerActions");
        }
    }
}
