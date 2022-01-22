using System.Collections.Generic;

using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.KeyboardManager
{
    public class KeyboardConfigurations
    {
        [JsonProperty("value")]
        public List<string> Value { get; set; }
    }
}