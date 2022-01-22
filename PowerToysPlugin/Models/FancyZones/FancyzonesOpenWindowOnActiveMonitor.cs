using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesOpenWindowOnActiveMonitor
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}