﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class NumberSequencesController : ControllerBase
    {
        /// <summary>
        /// Get all Number Sequences
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of Number Sequences</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<NumberSequenceDto> Get([FromServices] MonitoringContext monitCont) => monitCont.NumberSequences
            .Include(numberSequence => numberSequence.Company)
            .Select(numberSequence => new NumberSequenceDto(numberSequence))
            .AsEnumerable()
            .OrderBy(numberSequence => numberSequence.Remaining)
            .ToList();
    }
}
