using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TilesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TileDto> Get([FromServices] MonitoringContext monitCont) => monitCont.Tiles.Select(tile => new TileDto(tile));
    }
}
