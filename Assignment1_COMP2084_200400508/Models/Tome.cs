using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_COMP2084_200400508.Models
{
    public class Tome
    {
        private int _TomeId;
        [Key]
        public int TomeId
        {
            get
            {
                return _TomeId;
            }
            set
            {
                if (value <= 0) throw new InvalidOperationException();
                _TomeId = value;
            }
        }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == null) throw new InvalidOperationException();
                if (value.Length == 0) throw new InvalidOperationException();
                _Name = value;
            }
        }

        private int _Pages;
        public int Pages
        {
            get
            {
                return _Pages;
            }
            set
            {
                if (value <= 0) throw new InvalidOperationException();
                _Pages = value;
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (value == null) throw new InvalidOperationException();

                if (value.Length == 0) throw new InvalidOperationException();
                _Description = value;
            }
        }

        public Boolean IsRented { get; set; }

        public ICollection<Spell> Spells { get; set; }

    }
}
