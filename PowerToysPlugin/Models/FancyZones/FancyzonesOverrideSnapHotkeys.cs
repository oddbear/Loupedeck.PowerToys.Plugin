using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesOverrideSnapHotkeys
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}