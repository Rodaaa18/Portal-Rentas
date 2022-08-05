using System.Collections.Generic;


namespace DATA.Models
{
    public class CoberturasSociales
    {
        public CoberturasSociales()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdCoberturaSocial { get; set; }
        public string CoberturaSocial { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
