using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Models
{
    public class ZonasColectores
    {
        public ZonasColectores()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdZonaColector { get; set; }
        public int IdColector { get; set; }
        public string Zona { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
