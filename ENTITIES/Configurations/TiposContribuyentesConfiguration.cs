using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ENTITIES.Configurations
{
    public class TiposContribuyentesConfiguration
    {
        public TiposContribuyentesConfiguration(EntityTypeBuilder<TiposContribuyentes> entity)
        {
            entity.HasKey(e => e.IdTipoContribuyente);

            entity.HasIndex(e => e.TipoContribuyente)
                .HasName("det_TipoContribuyenteUnico")
                .IsUnique();

            entity.Property(e => e.IdTipoContribuyente).ValueGeneratedNever();

            entity.Property(e => e.TipoContribuyente)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
