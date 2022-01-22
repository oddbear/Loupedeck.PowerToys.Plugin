using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class ShortcutGuideSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}