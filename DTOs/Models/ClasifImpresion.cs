using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class ClasifImpresion
    {
        public ClasifImpresion()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClasifImpresion { get; set; }
        public string Descripcion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
