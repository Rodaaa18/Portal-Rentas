using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class TiposDocumentos
    {
        public TiposDocumentos()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Obs { get; set; }
        public bool? ValidaCuit { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
