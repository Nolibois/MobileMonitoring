using MobileMonitoring.Shared;

namespace MobileMonitoring.Client.Shared
{
    public static class CssToolbox
    {
        /// <summary>
        /// Alert color exceeding the limit
        /// </summary>
        /// <param name="tile"></param>
        /// <returns>Color of tile, primary it is OK, danger limit exceeded</returns>
        public static string LimitKpiTile(this TileDto tile)
        {
            string colorCardTile = "primary";

            return tile.Alert ? colorCardTile = "danger" : colorCardTile;
        }
    }
}
