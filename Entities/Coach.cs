using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    /// POCO CLASS
    /// PLAN OLD CLR OBJECT
    internal class Coach : Person
    {
        public int Id { get; set; }

        public virtual CoachContract CoachContracts { get; set; }
        public virtual CoachNum CoachNums { get; set; }
    }
}
