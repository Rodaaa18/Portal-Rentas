using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class NivelesEscolarizacionConfiguration
    {
        public NivelesEscolarizacionConfiguration(EntityTypeBuilder<NivelesEscolarizacion> entity)
        {
            entity.HasKey(e => e.IdNivelEscolarizacion)
                    .IsClustered(false);

            entity.Property(e => e.NivelEscolarizacion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
