using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class Usuarios
    {
        public Usuarios()
        {
            UsuariosPerfiles = new HashSet<UsuariosPerfiles>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDusuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string NombreUsuario { get; set; }
        public string Obs { get; set; }
        public bool? Ok { get; set; }
        public int? CantCaracteres { get; set; }
        public int? FormatoClave { get; set; }
        public bool? Baja { get; set; }
        public string RutaFirma { get; set; }
        public virtual ICollection<UsuariosPerfiles> UsuariosPerfiles { get; set; }   
    }
}
