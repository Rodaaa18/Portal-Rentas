using DATA.Models;
using ENTITIES.Configurations;
using Microsoft.EntityFrameworkCore;

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
        }        
    }
}
