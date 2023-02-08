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
        public IEnumerable<CleanupDto> Get([FromServices] MonitoringContext monitCont) => monitCont.Cleanups.Select(cleanup => new CleanupDto(cleanup));
    }
}
