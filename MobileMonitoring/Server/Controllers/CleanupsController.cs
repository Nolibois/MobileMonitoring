using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CleanupsController : ControllerBase
    {
        /// <summary>
        /// Get all cleanups
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of cleanups with details and user Fullname</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<CleanupDto> Get([FromServices] MonitoringContext monitCont) => 
            monitCont.Cleanups
                .Include(cleanup => cleanup.User)
                .Include(cleanup => cleanup.User.Company)
                .Include(cleanup => cleanup.Tile)
                .Include(cleanup => cleanup.AlertType)
                .Select(cleanup => new CleanupDto(cleanup));

        /// <summary>
        /// Get all cleanups with the same cleanup type
        /// </summary>
        /// <param name="monitCont"></param>
        /// <param name="id"></param>
        /// <returns>List of cleanups filtered wtih tile Id</returns>
        /// <response code="400">If the item is null</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<CleanupDto> GetById([FromServices] MonitoringContext monitCont, int id) =>
            monitCont.Cleanups
                .Include(cleanup => cleanup.User)
                .Include(cleanup => cleanup.User.Company)
                .Include(cleanup => cleanup.Tile)
                .Include(cleanup => cleanup.AlertType)
                .Select(cleanup => new CleanupDto(cleanup))
                .AsEnumerable()
                .Where(cleanup => cleanup.TileId == id)
            .ToList();
    }
}
