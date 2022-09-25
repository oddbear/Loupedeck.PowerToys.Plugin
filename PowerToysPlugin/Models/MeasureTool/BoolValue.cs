using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MeasureTool
{
    public class BoolValue
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}