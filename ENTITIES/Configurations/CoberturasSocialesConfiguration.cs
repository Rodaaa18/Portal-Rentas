using DATA.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace ENTITIES.Configurations
{
    public class CoberturasSocialesConfiguration
    {
        public CoberturasSocialesConfiguration(EntityTypeBuilder<CoberturasSociales> entity)
        {
            entity.HasKey(e => e.IdCoberturaSocial)
                    .IsClustered(false);

            entity.Property(e => e.CoberturaSocial)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
