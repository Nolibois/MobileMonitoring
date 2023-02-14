using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MobileMonitoring.Shared
{
    public class Company
    {
        [Key, JsonIgnore]
        public int IdCompany { get; set; }

        [Required, StringLength(20)]
        public required string Name { get; set; }
    }
}
