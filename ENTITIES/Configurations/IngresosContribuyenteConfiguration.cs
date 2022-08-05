using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class IngresosContribuyenteConfiguration
    {
        public IngresosContribuyenteConfiguration(EntityTypeBuilder<IngresosContribuyente> entity)
        {
            entity.HasKey(e => e.IdIngresoContribuyente)
                    .IsClustered(false);

            entity.Property(e => e.IngresoContribuyente)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
