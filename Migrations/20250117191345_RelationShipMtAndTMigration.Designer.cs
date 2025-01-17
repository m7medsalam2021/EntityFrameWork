﻿// <auto-generated />
using System;
using FootballLeague.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootballLeague.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250117191345_RelationShipMtAndTMigration")]
    partial class RelationShipMtAndTMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FootballLeague.Entities.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("FootballLeague.Entities.CoachContract", b =>
                {
                    b.Property<int>("CoachContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("CoachContractId");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("Coachcontracts");
                });

            modelBuilder.Entity("FootballLeague.Entities.CoachNum", b =>
                {
                    b.Property<int>("CoachNumId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("CoachNumId");

                    b.ToTable("CoachNums");
                });

            modelBuilder.Entity("FootballLeague.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("FootballLeague.Entities.MatchTeam", b =>
                {
                    b.Property<int>("MatchTeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatchTeamId"));

                    b.Property<string>("MatchStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchTeamId");

                    b.ToTable("MatchTeam");
                });

            modelBuilder.Entity("FootballLeague.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamPlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerContract", b =>
                {
                    b.Property<int>("PlayerContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kit")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerContractId");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerContracts");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerNum", b =>
                {
                    b.Property<int>("PlayerNumId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("PlayerNumId");

                    b.ToTable("PlayerNums");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerPosition", b =>
                {
                    b.Property<int>("PlayerPositionId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerPositionId");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("FootballLeague.Entities.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("FootballLeague.Entities.RefereeContract", b =>
                {
                    b.Property<int>("RefereeContractId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RefereeContractId");

                    b.ToTable("RefereeContracts");
                });

            modelBuilder.Entity("FootballLeague.Entities.RefereeNum", b =>
                {
                    b.Property<int>("RefereeNumId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("RefereeNumId");

                    b.ToTable("RefereeNums");
                });

            modelBuilder.Entity("FootballLeague.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Capacity")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("FootballLeague.Entities.StadiumProhibition", b =>
                {
                    b.Property<int>("StadiumProhibitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StadiumProhibitionId"));

                    b.Property<string>("Prohibition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.HasKey("StadiumProhibitionId");

                    b.HasIndex("StadiumId")
                        .IsUnique();

                    b.ToTable("StadiumProhibitions");
                });

            modelBuilder.Entity("FootballLeague.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortHand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<int>("TeamPlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FootballLeague.Entities.TeamPlayer", b =>
                {
                    b.Property<int>("TeamPlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamPlayerId"));

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Rank_Cap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("TeamPlayerId");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("TeamPlayers");
                });

            modelBuilder.Entity("MatchReferee", b =>
                {
                    b.Property<int>("MatchesId")
                        .HasColumnType("int");

                    b.Property<int>("RefereesId")
                        .HasColumnType("int");

                    b.HasKey("MatchesId", "RefereesId");

                    b.HasIndex("RefereesId");

                    b.ToTable("MatchReferee");
                });

            modelBuilder.Entity("MatchTeamTeam", b =>
                {
                    b.Property<int>("MatchTeamsMatchTeamId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("MatchTeamsMatchTeamId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("MatchTeamTeam");
                });

            modelBuilder.Entity("FootballLeague.Entities.CoachContract", b =>
                {
                    b.HasOne("FootballLeague.Entities.Coach", "Coach")
                        .WithOne("CoachContracts")
                        .HasForeignKey("FootballLeague.Entities.CoachContract", "CoachContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballLeague.Entities.Team", "Teams")
                        .WithOne("CoachContracts")
                        .HasForeignKey("FootballLeague.Entities.CoachContract", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballLeague.Entities.CoachNum", b =>
                {
                    b.HasOne("FootballLeague.Entities.Coach", "Coach")
                        .WithOne("CoachNums")
                        .HasForeignKey("FootballLeague.Entities.CoachNum", "CoachNumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("FootballLeague.Entities.Match", b =>
                {
                    b.HasOne("FootballLeague.Entities.Stadium", "Stadiums")
                        .WithMany("Matches")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerContract", b =>
                {
                    b.HasOne("FootballLeague.Entities.Player", "Players")
                        .WithOne("PlayerContracts")
                        .HasForeignKey("FootballLeague.Entities.PlayerContract", "PlayerContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballLeague.Entities.Team", "Teams")
                        .WithMany("playerContracts")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Players");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerNum", b =>
                {
                    b.HasOne("FootballLeague.Entities.Player", "Players")
                        .WithOne("PlayerNums")
                        .HasForeignKey("FootballLeague.Entities.PlayerNum", "PlayerNumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Players");
                });

            modelBuilder.Entity("FootballLeague.Entities.PlayerPosition", b =>
                {
                    b.HasOne("FootballLeague.Entities.Player", "Players")
                        .WithOne("PlayerPositions")
                        .HasForeignKey("FootballLeague.Entities.PlayerPosition", "PlayerPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Players");
                });

            modelBuilder.Entity("FootballLeague.Entities.RefereeContract", b =>
                {
                    b.HasOne("FootballLeague.Entities.Referee", "Referees")
                        .WithOne("RefereeContracts")
                        .HasForeignKey("FootballLeague.Entities.RefereeContract", "RefereeContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Referees");
                });

            modelBuilder.Entity("FootballLeague.Entities.RefereeNum", b =>
                {
                    b.HasOne("FootballLeague.Entities.Referee", "Referees")
                        .WithOne("RefereeNums")
                        .HasForeignKey("FootballLeague.Entities.RefereeNum", "RefereeNumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Referees");
                });

            modelBuilder.Entity("FootballLeague.Entities.StadiumProhibition", b =>
                {
                    b.HasOne("FootballLeague.Entities.Stadium", "Stadiums")
                        .WithOne("StadiumProhibitions")
                        .HasForeignKey("FootballLeague.Entities.StadiumProhibition", "StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("FootballLeague.Entities.Team", b =>
                {
                    b.HasOne("FootballLeague.Entities.Stadium", "Stadiums")
                        .WithMany("Teams")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("FootballLeague.Entities.TeamPlayer", b =>
                {
                    b.HasOne("FootballLeague.Entities.Player", "Players")
                        .WithOne("TeamPlayers")
                        .HasForeignKey("FootballLeague.Entities.TeamPlayer", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballLeague.Entities.Team", "Teams")
                        .WithOne("TeamPlayers")
                        .HasForeignKey("FootballLeague.Entities.TeamPlayer", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Players");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("MatchReferee", b =>
                {
                    b.HasOne("FootballLeague.Entities.Match", null)
                        .WithMany()
                        .HasForeignKey("MatchesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballLeague.Entities.Referee", null)
                        .WithMany()
                        .HasForeignKey("RefereesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MatchTeamTeam", b =>
                {
                    b.HasOne("FootballLeague.Entities.MatchTeam", null)
                        .WithMany()
                        .HasForeignKey("MatchTeamsMatchTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FootballLeague.Entities.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FootballLeague.Entities.Coach", b =>
                {
                    b.Navigation("CoachContracts")
                        .IsRequired();

                    b.Navigation("CoachNums")
                        .IsRequired();
                });

            modelBuilder.Entity("FootballLeague.Entities.Player", b =>
                {
                    b.Navigation("PlayerContracts")
                        .IsRequired();

                    b.Navigation("PlayerNums")
                        .IsRequired();

                    b.Navigation("PlayerPositions")
                        .IsRequired();

                    b.Navigation("TeamPlayers")
                        .IsRequired();
                });

            modelBuilder.Entity("FootballLeague.Entities.Referee", b =>
                {
                    b.Navigation("RefereeContracts")
                        .IsRequired();

                    b.Navigation("RefereeNums")
                        .IsRequired();
                });

            modelBuilder.Entity("FootballLeague.Entities.Stadium", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("StadiumProhibitions")
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballLeague.Entities.Team", b =>
                {
                    b.Navigation("CoachContracts")
                        .IsRequired();

                    b.Navigation("TeamPlayers")
                        .IsRequired();

                    b.Navigation("playerContracts");
                });
#pragma warning restore 612, 618
        }
    }
}
