// <auto-generated />
using System;
using ENTITIES;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ENTITIES.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220805152344_StoredProcedures")]
    partial class StoredProcedures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATA.Models.ClasifImpresion", b =>
                {
                    b.Property<int>("IdClasifImpresion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdClasifImpresion");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasName("det_DescripcionUnica")
                        .HasFilter("[Descripcion] IS NOT NULL");

                    b.ToTable("ClasifImpresion");
                });

            modelBuilder.Entity("DATA.Models.ClasificaContribuyente", b =>
                {
                    b.Property<int>("IdClasificaContribuyente")
                        .HasColumnType("int");

                    b.Property<string>("Clasificacion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("PropioRentas")
                        .HasColumnType("bit");

                    b.HasKey("IdClasificaContribuyente");

                    b.HasIndex("Clasificacion")
                        .IsUnique()
                        .HasName("det_ClasificacionUnico")
                        .HasFilter("[Clasificacion] IS NOT NULL");

                    b.HasIndex("PropioRentas");

                    b.ToTable("ClasificaContribuyente");
                });

            modelBuilder.Entity("DATA.Models.CoberturasSociales", b =>
                {
                    b.Property<int>("IdCoberturaSocial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoberturaSocial")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdCoberturaSocial")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("CoberturasSociales");
                });

            modelBuilder.Entity("DATA.Models.Contribuyentes", b =>
                {
                    b.Property<int>("IdContribuyente")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int?>("AportesJubilatorios")
                        .HasColumnType("int");

                    b.Property<string>("Cbu")
                        .HasColumnName("CBU")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Celular")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Codcontri")
                        .HasColumnName("codcontri")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("ContinuaEducacion")
                        .HasColumnType("bit");

                    b.Property<string>("Discapacidades")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Enfermedades")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdClasifImpresion")
                        .HasColumnType("int");

                    b.Property<int?>("IdClasificaContribuyente")
                        .HasColumnType("int");

                    b.Property<int?>("IdCoberturaSocial")
                        .HasColumnType("int");

                    b.Property<int?>("IdEstadoContribuyente")
                        .HasColumnName("idEstadoContribuyente")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("IdFuenteFinanciamiento")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionOcupacion")
                        .HasColumnType("int");

                    b.Property<int?>("IdIngresoContribuyente")
                        .HasColumnType("int");

                    b.Property<int?>("IdNivelEscolarizacion")
                        .HasColumnType("int");

                    b.Property<int?>("IdOcupacion")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoContribuyente")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoDocumento")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("IdTipoOcupacion")
                        .HasColumnType("int");

                    b.Property<int?>("IdZonaColector")
                        .HasColumnType("int");

                    b.Property<string>("Medicamentos")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("NroDocumento")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnName("obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("OtraCapacitacion")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("SituacionLaboral")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("TipoEstablecimiento")
                        .HasColumnType("int");

                    b.Property<string>("Tratamientos")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdContribuyente");

                    b.HasIndex("IdClasifImpresion");

                    b.HasIndex("IdClasificaContribuyente");

                    b.HasIndex("IdCoberturaSocial");

                    b.HasIndex("IdContribuyente")
                        .HasName("IdContribuyente");

                    b.HasIndex("IdEstadoContribuyente")
                        .HasName("IX_Contribuyentes_IdEstadoContribuyente");

                    b.HasIndex("IdFuenteFinanciamiento");

                    b.HasIndex("IdFuncionOcupacion");

                    b.HasIndex("IdIngresoContribuyente");

                    b.HasIndex("IdNivelEscolarizacion");

                    b.HasIndex("IdOcupacion");

                    b.HasIndex("IdTipoContribuyente");

                    b.HasIndex("IdTipoDocumento")
                        .HasName("ContribuyentesIdTipoDocumento");

                    b.HasIndex("IdTipoOcupacion");

                    b.HasIndex("IdZonaColector");

                    b.HasIndex("IdContribuyente", "IdEstadoContribuyente")
                        .HasName("IX_Contribuyentes_IdContribuyenteIdEstadoContribuyente");

                    b.HasIndex("IdContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente")
                        .HasName("IX_Contribuyentes_IdContribIdTipoIdClasifica");

                    b.HasIndex("IdContribuyente", "IdEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente")
                        .HasName("IX_Contribuyentes_IdContribuyenteIdEstadoIdTipoIdClasifica");

                    b.HasIndex("IdContribuyente", "Apellido", "Nombre", "IdEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente")
                        .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente");

                    b.HasIndex("IdContribuyente", "Apellido", "Nombre", "IdTipoDocumento", "IdEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente")
                        .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente");

                    b.HasIndex("IdContribuyente", "Apellido", "Nombre", "IdTipoDocumento", "NroDocumento", "IdEstadoContribuyente", "IdClasificaContribuyente")
                        .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoNroDocumentoIdEstadoContribuyenteIdClasificaContribuyente");

                    b.ToTable("Contribuyentes");
                });

            modelBuilder.Entity("DATA.Models.EstadosContribuyentes", b =>
                {
                    b.Property<int>("IdEstadoContribuyente")
                        .HasColumnType("int");

                    b.Property<bool>("AfectaCuentas")
                        .HasColumnType("bit");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool?>("PropioRentas")
                        .HasColumnType("bit");

                    b.HasKey("IdEstadoContribuyente");

                    b.HasIndex("Estado")
                        .IsUnique()
                        .HasName("det_EstadoContribuyenteUnico")
                        .HasFilter("[Estado] IS NOT NULL");

                    b.ToTable("EstadosContribuyentes");
                });

            modelBuilder.Entity("DATA.Models.FuentesFinanciamiento", b =>
                {
                    b.Property<int>("IdFuenteFinanciamiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuenteFinanciamiento")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdFuenteFinanciamiento")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("FuentesFinanciamiento");
                });

            modelBuilder.Entity("DATA.Models.FuncionesOcupacion", b =>
                {
                    b.Property<int>("IdFuncionOcupacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuncionOcupacion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdFuncionOcupacion")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("FuncionesOcupacions");
                });

            modelBuilder.Entity("DATA.Models.IngresosContribuyente", b =>
                {
                    b.Property<int>("IdIngresoContribuyente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IngresoContribuyente")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdIngresoContribuyente")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("IngresosContribuyente");
                });

            modelBuilder.Entity("DATA.Models.NivelesEscolarizacion", b =>
                {
                    b.Property<int>("IdNivelEscolarizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NivelEscolarizacion")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("IdNivelEscolarizacion")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("NivelesEscolarizacions");
                });

            modelBuilder.Entity("DATA.Models.Ocupaciones", b =>
                {
                    b.Property<int>("IdOcupacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Ocupacion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdOcupacion")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Ocupaciones");
                });

            modelBuilder.Entity("DATA.Models.TiposContribuyentes", b =>
                {
                    b.Property<int>("IdTipoContribuyente")
                        .HasColumnType("int");

                    b.Property<string>("TipoContribuyente")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdTipoContribuyente");

                    b.HasIndex("TipoContribuyente")
                        .IsUnique()
                        .HasName("det_TipoContribuyenteUnico")
                        .HasFilter("[TipoContribuyente] IS NOT NULL");

                    b.ToTable("TiposContribuyentes");
                });

            modelBuilder.Entity("DATA.Models.TiposDocumentos", b =>
                {
                    b.Property<int>("IdTipoDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool?>("ValidaCuit")
                        .HasColumnName("ValidaCUIT")
                        .HasColumnType("bit");

                    b.HasKey("IdTipoDocumento")
                        .HasName("aaaaaTiposDocumentos_PK")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("IdTipoDocumento")
                        .HasName("IdCalle");

                    b.HasIndex("TipoDocumento")
                        .HasName("TiposDocumentosTipoDocumento");

                    b.HasIndex("IdTipoDocumento", "TipoDocumento")
                        .HasName("IX_TiposDocumentos_IdTipoDocumentoTipoDocumento");

                    b.ToTable("TiposDocumentos");
                });

            modelBuilder.Entity("DATA.Models.TiposOcupacion", b =>
                {
                    b.Property<int>("IdTipoOcupacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("TipoOcupacion")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdTipoOcupacion")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("TiposOcupacion");
                });

            modelBuilder.Entity("DATA.Models.ZonasColectores", b =>
                {
                    b.Property<int>("IdZonaColector")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdColector")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Zona")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("IdZonaColector");

                    b.HasIndex("Zona")
                        .IsUnique()
                        .HasName("det_zonaColectorUnico")
                        .HasFilter("[Zona] IS NOT NULL");

                    b.ToTable("ZonasColectores");
                });

            modelBuilder.Entity("DATA.Models.Contribuyentes", b =>
                {
                    b.HasOne("DATA.Models.ClasifImpresion", "idClasifImpresion")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdClasifImpresion")
                        .HasConstraintName("FK_Contribuyentes_ClasifImpresion");

                    b.HasOne("DATA.Models.ClasificaContribuyente", "idClasificaContribuyente")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdClasificaContribuyente")
                        .HasConstraintName("FK_Contribuyentes_ClasificaContribuyente");

                    b.HasOne("DATA.Models.CoberturasSociales", "idCoberturaSocial")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdCoberturaSocial")
                        .HasConstraintName("FK_Contribuyentes_CoberturasSociales");

                    b.HasOne("DATA.Models.EstadosContribuyentes", "idEstadoContribuyente")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdEstadoContribuyente")
                        .HasConstraintName("FK_Contribuyentes_EstadosContribuyentes");

                    b.HasOne("DATA.Models.FuentesFinanciamiento", "idFuenteFinanciamiento")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdFuenteFinanciamiento")
                        .HasConstraintName("FK_Contribuyentes_FuentesFinanciamiento");

                    b.HasOne("DATA.Models.FuncionesOcupacion", "idFuncionOcupacion")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdFuncionOcupacion")
                        .HasConstraintName("FK_Contribuyentes_FuncionesOcupacion");

                    b.HasOne("DATA.Models.IngresosContribuyente", "idIngresoContribuyente")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdIngresoContribuyente")
                        .HasConstraintName("FK_Contribuyentes_IngresosContribuyente");

                    b.HasOne("DATA.Models.NivelesEscolarizacion", "idNivelEscolarizacion")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdNivelEscolarizacion")
                        .HasConstraintName("FK_Contribuyentes_NivelesEscolarizacion");

                    b.HasOne("DATA.Models.Ocupaciones", "idOcupacion")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdOcupacion")
                        .HasConstraintName("FK_Contribuyentes_Ocupaciones");

                    b.HasOne("DATA.Models.TiposContribuyentes", "idTipoContribuyente")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdTipoContribuyente")
                        .HasConstraintName("FK_Contribuyentes_TiposContribuyentes");

                    b.HasOne("DATA.Models.TiposDocumentos", "idTipoDocumento")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdTipoDocumento")
                        .HasConstraintName("FK_Contribuyentes_TiposDocumentos");

                    b.HasOne("DATA.Models.TiposOcupacion", "idTipoOcupacion")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdTipoOcupacion")
                        .HasConstraintName("FK_Contribuyentes_TiposOcupacion");

                    b.HasOne("DATA.Models.ZonasColectores", "idZonaColector")
                        .WithMany("Contribuyentes")
                        .HasForeignKey("IdZonaColector")
                        .HasConstraintName("FK_Contribuyentes_ZonasColectores");
                });
#pragma warning restore 612, 618
        }
    }
}
