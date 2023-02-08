using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertTypesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AlertType> Get([FromServices] MonitoringContext monitCont) => monitCont.AlertTypes;
    }
}
