using DATA.Models;
using DATA.SP_Models;
using ENTITIES.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace ENTITIES
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        #region DbSets
        public virtual DbSet<ClasificaContribuyente> ClasificaContribuyente { get; set; }
        public virtual DbSet<ClasifImpresion> ClasifImpresion { get; set; }
        public virtual DbSet<CoberturasSociales> CoberturasSociales { get; set; }
        public virtual DbSet<Contribuyentes> Contribuyentes { get; set; }
        public virtual DbSet<EstadosContribuyentes> EstadosContribuyentes { get; set; }
        public virtual DbSet<FuentesFinanciamiento> FuentesFinanciamiento { get; set; }
        public virtual DbSet<FuncionesOcupacion> FuncionesOcupacions { get; set; }
        public virtual DbSet<IngresosContribuyente> IngresosContribuyente { get; set; }
        public virtual DbSet<NivelesEscolarizacion> NivelesEscolarizacions { get; set; }
        public virtual DbSet<Ocupaciones> Ocupaciones { get; set; }
        public virtual DbSet<TiposContribuyentes> TiposContribuyentes { get; set; }
        public virtual DbSet<TiposDocumentos> TiposDocumentos { get; set; }
        public virtual DbSet<TiposOcupacion> TiposOcupacion { get; set; }
        public virtual DbSet<ZonasColectores> ZonasColectores { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<UsuariosPerfiles> UsuariosPerfiles { get; set; }
        public virtual ObjectResult<sp_NotificadosDevuelveDatosConsultaNotificados> Sp_NotificadosDevuelveDatosConsultaNotificados { get; set; }
        //public virtual ObjectResult<sp_NETCtaCteDevuelveDetalles_Result> sp_NETCtaCteDevuelveDetalles(Nullable<long> idCuenta, Nullable<int> idTyC, Nullable<System.DateTime> fechaAlcance)
        //{
        //    var idCuentaParameter = idCuenta.HasValue ?
        //        new ObjectParameter("IdCuenta", idCuenta) :
        //        new ObjectParameter("IdCuenta", typeof(long));

        //    var idTyCParameter = idTyC.HasValue ?
        //        new ObjectParameter("IdTyC", idTyC) :
        //        new ObjectParameter("IdTyC", typeof(int));

        //    var fechaAlcanceParameter = fechaAlcance.HasValue ?
        //        new ObjectParameter("FechaAlcance", fechaAlcance) :
        //        new ObjectParameter("FechaAlcance", typeof(System.DateTime));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NETCtaCteDevuelveDetalles_Result>("sp_NETCtaCteDevuelveDetalles", idCuentaParameter, idTyCParameter, fechaAlcanceParameter);
        //}
        public virtual ObjectResult<sp_NotificadosDevuelveDatosConsultaNotificados> sp_NotificadosDevuelveDatosConsultaNotificados(Nullable<int> start , Nullable<int> pageSize)
        {
            var startsParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("pageSize", pageSize) :
                new ObjectParameter("pageSize", typeof(int));
            
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NotificadosDevuelveDatosConsultaNotificados>("sp_NotificadosDevuelveDatosConsultaNotificadosPaginado", startsParameter , pageSizeParameter);
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelConfig(modelBuilder);
        }
        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ClasificaContribuyenteConfiguration(modelBuilder.Entity<ClasificaContribuyente>());
            new ClasifImpresionConfiguration(modelBuilder.Entity<ClasifImpresion>());
            new CoberturasSocialesConfiguration(modelBuilder.Entity<CoberturasSociales>());
            new ContribuyentesConfiguration(modelBuilder.Entity<Contribuyentes>());
            new EstadosContribuyentesConfiguration(modelBuilder.Entity<EstadosContribuyentes>());
            new FuentesFinanciamientoConfiguration(modelBuilder.Entity<FuentesFinanciamiento>());
            new FuncionesOcupacionConfiguration(modelBuilder.Entity<FuncionesOcupacion>());
            new IngresosContribuyenteConfiguration(modelBuilder.Entity<IngresosContribuyente>());
            new NivelesEscolarizacionConfiguration(modelBuilder.Entity<NivelesEscolarizacion>());
            new OcupacionesConfiguration(modelBuilder.Entity<Ocupaciones>());
            new TiposContribuyentesConfiguration(modelBuilder.Entity<TiposContribuyentes>());
            new TiposDocumentosConfiguration(modelBuilder.Entity<TiposDocumentos>());
            new TiposOcupacionConfiguration(modelBuilder.Entity<TiposOcupacion>());
            new ZonasColectoresConfiguration(modelBuilder.Entity<ZonasColectores>());
            new PerfilesConfiguration(modelBuilder.Entity<Perfiles>());
            new UsuariosConfiguration(modelBuilder.Entity<Usuarios>());
            new UsuariosPerfilesConfiguration(modelBuilder.Entity<UsuariosPerfiles>());
           
        }        
    }
}
