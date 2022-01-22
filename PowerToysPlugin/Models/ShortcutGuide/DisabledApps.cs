using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class DisabledApps
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}