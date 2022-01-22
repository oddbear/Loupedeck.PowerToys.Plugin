using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesQuickLayoutSwitch
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}