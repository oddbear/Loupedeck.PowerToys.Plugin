using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesMouseSwitch
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}