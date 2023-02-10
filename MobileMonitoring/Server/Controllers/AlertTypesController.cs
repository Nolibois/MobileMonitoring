using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertTypesController : ControllerBase
    {
        /// <summary>
        /// Get All AlertType
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Alert type</returns>
        [HttpGet]
        public IEnumerable<AlertType> Get([FromServices] MonitoringContext monitCont) => monitCont.AlertTypes;
    }
}
