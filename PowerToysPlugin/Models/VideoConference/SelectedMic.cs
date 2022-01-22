using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class SelectedMic
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}