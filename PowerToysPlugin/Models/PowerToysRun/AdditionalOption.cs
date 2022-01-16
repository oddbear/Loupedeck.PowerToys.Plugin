using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PowerToysRun
{
    public class AdditionalOption
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("DisplayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("Value")]
        public bool Value { get; set; }
    }
}