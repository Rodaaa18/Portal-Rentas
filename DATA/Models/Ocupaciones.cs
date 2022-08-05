using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class Ocupaciones
    {
        public Ocupaciones()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdOcupacion { get; set; }
        public string Ocupacion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
