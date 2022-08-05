using System.Collections.Generic;

namespace DATA.Models
{
    public class TiposOcupacion
    {
        public TiposOcupacion()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdTipoOcupacion { get; set; }
        public string TipoOcupacion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
