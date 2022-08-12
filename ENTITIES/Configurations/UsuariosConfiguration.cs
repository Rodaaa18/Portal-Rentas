using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ENTITIES.Configurations
{
    public class UsuariosConfiguration
    {
        public UsuariosConfiguration(EntityTypeBuilder<Usuarios> entity)
        {
            entity.HasKey(e => e.IDusuario);

            entity.Property(e => e.IDusuario)
                .HasColumnName("iDUsuario")
                .ValueGeneratedNever();

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Obs).IsUnicode(false);

            entity.Property(e => e.RutaFirma)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
