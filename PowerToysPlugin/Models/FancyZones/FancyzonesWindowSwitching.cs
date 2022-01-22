using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesWindowSwitching
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}