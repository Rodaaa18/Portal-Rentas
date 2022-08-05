using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class FuentesFinanciamiento
    {
        public FuentesFinanciamiento()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdFuenteFinanciamiento { get; set; }
        public string FuenteFinanciamiento { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
