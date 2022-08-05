using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class ContribuyentesConfiguration
    {
        public ContribuyentesConfiguration(EntityTypeBuilder<Contribuyentes> entity)
        {
            entity.HasKey(e => e.IdContribuyente);

            entity.HasIndex(e => e.IdContribuyente)
                .HasName("IdContribuyente");

            entity.HasIndex(e => e.IdEstadoContribuyente)
                .HasName("IX_Contribuyentes_IdEstadoContribuyente");

            entity.HasIndex(e => e.IdTipoDocumento)
                .HasName("ContribuyentesIdTipoDocumento");

            entity.HasIndex(e => new { e.IdContribuyente, e.IdEstadoContribuyente })
                .HasName("IX_Contribuyentes_IdContribuyenteIdEstadoContribuyente");

            entity.HasIndex(e => new { e.IdContribuyente, e.IdTipoContribuyente, e.IdClasificaContribuyente })
                .HasName("IX_Contribuyentes_IdContribIdTipoIdClasifica");

            entity.HasIndex(e => new { e.IdContribuyente, e.IdEstadoContribuyente, e.IdTipoContribuyente, e.IdClasificaContribuyente })
                .HasName("IX_Contribuyentes_IdContribuyenteIdEstadoIdTipoIdClasifica");

            entity.HasIndex(e => new { e.IdContribuyente, e.Apellido, e.Nombre, e.IdEstadoContribuyente, e.IdTipoContribuyente, e.IdClasificaContribuyente })
                .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente");

            entity.HasIndex(e => new { e.IdContribuyente, e.Apellido, e.Nombre, e.IdTipoDocumento, e.IdEstadoContribuyente, e.IdTipoContribuyente, e.IdClasificaContribuyente })
                .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente");

            entity.HasIndex(e => new { e.IdContribuyente, e.Apellido, e.Nombre, e.IdTipoDocumento, e.NroDocumento, e.IdEstadoContribuyente, e.IdClasificaContribuyente })
                .HasName("IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoNroDocumentoIdEstadoContribuyenteIdClasificaContribuyente");

            entity.Property(e => e.IdContribuyente).ValueGeneratedNever();

            entity.Property(e => e.Apellido)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Cbu)
                .HasColumnName("CBU")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Codcontri)
                .HasColumnName("codcontri")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Discapacidades).IsUnicode(false);

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Enfermedades).IsUnicode(false);

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");

            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

            entity.Property(e => e.IdEstadoContribuyente)
                .HasColumnName("idEstadoContribuyente")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("((0))");

            entity.Property(e => e.Medicamentos).IsUnicode(false);

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Obs)
                .HasColumnName("obs")
                .IsUnicode(false);

            entity.Property(e => e.OtraCapacitacion).IsUnicode(false);

            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Tratamientos).IsUnicode(false);

            entity.HasOne(d => d.idClasifImpresion)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdClasifImpresion)
                .HasConstraintName("FK_Contribuyentes_ClasifImpresion");

            entity.HasOne(d => d.idClasificaContribuyente)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdClasificaContribuyente)
                .HasConstraintName("FK_Contribuyentes_ClasificaContribuyente");

            entity.HasOne(d => d.idCoberturaSocial)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdCoberturaSocial)
                .HasConstraintName("FK_Contribuyentes_CoberturasSociales");

            entity.HasOne(d => d.idEstadoContribuyente)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdEstadoContribuyente)
                .HasConstraintName("FK_Contribuyentes_EstadosContribuyentes");

            entity.HasOne(d => d.idFuenteFinanciamiento)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdFuenteFinanciamiento)
                .HasConstraintName("FK_Contribuyentes_FuentesFinanciamiento");

            entity.HasOne(d => d.idFuncionOcupacion)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdFuncionOcupacion)
                .HasConstraintName("FK_Contribuyentes_FuncionesOcupacion");

            entity.HasOne(d => d.idIngresoContribuyente)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdIngresoContribuyente)
                .HasConstraintName("FK_Contribuyentes_IngresosContribuyente");

            entity.HasOne(d => d.idNivelEscolarizacion)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdNivelEscolarizacion)
                .HasConstraintName("FK_Contribuyentes_NivelesEscolarizacion");

            entity.HasOne(d => d.idOcupacion)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdOcupacion)
                .HasConstraintName("FK_Contribuyentes_Ocupaciones");

            entity.HasOne(d => d.idTipoContribuyente)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdTipoContribuyente)
                .HasConstraintName("FK_Contribuyentes_TiposContribuyentes");

            entity.HasOne(d => d.idTipoDocumento)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK_Contribuyentes_TiposDocumentos");

            entity.HasOne(d => d.idTipoOcupacion)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdTipoOcupacion)
                .HasConstraintName("FK_Contribuyentes_TiposOcupacion");

            entity.HasOne(d => d.idZonaColector)
                .WithMany(p => p.Contribuyentes)
                .HasForeignKey(d => d.IdZonaColector)
                .HasConstraintName("FK_Contribuyentes_ZonasColectores");
        }
    }
}
