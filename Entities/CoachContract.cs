using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class CoachContract 
    {
        public int CoachContractId { get; set; }
        public decimal Salary {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Coach Coach { get; set; }
        public int TeamId { get; set; }
        public Team Teams { get; set; }


    }
}
