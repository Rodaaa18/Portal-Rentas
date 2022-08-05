using DATA;
using DATA_ACCESS.Generic;
using MAPPING.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SERVICE.QueryServices
{
    public interface INotificacionDeudaQueryService
    {
        Task<ActionResult<int>> GetNotificacion(int start, int pageSize);
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
        
        public async Task<ActionResult<int>> GetNotificacion(int start, int pageSize)
        {
            return await _unitOfWork._context.Database.ExecuteSqlRawAsync($@"exec sp_NotificadosDevuelveDatosConsultaNotificadosPaginado @start = {start}, @pageSize = {pageSize}");
        }
    }
}
