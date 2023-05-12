using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThresholdController : ControllerBase
    {
        /// <summary>
        /// Get all Modules Dynamics
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Modules Dynamics</returns>
        [HttpGet]
        public IEnumerable<Threshold> Get([FromServices] MonitoringContext monitCont) => monitCont.Threshold;

        [HttpPut("{id}")]
        public IEnumerable<Threshold> Update(int id, [FromForm] MonitoringContext monitCont) => 
            monitCont.Threshold
            ;
    }
}
