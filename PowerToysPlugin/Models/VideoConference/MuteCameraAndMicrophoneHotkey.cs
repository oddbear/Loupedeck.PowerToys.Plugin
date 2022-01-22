using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class MuteCameraAndMicrophoneHotkey
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }
}