using FootballLeague.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = FootballLeague.Entities.Action;

namespace FootballLeague.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.; Database=League; Integrated Security=True; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RelationShip Coach
            modelBuilder.Entity<Coach>()
                            .HasOne(CC => CC.CoachContracts)
                            .WithOne(C => C.Coach)
                            .HasForeignKey<CoachContract>(CC => CC.CoachContractId);
            modelBuilder.Entity<Coach>()
                            .HasOne(CN => CN.CoachNums)
                            .WithOne(c => c.Coach)
                            .HasForeignKey<CoachNum>(CC => CC.CoachNumId);
            #endregion
            #region RelationShip Player
            modelBuilder.Entity<Player>()
                            .HasOne(PC => PC.PlayerContracts)
                            .WithOne(P => P.Players)
                            .HasForeignKey<PlayerContract>(PC => PC.PlayerContractId);
            modelBuilder.Entity<Player>()
                            .HasOne(PN => PN.PlayerNums)
                            .WithOne(P => P.Players)
                            .HasForeignKey<PlayerNum>(PN => PN.PlayerNumId);
            modelBuilder.Entity<Player>()
                            .HasOne(PP => PP.PlayerPositions)
                            .WithOne(P => P.Players)
                            .HasForeignKey<PlayerPosition>(PP => PP.PlayerPositionId);
            modelBuilder.Entity<Player>()
                            .HasOne(TP => TP.TeamPlayers)
                            .WithOne(P => P.Players)
                            .HasForeignKey<TeamPlayer>(TP => TP.TeamId);
            #endregion
            #region RelationShip Referee
            modelBuilder.Entity<Referee>()
                            .HasOne(RC => RC.RefereeContracts)
                            .WithOne(R => R.Referees)
                            .HasForeignKey<RefereeContract>(RC => RC.RefereeContractId);
            modelBuilder.Entity<Referee>()
                            .HasOne(RN => RN.RefereeNums)
                            .WithOne(R => R.Referees)
                            .HasForeignKey<RefereeNum>(RN => RN.RefereeNumId);
            #endregion
            #region Relationship Stadium
            modelBuilder.Entity<Stadium>()
                            .HasOne(SP => SP.StadiumProhibitions)
                            .WithOne(T => T.Stadiums)
                            .HasForeignKey<StadiumProhibition>(SP => SP.StadiumId);
            
            #endregion
            #region RelationShip Team
            modelBuilder.Entity<Team>()
                            .HasOne(TP => TP.TeamPlayers)
                            .WithOne(T => T.Teams)
                            .HasForeignKey<TeamPlayer>(TP => TP.TeamId);
            modelBuilder.Entity<Team>()
                            .HasOne(CC => CC.CoachContracts)
                            .WithOne(T => T.Teams)
                            .HasForeignKey<CoachContract>(CC => CC.TeamId);
            #endregion
            #region RelationShip Match
            modelBuilder.Entity<Match>()
                            .HasOne(S => S.Stadiums)
                            .WithMany(M => M.Matches);
            #endregion
            #region Action
            //modelBuilder.Entity<Action>()
            //                .HasMany(PA => PA.PlayerActions)
            //                .WithOne(A => A.Actions)
            //                .HasForeignKey<PlayerAction>(PA => PA.PlayerActionId);
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<CoachContract> Coachcontracts { get; set; }
        public DbSet<CoachNum> CoachNums { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerContract> PlayerContracts { get; set; }
        public DbSet<PlayerNum> PlayerNums { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<RefereeContract> RefereeContracts { get; set; }
        public DbSet<RefereeNum> RefereeNums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<StadiumProhibition> StadiumProhibitions { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<PlayerAction> PlayerActions {  get; set; } 

    }
}
