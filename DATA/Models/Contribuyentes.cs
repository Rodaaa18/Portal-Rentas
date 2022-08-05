using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATA.Models
{
    public class Contribuyentes
    {
        public int IdContribuyente { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("IdTipoDocumento")]
        public int? IdTipoDocumento { get; set; }
        public TiposDocumentos idTipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Email { get; set; }
        [ForeignKey("IdEstadoContribuyente")]
        public int? IdEstadoContribuyente { get; set; }
        public EstadosContribuyentes idEstadoContribuyente { get; set; }
        public string Obs { get; set; }
        [ForeignKey("IdTipoContribuyente")]
        public int? IdTipoContribuyente { get; set; }
        public TiposContribuyentes idTipoContribuyente { get; set; }
        
        [ForeignKey("IdClasificaContribuyente")]
        public int? IdClasificaContribuyente { get; set; }
        public ClasificaContribuyente idClasificaContribuyente { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [ForeignKey("IdClasifImpresion")]
        public int? IdClasifImpresion { get; set; }
        public ClasifImpresion idClasifImpresion { get; set; }
        public string Cbu { get; set; }
        public string Celular { get; set; }
        [ForeignKey("IdOcupacion")]
        public int? IdOcupacion { get; set; }
        public Ocupaciones idOcupacion { get; set; }
        [ForeignKey("IdFuncionOcupacion")]
        public int? IdFuncionOcupacion { get; set; }
        public FuncionesOcupacion idFuncionOcupacion { get; set; }
        [ForeignKey("IdTipoOcupacion")]
        public int? IdTipoOcupacion { get; set; }
        public TiposOcupacion idTipoOcupacion { get; set; }
        public int? SituacionLaboral { get; set; }
        public int? AportesJubilatorios { get; set; }
        [ForeignKey("IdTipoOcupacion")]
        public int? IdNivelEscolarizacion { get; set; }
        public NivelesEscolarizacion idNivelEscolarizacion { get; set; }
        public bool? ContinuaEducacion { get; set; }
        public int? TipoEstablecimiento { get; set; }
        public string OtraCapacitacion { get; set; }
        [ForeignKey("IdFuenteFinanciamiento")]
        public int? IdFuenteFinanciamiento { get; set; }
        public FuentesFinanciamiento idFuenteFinanciamiento { get; set; }
        [ForeignKey("IdIngresoContribuyente")]        
        public int? IdIngresoContribuyente { get; set; }
        public IngresosContribuyente idIngresoContribuyente { get; set; }
        [ForeignKey("IdCoberturaSocial")]
        public int? IdCoberturaSocial { get; set; }
        public CoberturasSociales idCoberturaSocial { get; set; }
        public string Enfermedades { get; set; }
        public string Discapacidades { get; set; }
        public string Medicamentos { get; set; }
        public string Tratamientos { get; set; }
        [ForeignKey("IdZonaColector")]
        public int? IdZonaColector { get; set; }
        public ZonasColectores idZonaColector { get; set; }
        public string Codcontri { get; set; }
    }
}
