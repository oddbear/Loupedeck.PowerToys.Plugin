using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.FancyZones
{
    public class FancyzonesEditorHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}