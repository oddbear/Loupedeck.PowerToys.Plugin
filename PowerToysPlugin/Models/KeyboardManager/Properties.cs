using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.KeyboardManager
{
    public class Properties
    {
        [JsonProperty("activeConfiguration")]
        public ActiveConfiguration ActiveConfiguration { get; set; }

        [JsonProperty("keyboardConfigurations")]
        public KeyboardConfigurations KeyboardConfigurations { get; set; }
    }
}