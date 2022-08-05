using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class EstadosContribuyentes
    {
        public EstadosContribuyentes()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdEstadoContribuyente { get; set; }
        public string Estado { get; set; }
        public bool AfectaCuentas { get; set; }
        public string Obs { get; set; }
        public bool? PropioRentas { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
