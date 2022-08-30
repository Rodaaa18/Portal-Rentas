using System.ComponentModel.DataAnnotations;

namespace RentasAPI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "" +
            "El usuario es obligatorio")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "" +
            "La Clave es obligatioria")]
        public string Clave { get; set; }
    }
}
