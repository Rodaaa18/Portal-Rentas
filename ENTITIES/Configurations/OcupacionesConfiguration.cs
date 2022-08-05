using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class OcupacionesConfiguration
    {
        public OcupacionesConfiguration(EntityTypeBuilder<Ocupaciones> entity)
        {
            entity.HasKey(e => e.IdOcupacion)
                    .IsClustered(false);

            entity.Property(e => e.Obs).IsUnicode(false);

            entity.Property(e => e.Ocupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
