using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MouseHighlighter
{
    public class HighlightFadeDelayMs
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}