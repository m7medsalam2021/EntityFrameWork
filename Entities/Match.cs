using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Referee> Referees { get; set; } = new HashSet<Referee>();
        public int StadiumId { get; set; }
        public Stadium Stadiums { get; set; }
        public virtual ICollection<MatchTeam> MatcheTeams { get; set; } = new HashSet<MatchTeam>();
        public virtual ICollection<PlayerAction> PlayerActions { get; set; } = new HashSet<PlayerAction>();
    }
}
