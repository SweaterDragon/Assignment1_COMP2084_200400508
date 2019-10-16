using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_COMP2084_200400508.Models
{
    public class Spell
    {
        [Key]
        public int SpellId { get; set; }

        [ForeignKey("Tome")]
        public int TomeId { get; set; }

        public string Name { get; set; }
        // Art refers to what school of magic, such as necromancy, pyromancy, or restoration
        public string Art { get; set; }

        public int Difficulty { get; set; }
    }
}
