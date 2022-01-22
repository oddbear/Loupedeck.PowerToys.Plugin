using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class MuteMicrophoneHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}