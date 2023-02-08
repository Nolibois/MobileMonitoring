using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Cleanup
    {
        [JsonIgnore]
        public int  IdCleanup { get; set; }
        public required User User { get; set; }
        public required DateTime CleanupDate { get; set; }
        public required DateTime AlertCreationDate { get; set; }
        public required AlertType AlertType { get; set; }
    }
}
