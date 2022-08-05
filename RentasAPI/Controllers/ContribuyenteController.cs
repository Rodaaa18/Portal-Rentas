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
    [Route("contribuyente")]
    public class ContribuyenteController : ControllerBase
    {
        private readonly ILogger<ContribuyenteController> _logger;
        private readonly IContribuyenteQueryService _contribuyentesQueryService;
        public ContribuyenteController(ILogger<ContribuyenteController> logger, IContribuyenteQueryService productQueryService)
        {
            _logger = logger;
            _contribuyentesQueryService = productQueryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int page = 1, int take = 10, string ids = null, bool order = false)
        {
            try
            {
                IEnumerable<int> contribuyentes = null;
                
                if (!string.IsNullOrEmpty(ids))
                {
                    contribuyentes = ids.Split(',').Select(x => Convert.ToInt32(x));
                }

                var listContribuyentes = await _contribuyentesQueryService.GetAllAsync(page, take);
                var result = new GetResponse()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Message = "success",
                    Result = listContribuyentes
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
