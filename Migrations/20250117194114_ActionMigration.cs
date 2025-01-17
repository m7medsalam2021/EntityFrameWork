using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class ActionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeAction = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchMatchTeam",
                columns: table => new
                {
                    MatcheTeamsMatchTeamId = table.Column<int>(type: "int", nullable: false),
                    MatchesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchMatchTeam", x => new { x.MatcheTeamsMatchTeamId, x.MatchesId });
                    table.ForeignKey(
                        name: "FK_MatchMatchTeam_MatchTeam_MatcheTeamsMatchTeamId",
                        column: x => x.MatcheTeamsMatchTeamId,
                        principalTable: "MatchTeam",
                        principalColumn: "MatchTeamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchMatchTeam_Matches_MatchesId",
                        column: x => x.MatchesId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerActions",
                columns: table => new
                {
                    PlayerActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerActions", x => x.PlayerActionId);
                    table.ForeignKey(
                        name: "FK_PlayerActions_Actions_ActionsId",
                        column: x => x.ActionsId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchMatchTeam_MatchesId",
                table: "MatchMatchTeam",
                column: "MatchesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerActions_ActionsId",
                table: "PlayerActions",
                column: "ActionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchMatchTeam");

            migrationBuilder.DropTable(
                name: "PlayerActions");

            migrationBuilder.DropTable(
                name: "Actions");

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
    }
}
