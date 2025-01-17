using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class PlayerAction
    {
        [ForeignKey("PlayerActionId")]
        public int PlayerActionId { get; set; }
        public Action Actions { get; set; }
        [ForeignKey("MatchId")]
        public int MatchId { get; set; }
        public Match Matches { get; set; }
        [ForeignKey("PlayerId")]
        public int PlayerId { get; set; }
        public virtual Player Players { get; set; }

    }
}
