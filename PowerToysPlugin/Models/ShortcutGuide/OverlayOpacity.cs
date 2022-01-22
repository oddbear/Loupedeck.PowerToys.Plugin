using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class OverlayOpacity
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}