using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ENTITIES.Configurations
{
    public class PerfilesConfiguration
    {
        public PerfilesConfiguration(EntityTypeBuilder<Perfiles> entity)
        {
            entity.HasKey(e => e.IDperfil);

            entity.Property(e => e.IDperfil)
                .HasColumnName("iDPerfil")
                .ValueGeneratedNever();

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Obs)
                .HasMaxLength(1000)
                .IsUnicode(false);
        }
    }
}
