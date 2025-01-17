using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class PlayerPosition
    {
        public int PlayerPositionId {  get; set; }
        public string Position { get; set; }
        public Player Players { get; set; }

    }
}
