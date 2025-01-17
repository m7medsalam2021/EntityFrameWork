using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class RefereeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referees",
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
                    table.PrimaryKey("PK_Referees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeContracts",
                columns: table => new
                {
                    RefereeContractId = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeContracts", x => x.RefereeContractId);
                    table.ForeignKey(
                        name: "FK_RefereeContracts_Referees_RefereeContractId",
                        column: x => x.RefereeContractId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefereeNums",
                columns: table => new
                {
                    RefereeNumId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeNums", x => x.RefereeNumId);
                    table.ForeignKey(
                        name: "FK_RefereeNums_Referees_RefereeNumId",
                        column: x => x.RefereeNumId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefereeContracts");

            migrationBuilder.DropTable(
                name: "RefereeNums");

            migrationBuilder.DropTable(
                name: "Referees");
        }
    }
}
