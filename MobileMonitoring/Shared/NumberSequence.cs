using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class NumberSequence
    {
        [Key, JsonIgnore]
        public int IdNumberSequence { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required, StringLength(50)]
        public required string NbSequence { get; set; }

        [Required]
        public required bool InUse { get; set; }

        [Required]
        [Range(0, 100)]
        public required int Remaining { get; set; }

        #region Populated by EF Core
        #pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual Company Company { get; set; }
        #pragma warning restore CS8618
        #endregion
    }
}
