using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class IngresosContribuyente
    {
        public IngresosContribuyente()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdIngresoContribuyente { get; set; }
        public string IngresoContribuyente { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
