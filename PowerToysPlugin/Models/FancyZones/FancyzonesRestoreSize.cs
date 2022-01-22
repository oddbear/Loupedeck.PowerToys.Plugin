using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesRestoreSize
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}