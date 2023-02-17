using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Cleanup
    {
        [Key, JsonIgnore]
        public int  IdCleanup { get; set; }

        public int UserId { get; set; }
        public int TileId { get; set; }
        public int AlertTypeId { get; set; }

        public required DateTime CleanupDate { get; set; }
        public required DateTime AlertCreationDate { get; set; }

        #region Populated by EF Core
        #pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual User User { get; set; }
        public virtual Tile Tile { get; set; }
        public virtual AlertType AlertType { get; set; }
        #pragma warning restore CS8618
        #endregion
    }
}
