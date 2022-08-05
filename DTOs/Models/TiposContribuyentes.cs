using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class TiposContribuyentes
    {
        public TiposContribuyentes()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoContribuyente { get; set; }
        public string TipoContribuyente { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
