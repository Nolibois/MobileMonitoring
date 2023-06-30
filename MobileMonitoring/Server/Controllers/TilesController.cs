using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileMonitoring.Shared;


namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    [Produces("application/json")]
    public class TilesController : ControllerBase
    {
        /// <summary>
        /// Get all tiles
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of tiles with module dynamics name</returns>
        /// <response code="400">If the items are null</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<TileDto> Get([FromServices] MonitoringContext monitCont) => 
            monitCont.Tiles
                .Include(tile => tile.ModuleDynamics)
                .Include(tile => tile.Threshold)
                .Select(tile => new TileDto(tile));

        /// <summary>
        /// Get Tile by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="monitCont"></param>
        /// <returns></returns>
        /// <response code="400">If the item is null</response>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<TileDto> GetById(int id, [FromServices] MonitoringContext monitCont)
        {
            var tileById = await monitCont.Tiles
                .Include(tile => tile.ModuleDynamics)
                .Include(tile => tile.Threshold)
                .Select(tile => new TileDto()
                {
                    IdTile          = tile.IdTile,
                    Name            = tile.Name,
                    Number          = tile.Number,
                    Alert           = tile.Alert,
                    ModuleDynamics  = tile.ModuleDynamics.Name,
                    Threshold       = tile.Threshold.ThresholdWarnings
                })
                .FirstOrDefaultAsync(tile => tile.IdTile == id);

            if (tileById is null)
            {
                return new TileDto();
            }

            return tileById;

        }


        /// <summary>
        /// Update alert tile by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAlert"></param>
        /// <param name="monitCont"></param>
        /// <returns></returns>
        /// <response code="201">Returns the newly updated item</response>
        /// <response code="400">If the items are null</response>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateAlert(int id, [FromBody] TileDto updateAlert, [FromServices] MonitoringContext monitCont)
        {
            var tile = await monitCont.Tiles
                .Include(tile => tile.Threshold)
                .FirstOrDefaultAsync(tile => tile.IdTile == id);

            if (tile == null)
            {
                return NotFound();
            }

            tile.IdTile = id;
            if(tile.Number >= Convert.ToDouble(tile.Threshold.ThresholdWarnings))
            {
                tile.Alert = false;
            }
            else
            {
                tile.Alert = true;
            }

            try
            {
                await monitCont.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlertExists(id, monitCont))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(tile);
        }

        private static bool AlertExists(int id, [FromServices] MonitoringContext monitCont) => monitCont.Tiles.Any(tile => tile.IdTile == id);
    }
}
