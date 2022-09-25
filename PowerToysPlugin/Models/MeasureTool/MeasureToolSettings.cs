using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MeasureTool
{
    public class MeasureToolSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
