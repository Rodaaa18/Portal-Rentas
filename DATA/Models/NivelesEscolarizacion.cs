using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DATA.Models
{
    public partial class NivelesEscolarizacion
    {
        public NivelesEscolarizacion()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdNivelEscolarizacion { get; set; }
        public string NivelEscolarizacion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
