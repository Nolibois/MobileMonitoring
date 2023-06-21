using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class AlertTypesController : ControllerBase
    {
        /// <summary>
        /// Get All AlertType
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Alert type</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<AlertType> Get([FromServices] MonitoringContext monitCont) => monitCont.AlertTypes;
    }
}
