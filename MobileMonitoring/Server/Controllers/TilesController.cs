using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TilesController : ControllerBase
    {
        /// <summary>
        /// Get all tiles
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of tiles with module dynamics name</returns>
        [HttpGet]
        public IEnumerable<TileDto> Get([FromServices] MonitoringContext monitCont) => 
            monitCont.Tiles
                .Include(tile => tile.ModuleDynamics)
                .Select(tile => new TileDto(tile));
    }
}
