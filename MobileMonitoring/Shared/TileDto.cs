namespace MobileMonitoring.Shared
{
    public record TileDto(int IdTile, string Name, double? Number, string ModuleDynamics,bool Alert = false)
    {
        #region For deserialization only
        public TileDto() : this(default, "", default, "", false) { }
        #endregion

        public TileDto(Tile tile) : this(tile.IdTile, tile.Name, tile.Number,  tile.ModuleDynamics.Name, tile.Alert) { }
    }
}
