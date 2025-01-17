using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Player : Person
    {
        public int Id { get; set; }

        public virtual PlayerContract PlayerContracts { get; set; }
        public virtual PlayerNum PlayerNums { get; set; }
        public virtual PlayerPosition PlayerPositions { get; set; }
        public int TeamPlayerId { get; set; }
        public TeamPlayer TeamPlayers { get; set; }

        public virtual ICollection<PlayerAction> PlayerActions { get; set; }
    }
}
