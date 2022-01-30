using Microsoft.AspNetCore.Mvc;

namespace VeryUsefulService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeryUsefulServiceController : ControllerBase
    {
        private readonly ILogger<VeryUsefulServiceController> _logger;

        public VeryUsefulServiceController(ILogger<VeryUsefulServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<int> Get(int length)
        {
            return Enumerable.Range(1, length).ToArray();
        }
    }
}