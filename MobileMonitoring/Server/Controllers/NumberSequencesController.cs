﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberSequencesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<NumberSequence> Get([FromServices] MonitoringContext monitCont) => monitCont.NumberSequences;
    }
}
