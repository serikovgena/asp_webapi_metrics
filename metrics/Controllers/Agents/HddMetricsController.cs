using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metrics.Controllers
{
    [ApiController]
    [Route("api/metrics/hdd")]
    internal class HddMetricsController : Controller
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        internal IActionResult GetLeftSpaceMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime) {
            return Ok();
        }
    }
}
