using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberSequencesController : ControllerBase
    {
        /// <summary>
        /// Get all Number Sequences
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Number Sequences</returns>
        [HttpGet]
        public IEnumerable<NumberSequence> Get([FromServices] MonitoringContext monitCont) => monitCont.NumberSequences;
    }
}
