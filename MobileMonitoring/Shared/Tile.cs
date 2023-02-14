using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Tile
    {
        [Key, JsonIgnore]
        public int IdTile {get; set;}

        [Required, StringLength(100)]
        public required string Name { get; set;}

        public double? Number { get; set;}

        [Required]
        public required bool Alert { get; set;}

        public int ModuleDynamicsId { get; set;}

        #region Populated by EF Core
        public required ModuleDynamics ModuleDynamics { get; set;}
        #endregion
    }
}
