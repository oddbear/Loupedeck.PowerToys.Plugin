using System.Collections.Generic;

using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.PowerToysRun
{
    public class Plugin
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("IsGlobal")]
        public bool IsGlobal { get; set; }

        [JsonProperty("ActionKeyword")]
        public string ActionKeyword { get; set; }

        [JsonProperty("IconPathDark")]
        public string IconPathDark { get; set; }

        [JsonProperty("IconPathLight")]
        public string IconPathLight { get; set; }

        [JsonProperty("AdditionalOptions")]
        public List<AdditionalOption> AdditionalOptions { get; set; }
    }
}