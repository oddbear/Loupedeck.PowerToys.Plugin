using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class MuteCameraHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}