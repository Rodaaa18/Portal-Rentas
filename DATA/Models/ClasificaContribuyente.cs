using System.Collections.Generic;


namespace DATA.Models
{
    public class ClasificaContribuyente
    {
        
            public ClasificaContribuyente()
            {
                Contribuyentes = new HashSet<Contribuyentes>();
            }

            public int IdClasificaContribuyente { get; set; }
            public string Clasificacion { get; set; }
            public bool? PropioRentas { get; set; }

            public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
        
    }
}
