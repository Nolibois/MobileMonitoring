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
            string colorCardTile = "danger";

            return tile.Alert ? colorCardTile = "primary" : colorCardTile;
        }

        /// <summary>
        /// Color line least the limit
        /// </summary>
        /// <param name="numberSequence"></param>
        /// <returns></returns>
        public static string CriticalNumberSequence(this NumberSequenceDto numberSequence)
        {
            string styleLineNbSeq = "";

            return numberSequence.Remaining < 10 ? styleLineNbSeq ="bg-danger text-light" : styleLineNbSeq;
        }


        /// <summary>
        /// Display or not display
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /*public static string displayButtonSaveThreshold(this Threshold threshold)
        {
            string displayState = "d-flex";

            return threshold.ThresholdWarnings is not null ? displayState :  displayState = "d-none";
        }*/

    }
}
