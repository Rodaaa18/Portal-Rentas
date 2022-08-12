using DATA;
using DATA_ACCESS.Generic;
using System.Threading.Tasks;
using DATA.SP_Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.Entity.Core.Objects;
using AutoMapper;
using MAPPING.Common;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using DATA.Errors;
using System.Net;

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
                                         FechaFotificacion = row.Field<DateTime>("FechaFotificacion"),
                                         NroNotificacion = row.Field<int>("NroNotificacion"),
                                         ApellidoNombre = row.Field<string>("ApellidoNombre"),
                                         IdCuenta = row.Field<int>("IdCuenta"),
                                         TyC = row.Field<int>("TyC"),
                                         FechaAlcance = row.Field<DateTime>("FechaAlcance"),
                                         Obs = row.Field<string>("Obs"),
                                         Entregado = row.Field<bool>("Entregado"),
                                     }).ToList();
            return listNotifications;

        }

        //public async Task<ObjectResult<sp_NotificadosDevuelveDatosConsultaNotificados>> GetNotificacionLinQ(int start, int pageSize)
        //{
        //    return _unitOfWork._context.sp_NotificadosDevuelveDatosConsultaNotificados(start, pageSize);
        //}
        //public List<sp_NotificadosDevuelveDatosConsultaNotificados> GetNotificacionLinQ(int start, int pageSize)
        //{
        //    var service = new List<sp_NotificadosDevuelveDatosConsultaNotificados>();

        //    var details = _unitOfWork._context.sp_NotificadosDevuelveDatosConsultaNotificados(start, pageSize);
        //    if (details.Any())
        //        service.AddRange(_unitOfWork._context.sp_NotificadosDevuelveDatosConsultaNotificados(start, pageSize).ToList());


        //    return service;
        //}
        //public List<NotificacionDeudaDTO> GetNotificaciones(int start, int pageSize)
        //{
        //    var sp_linQ = new NotificacionDeudaQueryService(_repository, _unitOfWork);

        //    var result = sp_linQ.GetNotificacionLinQ(start, pageSize);

        //    return result.MapTo<List<NotificacionDeudaDTO>>();


        //}
    }
}
