using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class ExcludedApps
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}