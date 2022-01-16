using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.Awake
{
    public class Properties
    {
        [JsonProperty("awake_keep_display_on")]
        public bool AwakeKeepDisplayOn { get; set; }

        [JsonProperty("awake_mode")]
        public int AwakeMode { get; set; }

        [JsonProperty("awake_hours")]
        public int AwakeHours { get; set; }

        [JsonProperty("awake_minutes")]
        public int AwakeMinutes { get; set; }
    }
}