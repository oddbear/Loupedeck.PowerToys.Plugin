using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MouseHighlighter
{
    public class HighlightRadius
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}