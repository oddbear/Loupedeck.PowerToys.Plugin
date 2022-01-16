using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ColorPicker
{
    public class ColorPickerSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
