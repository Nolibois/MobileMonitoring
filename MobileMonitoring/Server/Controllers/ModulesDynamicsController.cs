﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ModulesDynamicsController : ControllerBase
    {
        /// <summary>
        /// Get all Modules Dynamics
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Modules Dynamics</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<ModuleDynamics> Get([FromServices] MonitoringContext monitCont) => monitCont.ModulesDynamics;
    }
}
