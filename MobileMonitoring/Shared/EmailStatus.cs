using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class EmailStatus
    {
        [JsonIgnore]
        public int IdEmailStatus { get; set; }
        public required string Name { get; set; }
    }
}
