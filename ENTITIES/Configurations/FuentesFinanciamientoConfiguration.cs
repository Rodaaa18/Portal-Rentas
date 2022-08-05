using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class FuentesFinanciamientoConfiguration
    {
        public FuentesFinanciamientoConfiguration(EntityTypeBuilder<FuentesFinanciamiento> entity)
        {
            entity.HasKey(e => e.IdFuenteFinanciamiento)
                    .IsClustered(false);

            entity.Property(e => e.FuenteFinanciamiento)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
