using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipTAndCMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Coachcontracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coachcontracts_TeamId",
                table: "Coachcontracts",
                column: "TeamId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coachcontracts_Teams_TeamId",
                table: "Coachcontracts",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coachcontracts_Teams_TeamId",
                table: "Coachcontracts");

            migrationBuilder.DropIndex(
                name: "IX_Coachcontracts_TeamId",
                table: "Coachcontracts");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Coachcontracts");
        }
    }
}
