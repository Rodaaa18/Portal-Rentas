using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class ClasifImpresionConfiguration
    {
        public ClasifImpresionConfiguration(EntityTypeBuilder<ClasifImpresion> entity)
        {
            entity.HasKey(e => e.IdClasifImpresion);

            entity.HasIndex(e => e.Descripcion)
                .HasName("det_DescripcionUnica")
                .IsUnique();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
