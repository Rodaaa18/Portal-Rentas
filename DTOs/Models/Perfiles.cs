using System.Collections.Generic;

namespace DATA.Models
{
    public class Perfiles
    {
        public Perfiles()
        {
            UsuariosPerfiles = new HashSet<UsuariosPerfiles>();
        }

        public int IDperfil { get; set; }
        public string Nombre { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<UsuariosPerfiles> UsuariosPerfiles { get; set; }
    }
}
