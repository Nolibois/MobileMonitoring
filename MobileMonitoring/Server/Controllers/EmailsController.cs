using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        /// <summary>
        /// Get all emails
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Emails with details and user sender and receiver fullname</returns>
        [HttpGet]
        public IEnumerable<EmailDto> Get([FromServices] MonitoringContext monitCont) => monitCont.Emails.Select(email => new EmailDto(email));
    }
}
