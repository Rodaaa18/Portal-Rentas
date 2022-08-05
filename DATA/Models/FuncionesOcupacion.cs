using System.Collections.Generic;


namespace DATA.Models
{
    public class FuncionesOcupacion
    {
        public FuncionesOcupacion()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }

        public int IdFuncionOcupacion { get; set; }
        public string FuncionOcupacion { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
