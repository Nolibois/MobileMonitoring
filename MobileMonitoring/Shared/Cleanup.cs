using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Cleanup
    {
        [Key, JsonIgnore]
        public int  IdCleanup { get; set; }

        public int UserId { get; set; }
        public int AlertTypeId { get; set; }

        public required DateTime CleanupDate { get; set; }
        public required DateTime AlertCreationDate { get; set; }
        public required AlertType AlertType { get; set; }

        #region Populated by EF Core
        public required User User { get; set; }
        #endregion
    }
}
