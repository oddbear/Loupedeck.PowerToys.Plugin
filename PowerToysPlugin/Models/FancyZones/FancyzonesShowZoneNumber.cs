using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesShowZoneNumber
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}