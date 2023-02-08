using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Company
    {
        [JsonIgnore]
        public int IdCompany { get; set; }
        public required string Name { get; set; }
    }
}
