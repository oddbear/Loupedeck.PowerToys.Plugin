using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PastePlain
{
    public class PastePlainSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
