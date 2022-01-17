using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metrics.Controllers
{
    [ApiController]
    [Route("api/metrics/network")]
    internal class NetworkMetricsController : Controller
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        internal IActionResult GetConnectionsCountMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}
