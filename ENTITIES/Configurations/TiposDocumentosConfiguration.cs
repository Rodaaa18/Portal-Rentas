using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class TiposDocumentosConfiguration
    {
        public TiposDocumentosConfiguration(EntityTypeBuilder<TiposDocumentos> entity)
        {
            entity.HasKey(e => e.IdTipoDocumento)
                     .HasName("aaaaaTiposDocumentos_PK")
                     .IsClustered(false);

            entity.HasIndex(e => e.IdTipoDocumento)
                .HasName("IdCalle");

            entity.HasIndex(e => e.TipoDocumento)
                .HasName("TiposDocumentosTipoDocumento");

            entity.HasIndex(e => new { e.IdTipoDocumento, e.TipoDocumento })
                .HasName("IX_TiposDocumentos_IdTipoDocumentoTipoDocumento");

            entity.Property(e => e.IdTipoDocumento).ValueGeneratedNever();

            entity.Property(e => e.Obs).HasMaxLength(50);

            entity.Property(e => e.TipoDocumento)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.ValidaCuit).HasColumnName("ValidaCUIT");
        }
    }
}
