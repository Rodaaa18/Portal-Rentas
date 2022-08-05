using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class TiposContribuyentes
    {
        public TiposContribuyentes()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdTipoContribuyente { get; set; }
        public string TipoContribuyente { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
