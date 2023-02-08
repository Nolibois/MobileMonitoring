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
        public IEnumerable<EmailDto> Get([FromServices] MonitoringContext monitCont) => monitCont.Emails.Select(email => new EmailDto(email));
    }
}
