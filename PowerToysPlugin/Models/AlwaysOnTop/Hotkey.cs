using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class Hotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}