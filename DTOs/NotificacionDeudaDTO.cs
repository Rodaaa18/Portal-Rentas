using System;

namespace DATA
{
    public class NotificacionDeudaDTO
    {
        public int? IdNotificado { get; set; }
        public DateTime? FechaFotificacion { get; set; }
        public int? NroNotificacion { get; set; }
        public string? ApellidoNombre { get; set; }
        public int? IdCuenta { get; set; }
        public int? TyC { get; set; }
        public DateTime? FechaAlcance { get; set; }
        public string? Obs { get; set; }
        public bool? Entregado { get; set; }
    }
}
