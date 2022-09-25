using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MeasureTool
{
    public class StringValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}