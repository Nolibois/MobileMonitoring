using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanupsController : ControllerBase
    {
        /// <summary>
        /// Get all sleanups
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of cleanups with deatils and user Fullname</returns>
        [HttpGet]
        public IEnumerable<CleanupDto> Get([FromServices] MonitoringContext monitCont) => 
            monitCont.Cleanups
                .Include(cleanup => cleanup.User)
                .Include(cleanup => cleanup.User.Company)
                .Include(cleanup => cleanup.AlertType)
                .Select(cleanup => new CleanupDto(cleanup));
    }
}
