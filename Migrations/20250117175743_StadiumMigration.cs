using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class StadiumMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StadiumId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StadiumProhibitions",
                columns: table => new
                {
                    StadiumProhibitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prohibition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StadiumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StadiumProhibitions", x => x.StadiumProhibitionId);
                    table.ForeignKey(
                        name: "FK_StadiumProhibitions_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadiumId",
                table: "Teams",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_StadiumProhibitions_StadiumId",
                table: "StadiumProhibitions",
                column: "StadiumId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Stadiums_StadiumId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "StadiumProhibitions");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Teams_StadiumId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "StadiumId",
                table: "Teams");
        }
    }
}
