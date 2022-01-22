using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class ToolbarMonitor
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}