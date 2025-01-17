using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Entities
{
    internal abstract class Person
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Column(TypeName = "char(1)")]
        public char Type { get; set; }
        public DateTime Birthday { get; set; }
    }
}
