using System.Collections.Generic;

using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PowerToysRun
{
    public class PowerToysRunSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("plugins")]
        public List<Plugin> Plugins { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
