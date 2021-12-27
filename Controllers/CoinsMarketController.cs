using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleService.Services;

namespace SampleService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsMarketController : ControllerBase
    {
        private readonly IApiClient _apiClient;
        private readonly ILogger<CoinsMarketController> _logger;

        public CoinsMarketController(
            ILogger<CoinsMarketController> logger,
            IApiClient apiClient
            )
        {
            _apiClient = apiClient;
            _logger = logger;
            
        }

        [HttpGet]
        [Route("{currency}")]
        public IActionResult Get(string currency)
        {
            var result = _apiClient.ConnectToApi(currency);
            return Ok(result);
        }
        

    }
}