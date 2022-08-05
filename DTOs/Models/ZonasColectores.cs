using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class ZonasColectores
    {
        public ZonasColectores()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdZonaColector { get; set; }
        public int IdColector { get; set; }
        public string Zona { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
