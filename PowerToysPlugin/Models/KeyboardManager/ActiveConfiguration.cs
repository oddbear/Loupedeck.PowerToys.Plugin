using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.KeyboardManager
{
    public class ActiveConfiguration
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
