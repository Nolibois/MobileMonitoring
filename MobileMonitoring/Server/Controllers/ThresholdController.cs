using Microsoft.AspNetCore.Authorization;
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

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] Threshold updatedThreshold, [FromServices] MonitoringContext monitCont)
        {
            var threshold = await monitCont.Threshold.Include(t => t.ThresholdWarnings).FirstOrDefaultAsync(t => t.IdThreshold == id);

            if (threshold == null)
            {
                return NotFound();
            }

            threshold.IdThreshold = updatedThreshold.IdThreshold;
            threshold.ThresholdWarnings = updatedThreshold.ThresholdWarnings;

            try
            {
                await monitCont.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThresholdExists(id, monitCont))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(threshold);
        }

        private bool ThresholdExists(int id, [FromServices] MonitoringContext monitCont) => monitCont.Threshold.Any(t => t.IdThreshold == id);
    }
}
