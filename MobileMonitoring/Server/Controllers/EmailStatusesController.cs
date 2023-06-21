using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class EmailStatusesController : ControllerBase
    {
        /// <summary>
        /// Get all email status
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of email status</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<EmailStatus> Get([FromServices] MonitoringContext monitCont) => monitCont.EmailStatuses;
    }
}
