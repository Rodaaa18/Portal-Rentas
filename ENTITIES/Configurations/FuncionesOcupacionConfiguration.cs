using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ENTITIES.Configurations
{
    public class FuncionesOcupacionConfiguration
    {
        public FuncionesOcupacionConfiguration(EntityTypeBuilder<FuncionesOcupacion> entity)
        {
            entity.HasKey(e => e.IdFuncionOcupacion)
                    .IsClustered(false);

            entity.Property(e => e.FuncionOcupacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);
        }
    }
}
