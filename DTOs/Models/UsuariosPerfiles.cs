namespace DATA.Models
{
    public class UsuariosPerfiles
    {
        public int IDusuarioPerfil { get; set; }
        public int? IDusuario { get; set; }
        public int? IDperfil { get; set; }

        public virtual Perfiles Idperfil { get; set; }
        public virtual Usuarios Idusuario { get; set; }
    }
}
