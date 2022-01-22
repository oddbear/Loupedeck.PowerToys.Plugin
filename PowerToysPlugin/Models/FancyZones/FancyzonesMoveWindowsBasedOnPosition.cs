using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesMoveWindowsBasedOnPosition
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}