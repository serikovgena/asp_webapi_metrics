using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.CompilerServices;

namespace metrics.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    internal class CpuMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        internal IActionResult GetCpuMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}