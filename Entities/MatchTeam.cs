using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class MatchTeam
    {
        public int MatchTeamId { get; set; }
        public string MatchStatus { get; set; }

        public virtual ICollection<Team> Teams { get; set; } = new HashSet<Team>();
        public virtual ICollection<Match> Matches { get; set; } = new HashSet<Match>();
    }
}
