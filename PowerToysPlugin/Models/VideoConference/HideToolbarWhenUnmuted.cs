using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class HideToolbarWhenUnmuted
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}