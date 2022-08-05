using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class TiposOcupacionConfiguration
    {
        public TiposOcupacionConfiguration(EntityTypeBuilder<TiposOcupacion> entity)
        {
            entity.HasKey(e => e.IdTipoOcupacion)
                   .IsClustered(false);

            entity.Property(e => e.Obs).IsUnicode(false);

            entity.Property(e => e.TipoOcupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
