using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class ToolbarPosition
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}