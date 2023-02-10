using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesDynamicsController : ControllerBase
    {
        /// <summary>
        /// Get all Modules Dynamics
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Modules Dynamics</returns>
        [HttpGet]
        public IEnumerable<ModuleDynamics> Get([FromServices] MonitoringContext monitCont) => monitCont.ModulesDynamics;
    }
}
