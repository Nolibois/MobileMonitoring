using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Email> Get([FromServices] MonitoringContext monitCont) => monitCont.Emails;
    }
}
