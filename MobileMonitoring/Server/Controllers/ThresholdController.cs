using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ThresholdController : ControllerBase
    {
        /// <summary>
        /// Get all thresholds of Modules Dynamics
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Thresholds</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Threshold> Get([FromServices] MonitoringContext monitCont) => monitCont.Threshold;

        /// <summary>
        /// Update Threshold by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedThreshold"></param>
        /// <param name="monitCont"></param>
        /// <returns></returns>
        /// <response code="201">Returns the newly updated item</response>
        /// <response code="400">If the items are null</response>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, [FromBody] Threshold updatedThreshold, [FromServices] MonitoringContext monitCont)
        {
            var threshold = await monitCont.Threshold.FirstOrDefaultAsync(t => t.IdThreshold == id);

            if (threshold == null)
            {
                return NotFound();
            }

            threshold.IdThreshold = id;
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
