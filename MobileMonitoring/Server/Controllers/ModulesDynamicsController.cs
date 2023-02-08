using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesDynamicsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ModuleDynamics> Get([FromServices] MonitoringContext monitCont) => monitCont.ModulesDynamics;
    }
}
