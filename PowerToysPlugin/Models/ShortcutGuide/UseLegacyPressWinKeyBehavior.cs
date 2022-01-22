using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class UseLegacyPressWinKeyBehavior
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}