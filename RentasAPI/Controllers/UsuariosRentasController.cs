using DATA.Errors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SERVICE.QueryServices;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RentasAPI.Controllers
{
    [ApiController]
    [Route("login")]
    public class UsuariosRentasController : ControllerBase
    {
        private readonly ILogger<UsuariosRentasController> _logger;
        private readonly IUsuariosQueryService _usuariosQueryService;
        public UsuariosRentasController(ILogger<UsuariosRentasController> logger, IUsuariosQueryService productQueryService)
        {
            _logger = logger;
            _usuariosQueryService = productQueryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(string usuario, string clave)
        {
            try
            {

                var listNotificacion =  _usuariosQueryService.GetUsuariosRentas(usuario, clave);

                return Ok(listNotificacion);
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
