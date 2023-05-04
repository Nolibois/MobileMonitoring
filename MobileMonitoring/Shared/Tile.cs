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

        public int ThresholdId { get; set; }

        #region Populated by EF Core
        #pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual ModuleDynamics ModuleDynamics { get; set;}
        public virtual Threshold Threshold { get; set;}
        #pragma warning restore CS8618
        #endregion
    }
}
