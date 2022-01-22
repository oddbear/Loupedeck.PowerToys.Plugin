using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesZoneSetChangeMoveWindows
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}