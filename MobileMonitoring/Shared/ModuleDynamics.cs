using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class ModuleDynamics
    {
        [JsonIgnore]
        public int IdModule { get; set; }
        public required string Name { get; set; }
    }
}
