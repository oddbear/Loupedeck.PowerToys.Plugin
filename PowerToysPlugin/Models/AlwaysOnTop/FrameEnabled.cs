using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class FrameEnabled
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}