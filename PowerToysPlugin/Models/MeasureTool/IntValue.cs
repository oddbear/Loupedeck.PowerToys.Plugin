using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MeasureTool
{
    public class IntValue
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}