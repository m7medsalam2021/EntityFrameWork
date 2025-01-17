using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class TeamPlayer
    {
        public int TeamPlayerId { get; set; }
        public string Rank_Cap { get; set; }

        public int TeamId { get; set; }
        public Team Teams { get; set; }
        public int PlayerId { get; set; }
        public Player Players { get; set; }
    }
}
