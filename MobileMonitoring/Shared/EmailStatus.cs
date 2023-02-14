using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class EmailStatus
    {
        [Key, JsonIgnore]
        public int IdEmailStatus { get; set; }

        [Required, StringLength(50)]
        public required string Name { get; set; }
    }
}
