using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipMtAndMMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchTeamId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MatchId",
                table: "Matches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MatchTeamId",
                table: "Matches",
                column: "MatchTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_MatchTeam_MatchTeamId",
                table: "Matches",
                column: "MatchTeamId",
                principalTable: "MatchTeam",
                principalColumn: "MatchTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Matches_MatchId",
                table: "Matches",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_MatchTeam_MatchTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Matches_MatchId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_MatchId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_MatchTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "MatchTeamId",
                table: "Matches");
        }
    }
}
