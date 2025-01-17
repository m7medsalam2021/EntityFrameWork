using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class PlayerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "char(1)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerContracts",
                columns: table => new
                {
                    PlayerContractId = table.Column<int>(type: "int", nullable: false),
                    Kit = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerContracts", x => x.PlayerContractId);
                    table.ForeignKey(
                        name: "FK_PlayerContracts_Players_PlayerContractId",
                        column: x => x.PlayerContractId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerNums",
                columns: table => new
                {
                    PlayerNumId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerNums", x => x.PlayerNumId);
                    table.ForeignKey(
                        name: "FK_PlayerNums_Players_PlayerNumId",
                        column: x => x.PlayerNumId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPositions",
                columns: table => new
                {
                    PlayerPositionId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPositions", x => x.PlayerPositionId);
                    table.ForeignKey(
                        name: "FK_PlayerPositions_Players_PlayerPositionId",
                        column: x => x.PlayerPositionId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerContracts");

            migrationBuilder.DropTable(
                name: "PlayerNums");

            migrationBuilder.DropTable(
                name: "PlayerPositions");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
