using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesPrevTabHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}