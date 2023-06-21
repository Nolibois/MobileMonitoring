using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CompaniesController : ControllerBase
    {

        /// <summary>
        /// Get all companies
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of companies</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Company> Get([FromServices] MonitoringContext monitCont) => monitCont.Companies;

    }
}
