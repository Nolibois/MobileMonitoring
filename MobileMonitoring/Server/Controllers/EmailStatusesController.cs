using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailStatusesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<EmailStatus> Get([FromServices] MonitoringContext monitCont) => monitCont.EmailStatuses;
    }
}
