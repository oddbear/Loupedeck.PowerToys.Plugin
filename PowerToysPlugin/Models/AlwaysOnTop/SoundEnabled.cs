using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class SoundEnabled
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}