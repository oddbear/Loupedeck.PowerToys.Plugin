using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class Theme
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}