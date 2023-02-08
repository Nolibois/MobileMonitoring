using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class NumberSequence
    {
        [JsonIgnore]
        public int IdNumberSequence { get; set; }
        public required int CompanyId { get; set; }
        public required string NbSequence { get; set; }
        public required bool InUse { get; set; }
        public required int Remaining { get; set; }
    }
}
