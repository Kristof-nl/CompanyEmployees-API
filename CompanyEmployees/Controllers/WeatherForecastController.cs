using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is a info message from our values controller.");
            _logger.LogDebug("Here is a debug message from our values controller.");
            _logger.LogWarn("Here is a warn message from our values controller.");
            _logger.LogError("Here is an error message from our values controller.");

            return new string[] { "value1", "value2" };
        }
    }
}
