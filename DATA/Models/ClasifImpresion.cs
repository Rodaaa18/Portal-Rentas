using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class ClasifImpresion
    {
        public ClasifImpresion()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdClasifImpresion { get; set; }
        public string Descripcion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
