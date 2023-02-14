using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class AlertType
    {
        [Key, JsonIgnore]
        public int IdAlertType { get; set; }

        [Required, StringLength(50)]
        public required string Name { get; set; }
    }
}
