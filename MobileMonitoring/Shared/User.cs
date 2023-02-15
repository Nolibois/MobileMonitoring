using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class User
    {
        [Key, JsonIgnore]
        public int IdUser { get; set; }

        [Required, StringLength(100)]
        public required string FullName { get; set; }

        public int DynamicsId { get; set; }

        public int CompanyId { get; set; }

        #region Populated by EF Core
        # pragma warning disable CS8618 // Non-nullable field is uninitialized
        public virtual Company Company { get; set; }
        #pragma warning restore CS8618
        #endregion
    }
}
