using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MobileMonitoring.Shared
{
    public class Threshold
    {
        [Key, JsonIgnore]
        public int IdThreshold { get; set; }

        [Range(0, 100, ErrorMessage = "The number must be between 0-100")]
        public int? ThresholdWarnings { get; set; }

    }
}
