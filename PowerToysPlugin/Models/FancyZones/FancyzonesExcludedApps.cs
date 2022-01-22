using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesExcludedApps
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}