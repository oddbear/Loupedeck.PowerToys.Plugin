using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesMoveWindowAcrossMonitors
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}