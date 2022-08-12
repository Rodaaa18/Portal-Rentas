using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace DATA.SP_Models
{
    public partial class sp_NotificadosDevuelveDatosConsultaNotificados 
    {
        public int IdNotificado { get; set; }
        public DateTime? FechaFotificacion { get; set; }
        public string? ApellidoNombre { get; set; }
        public int IdCuenta { get; set; }
        public int TyC { get; set; }
        public int ImporteNeto { get; set; }
        public int ImporteTotal { get; set; }
        [Column("Interes", TypeName = "money")]
        public decimal Interes { get; set; }      
        public DateTime? FechaAlcance { get; set; }
        public string? Obs { get; set; }
        public int? NroNotificacion { get; set; }
        public bool? Entregado { get; set; }
        public Nullable<int> start { get; set; }
        public Nullable<int> pageSize { get; set; }
    }
}
