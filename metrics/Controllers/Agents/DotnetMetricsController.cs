using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metrics.Controllers
{
    [ApiController]
    [Route("api/metrics/dotnet")]
    internal class DotnetMetricsController : Controller
    {
        [HttpGet("errors-count/from/{fromTime}/to/{toTime}")]
        internal IActionResult GetErrorCountMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}
