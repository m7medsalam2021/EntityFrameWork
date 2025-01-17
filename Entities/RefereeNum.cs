using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal class RefereeNum
    {
        public int RefereeNumId { get; set; }
        [StringLength(11, ErrorMessage = "Your Phone Number Should be 11 Number.")]
        [Column(TypeName = "varchar(11)")]
        public string? PhoneNumber { get; set; }
        public Referee Referees { get; set; }
    }
}
