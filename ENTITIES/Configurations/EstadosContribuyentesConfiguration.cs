using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENTITIES.Configurations
{
    public class EstadosContribuyentesConfiguration
    {
        public EstadosContribuyentesConfiguration(EntityTypeBuilder<EstadosContribuyentes> entity)
        {
            entity.HasKey(e => e.IdEstadoContribuyente);

            entity.HasIndex(e => e.Estado)
                .HasName("det_EstadoContribuyenteUnico")
                .IsUnique();

            entity.Property(e => e.IdEstadoContribuyente).ValueGeneratedNever();

            entity.Property(e => e.Estado).HasMaxLength(50);

            entity.Property(e => e.Obs).HasMaxLength(100);
        }
    }
}
