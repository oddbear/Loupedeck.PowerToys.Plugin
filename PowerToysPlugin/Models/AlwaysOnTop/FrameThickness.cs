using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class FrameThickness
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}