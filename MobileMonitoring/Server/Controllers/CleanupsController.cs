using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanupsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cleanup> Get([FromServices] MonitoringContext monitCont) => monitCont.Cleanups;
    }
}
