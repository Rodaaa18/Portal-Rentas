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
    [Route("token")]
    public class TokenController : Controller
    {
        private readonly ILogger<TokenController> _logger;
        private readonly ITokenQueryService _tokenQueryService;
        public TokenController(ILogger<TokenController> logger, ITokenQueryService productQueryService)
        {
            _logger = logger;
            _tokenQueryService = productQueryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string token)
        {
            try
            {
                var listNotificacion = _tokenQueryService.getTokenUser(token);

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
