using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class Action
    {
        public int Id { get; set; }
        public DateTime TimeAction { get; set; }

        public virtual ICollection<PlayerAction> PlayerActions { get; set; } 
    }
}
