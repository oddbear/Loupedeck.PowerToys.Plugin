using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesNextTabHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}