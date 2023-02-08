using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class User
    {
        public int IdUser { get; set; }
        public required string FullName { get; set; }
        public required int DynamicsId { get; set; }
        public required Company Company { get; set; }
    }
}
