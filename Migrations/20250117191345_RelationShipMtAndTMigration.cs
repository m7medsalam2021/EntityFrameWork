using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipMtAndTMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchTeam",
                columns: table => new
                {
                    MatchTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTeam", x => x.MatchTeamId);
                });

            migrationBuilder.CreateTable(
                name: "MatchTeamTeam",
                columns: table => new
                {
                    MatchTeamsMatchTeamId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTeamTeam", x => new { x.MatchTeamsMatchTeamId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_MatchTeamTeam_MatchTeam_MatchTeamsMatchTeamId",
                        column: x => x.MatchTeamsMatchTeamId,
                        principalTable: "MatchTeam",
                        principalColumn: "MatchTeamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchTeamTeam_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeamTeam_TeamsId",
                table: "MatchTeamTeam",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchTeamTeam");

            migrationBuilder.DropTable(
                name: "MatchTeam");
        }
    }
}
