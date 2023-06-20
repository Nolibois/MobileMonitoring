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
        [HttpGet]
        public IEnumerable<Company> Get([FromServices] MonitoringContext monitCont) => monitCont.Companies;

    }
}
