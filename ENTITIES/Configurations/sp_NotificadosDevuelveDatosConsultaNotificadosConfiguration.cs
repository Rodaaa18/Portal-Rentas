using DATA.SP_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ENTITIES.Configurations
{
    public class sp_NotificadosDevuelveDatosConsultaNotificadosConfiguration
    {
        public sp_NotificadosDevuelveDatosConsultaNotificadosConfiguration(EntityTypeBuilder<sp_NotificadosDevuelveDatosConsultaNotificados> entity)
        {
            entity.HasNoKey();
            entity.Property(e => e.start);
            entity.Ignore(e => e.pageSize);
            entity.Ignore(x => x.IdCuenta);
            entity.Ignore(x=>x.TyC);
            entity.Ignore(x=> x.Obs);
            entity.Ignore(x=> x.Entregado);
            entity.Ignore(x=>x.ApellidoNombre);
            entity.Ignore(x=>x.FechaFotificacion);
            entity.Ignore(x=>x.FechaAlcance);
            entity.Ignore(x=> x.NroNotificacion);
        }
    }
}
