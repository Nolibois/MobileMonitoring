using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Tile
    {
        [JsonIgnore]
        public int IdTile {get; set;}
        public required string Name { get; set;}
        public double? Number { get; set;}
        public required bool Alert { get; set;}
        public required ModuleDynamics ModuleDynamics { get; set;}
    }
}
