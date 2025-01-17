using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string ShortHand { get; set; }
        public ICollection<PlayerContract> playerContracts { get; set; }
        public int StadiumId { get; set; }
        public Stadium Stadiums { get; set; }
        public int TeamPlayerId { get; set; }
        public TeamPlayer TeamPlayers { get; set; }
        public CoachContract CoachContracts { get; set; }
        public virtual ICollection<MatchTeam> MatchTeams { get; set; } = new HashSet<MatchTeam>();
    }
}
