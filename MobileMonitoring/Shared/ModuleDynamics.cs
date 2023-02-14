using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class ModuleDynamics
    {
        [Key,JsonIgnore]
        public int IdModule { get; set; }

        [Required, StringLength(50)]
        public required string Name { get; set; }
    }
}
