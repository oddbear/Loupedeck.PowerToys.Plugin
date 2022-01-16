using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class DoNotActivateOnGameMode
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}