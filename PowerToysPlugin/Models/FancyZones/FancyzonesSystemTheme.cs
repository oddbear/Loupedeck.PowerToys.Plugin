using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesSystemTheme
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}