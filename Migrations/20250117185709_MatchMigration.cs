using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class MatchMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchReferee",
                columns: table => new
                {
                    MatchesId = table.Column<int>(type: "int", nullable: false),
                    RefereesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchReferee", x => new { x.MatchesId, x.RefereesId });
                    table.ForeignKey(
                        name: "FK_MatchReferee_Matches_MatchesId",
                        column: x => x.MatchesId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchReferee_Referees_RefereesId",
                        column: x => x.RefereesId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchReferee_RefereesId",
                table: "MatchReferee",
                column: "RefereesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchReferee");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
