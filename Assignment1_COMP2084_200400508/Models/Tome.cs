using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_COMP2084_200400508.Models
{
    public class Tome
    {
        [Key]
        public int TomeId { get; set; }

        public string Name { get; set; }
        
        public int Pages { get; set; }

        public string Description { get; set; }

        public Boolean IsRented { get; set; }

        public ICollection<Spell> Spells { get; set; }

    }
}
