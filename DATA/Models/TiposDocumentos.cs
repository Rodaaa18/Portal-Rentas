using System.Collections.Generic;

namespace DATA.Models
{
    public class TiposDocumentos
    {
        public TiposDocumentos()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Obs { get; set; }
        public bool? ValidaCuit { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
