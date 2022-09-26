using DATA;
using DATA_ACCESS.Generic;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace SERVICE.QueryServices
{
    public interface INotificacionDeudaQueryService
    {
        List<NotificacionDeudaDTO> GetNotificacion(Nullable<int> start, Nullable<int> pageSize);
       
    }
    public class NotificacionDeudaQueryService : INotificacionDeudaQueryService
    {
        private readonly IGenericRepository<NotificacionDeudaDTO> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public NotificacionDeudaQueryService(IGenericRepository<NotificacionDeudaDTO> genericRepository, IUnitOfWork unitOfWork)
        {
            _repository = genericRepository;
            _unitOfWork = unitOfWork;
        }

        public List<NotificacionDeudaDTO> GetNotificacion(Nullable<int> start, Nullable<int> pageSize)
        {
            
            SqlConnection conn = (SqlConnection)_unitOfWork._context.Database.GetDbConnection();
            SqlCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_NotificadosDevuelveDatosConsultaNotificadosPaginado";
            cmd.Parameters.Add("@start", System.Data.SqlDbType.Int).Value = start;
            cmd.Parameters.Add("@pageSize", System.Data.SqlDbType.Int).Value = pageSize;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            var listNotifications = (from row in dt.AsEnumerable()
                                     select new NotificacionDeudaDTO()
                                     {
                                         IdNotificado = row.Field<int>("IdNotificado"),
                                         FechaNotificacion = row.Field<DateTime>("FechaNotificacion"),
                                         NroNotificacion = row.Field<int>("NroNotificacion"),
                                         ApellidoNombre = row.Field<string>("ApellidoNombre"),
                                         IdCuenta = row.Field<int>("IdCuenta"),
                                         TyC = row.Field<string>("TyC"),
                                         ImporteNeto = row.Field<decimal>("ImporteNeto"),
                                         ImporteTotal = row.Field<decimal>("ImporteTotal"),
                                         Interes = row.Field<decimal>("Interes"),
                                         FechaAlcance = row.Field<DateTime>("FechaAlcance"),
                                         Obs = row.Field<string>("Obs"),
                                         Entregado = row.Field<bool>("Entregado"),
                                         Email = row.Field<string>("Email"),
                                         TotalFilas = row.Field<int>("TotalFilas"),
                                     }).ToList();
            return listNotifications;

        }

        
    }
}
