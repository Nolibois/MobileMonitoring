using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class NumberSequence
    {
        [Key, JsonIgnore]
        public int IdNumberSequence { get; set; }

        public required int CompanyId { get; set; }

        [Required, StringLength(50)]
        public required string NbSequence { get; set; }

        [Required]
        public required bool InUse { get; set; }

        [Required]
        public required int Remaining { get; set; }
    }
}
