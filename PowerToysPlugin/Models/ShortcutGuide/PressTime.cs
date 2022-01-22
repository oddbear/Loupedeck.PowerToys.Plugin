using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class PressTime
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}