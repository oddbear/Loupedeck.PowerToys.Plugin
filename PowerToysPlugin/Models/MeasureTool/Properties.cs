using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MeasureTool
{
    public class Properties
    {
        [JsonProperty("ActivationShortcut")]
        public ActivationShortcut ActivationShortcut { get; set; }

        [JsonProperty("ContinuousCapture")]
        public BoolValue ContinuousCapture { get; set; }

        [JsonProperty("DrawFeetOnCross")]
        public BoolValue DrawFeetOnCross { get; set; }

        [JsonProperty("PerColorChannelEdgeDetection")]
        public BoolValue PerColorChannelEdgeDetection { get; set; }

        [JsonProperty("UnitsOfMeasure")]
        public IntValue UnitsOfMeasure { get; set; }

        [JsonProperty("PixelTolerance")]
        public IntValue PixelTolerance { get; set; }

        [JsonProperty("MeasureCrossColor")]
        public StringValue MeasureCrossColor { get; set; }
    }
}