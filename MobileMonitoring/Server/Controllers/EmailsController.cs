using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class EmailsController : ControllerBase
    {
        /// <summary>
        /// Get all emails
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Emails with details and user sender and receiver fullname</returns>
        [HttpGet]
        public IEnumerable<EmailDto> Get([FromServices] MonitoringContext monitCont) => 
            monitCont.Emails
                .Include(email => email.UserSender)
                .Include(email => email.UserReceiver)
                .Include(email => email.EmailStatus)
                .Select(email => new EmailDto(email));
    }
}
