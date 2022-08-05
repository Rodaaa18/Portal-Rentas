using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class EstadosContribuyentes
    {
        public EstadosContribuyentes()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstadoContribuyente { get; set; }
        public string Estado { get; set; }
        public bool AfectaCuentas { get; set; }
        public string Obs { get; set; }
        public bool? PropioRentas { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
