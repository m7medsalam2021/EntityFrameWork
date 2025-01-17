using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Referee : Person
    {
        public int Id { get; set; }
        public RefereeContract RefereeContracts { get; set; }
        public RefereeNum RefereeNums { get; set; }

        public ICollection<Match> Matches { get; set; } = new HashSet<Match>(); 
    }
}
