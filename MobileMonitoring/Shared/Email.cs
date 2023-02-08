using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Email
    {
        [JsonIgnore]
        public int IdEmail { get; set; }
        public required User UserSender { get; set; }
        public required User UserReceiver { get; set; }
        public required EmailStatus EmailStatus { get; set; }
        public required string Subject { get; set; }
        public required DateTime CreationDate { get; set; }
    }
}
