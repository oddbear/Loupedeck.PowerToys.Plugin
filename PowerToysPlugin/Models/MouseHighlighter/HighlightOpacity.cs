using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MouseHighlighter
{
    public class HighlightOpacity
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}