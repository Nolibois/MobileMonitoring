using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class AlertType
    {
        [JsonIgnore]
        public int IdAlertType { get; set; }
        public required string Name { get; set; }
    }
}
