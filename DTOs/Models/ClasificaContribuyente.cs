using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class ClasificaContribuyente
    {
        
            public ClasificaContribuyente()
            {
                Contribuyentes = new HashSet<Contribuyentes>();
            }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClasificaContribuyente { get; set; }
            public string Clasificacion { get; set; }
            public bool? PropioRentas { get; set; }

            public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
        
    }
}
