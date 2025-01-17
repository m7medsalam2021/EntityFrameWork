using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class PlayerContract
    {
        public int PlayerContractId { get; set; }
        public int Kit {  get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Player Players { get; set; }
        public int TeamId { get; set; }
        public Team Teams { get; set; }
    }
}
