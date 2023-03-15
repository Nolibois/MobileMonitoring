using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<NumberSequenceDto> Get([FromServices] MonitoringContext monitCont) => monitCont.NumberSequences
            .Include(numberSequence => numberSequence.Company)
            .Select(numberSequence => new NumberSequenceDto(numberSequence));
    }
}
