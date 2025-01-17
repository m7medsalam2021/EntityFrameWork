using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RelationPAandMMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "PlayerActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerActions_MatchId",
                table: "PlayerActions",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerActions_Matches_MatchId",
                table: "PlayerActions",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerActions_Matches_MatchId",
                table: "PlayerActions");

            migrationBuilder.DropIndex(
                name: "IX_PlayerActions_MatchId",
                table: "PlayerActions");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "PlayerActions");
        }
    }
}
