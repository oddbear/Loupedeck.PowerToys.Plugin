using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class CameraOverlayImagePath
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}