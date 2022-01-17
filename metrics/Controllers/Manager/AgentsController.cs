﻿using metrics.Controllers.Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metrics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    internal class AgentsController : ControllerBase
    {
        [HttpPost("register")]
        internal IActionResult RegisterAgent([FromBody] AgentInfo agentInfo) {
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        internal IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        internal IActionResult DisableAgentById([FromRoute] int agentId) {
            return Ok();
        }
    }
}
