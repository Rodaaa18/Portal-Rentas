using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class ClasificaContribuyenteConfiguration 
    {
        public ClasificaContribuyenteConfiguration(EntityTypeBuilder<ClasificaContribuyente> entity)
        {
            entity.HasKey(e => e.IdClasificaContribuyente);

            entity.HasIndex(e => e.Clasificacion)
                .HasName("det_ClasificacionUnico")
                .IsUnique();

            entity.HasIndex(e => e.PropioRentas);

            entity.Property(e => e.IdClasificaContribuyente).ValueGeneratedNever();

            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
