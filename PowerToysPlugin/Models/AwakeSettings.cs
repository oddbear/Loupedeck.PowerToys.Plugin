using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models
{
    public class AwakeProperties
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

    public class AwakeSettings
    {
        [JsonProperty("properties")]
        public AwakeProperties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }


}
