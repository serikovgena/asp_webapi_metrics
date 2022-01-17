using Microsoft.AspNetCore.Mvc;
using System;

namespace metrics.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    internal class CpuMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        internal IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}