using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Capacity { get; set; }

        public ICollection<Team> Teams { get; set; }
        public StadiumProhibition StadiumProhibitions { get; set; }
        public virtual ICollection<Match> Matches { get; set; }

    }
}
