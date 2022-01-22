using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class SelectedCamera
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}