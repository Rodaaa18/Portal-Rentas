using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ENTITIES.Configurations
{
    public class UsuariosPerfilesConfiguration
    {
        public UsuariosPerfilesConfiguration(EntityTypeBuilder<UsuariosPerfiles> entity)
        {
            entity.HasKey(e => e.IDusuarioPerfil);

            entity.Property(e => e.IDusuarioPerfil)
                .HasColumnName("iDUsuarioPerfil")
                .ValueGeneratedNever();

            entity.Property(e => e.IDperfil).HasColumnName("iDPerfil");

            entity.Property(e => e.IDusuario).HasColumnName("iDUsuario");

            entity.HasOne(d => d.Idperfil)
                .WithMany(p => p.UsuariosPerfiles)
                .HasForeignKey(d => d.IDperfil)
                .HasConstraintName("FK_UsuariosPerfiles_Perfiles");

            entity.HasOne(d => d.Idusuario)
                .WithMany(p => p.UsuariosPerfiles)
                .HasForeignKey(d => d.IDusuario)
                .HasConstraintName("FK_UsuariosPerfiles_Usuarios");
        }
    }
}
