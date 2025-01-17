using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class StadiumProhibition
    {
        public int StadiumProhibitionId { get; set; }
        public string Prohibition {  get; set; }

        public int StadiumId { get; set; }
        public Stadium Stadiums { get; set; }
    }
}
