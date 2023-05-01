using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PastePlain
{
    public class Properties
    {
        [JsonProperty("ActivationShortcut")]
        public ActivationShortcut ActivationShortcut { get; set; }
    }
}
