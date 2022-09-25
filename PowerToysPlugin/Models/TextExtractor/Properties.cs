using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.TextExtractor
{
    public class Properties
    {
        [JsonProperty("ActivationShortcut")]
        public ActivationShortcut ActivationShortcut { get; set; }
    }
}
