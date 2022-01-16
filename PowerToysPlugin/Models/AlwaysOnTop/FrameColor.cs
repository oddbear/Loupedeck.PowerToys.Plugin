using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class FrameColor
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}