using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class ZonasColectoresConfiguration
    {
        public ZonasColectoresConfiguration(EntityTypeBuilder<ZonasColectores> entity)
        {
            entity.HasKey(e => e.IdZonaColector);

            entity.HasIndex(e => e.Zona)
                .HasName("det_zonaColectorUnico")
                .IsUnique();

            entity.Property(e => e.Obs).IsUnicode(false);

            entity.Property(e => e.Zona)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
