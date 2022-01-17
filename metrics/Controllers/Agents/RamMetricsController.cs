using Microsoft.AspNetCore.Mvc;
using System;

namespace metrics.Controllers
{
    [ApiController]
    [Route("api/metrics/ram")]
    internal class RamMetricsController : Controller
    {
        [HttpGet("available/from/{fromTime}/to/{toTime}")]
        internal IActionResult GetAvailableRamMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}
