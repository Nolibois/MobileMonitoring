using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MobileMonitoring.Shared
{
    public class Threshold
    {
        [Key, JsonIgnore]
        public int IdThreshold { get; set; }

        public int ThresholdWarnings { get; set; }

    }
}
