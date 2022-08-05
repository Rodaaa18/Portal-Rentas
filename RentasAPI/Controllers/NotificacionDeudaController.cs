using DATA.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SERVICE.QueryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RentasAPI.Controllers
{
    [ApiController]
    [Route("notificacion")]
    public class NotificacionDeudaController : ControllerBase
    {
        private readonly ILogger<NotificacionDeudaController> _logger;
        private readonly INotificacionDeudaQueryService _notificacionesQueryService;
        public NotificacionDeudaController(ILogger<NotificacionDeudaController> logger, INotificacionDeudaQueryService productQueryService)
        {
            _logger = logger;
            _notificacionesQueryService = productQueryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int start = 1, int pageSize = 10)
        {
            try
            {
                var listNotificacion = await _notificacionesQueryService.GetNotificacion(start, pageSize);
                
                var result = new GetResponse()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Message = "success",
                    Result = listNotificacion
                };
                return Ok(result);
            }
            catch (EmptyCollectionException ex)
            {
                _logger.LogError(ex.Message);
                return Ok(new GetResponse()
                {
                    StatusCode = (int)HttpStatusCode.MultiStatus,
                    Message = ex.Message,
                    Result = null
                });
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return Ok(new GetResponse()
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = "Server error",
                    Result = null
                });
            }
        }
    }
}
