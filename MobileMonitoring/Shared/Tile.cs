namespace MobileMonitoring.Shared
{
    public class Tile
    {
        public int IdTile {get; set;}
        public required string Name { get; set;}
        public required int Number { get; set;}
        public required bool Alert { get; set;}
        public required int idModule { get; set;}
    }
}
