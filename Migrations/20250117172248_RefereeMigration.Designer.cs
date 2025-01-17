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
    [Migration("20250117172248_RefereeMigration")]
    partial class RefereeMigration
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

                    b.HasKey("CoachContractId");

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

                    b.HasKey("PlayerContractId");

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

            modelBuilder.Entity("FootballLeague.Entities.CoachContract", b =>
                {
                    b.HasOne("FootballLeague.Entities.Coach", "Coach")
                        .WithOne("CoachContracts")
                        .HasForeignKey("FootballLeague.Entities.CoachContract", "CoachContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
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

            modelBuilder.Entity("FootballLeague.Entities.PlayerContract", b =>
                {
                    b.HasOne("FootballLeague.Entities.Player", "Players")
                        .WithOne("PlayerContracts")
                        .HasForeignKey("FootballLeague.Entities.PlayerContract", "PlayerContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Players");
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
                });

            modelBuilder.Entity("FootballLeague.Entities.Referee", b =>
                {
                    b.Navigation("RefereeContracts")
                        .IsRequired();

                    b.Navigation("RefereeNums")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
