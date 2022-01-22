using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesShowOnAllMonitors
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}