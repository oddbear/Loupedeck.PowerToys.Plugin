using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ColorPicker
{
    public class Changecursor
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}