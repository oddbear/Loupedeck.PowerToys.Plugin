using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ColorPicker
{
    public class Visiblecolorformats
    {
        [JsonProperty("HEX")]
        public bool HEX { get; set; }

        [JsonProperty("RGB")]
        public bool RGB { get; set; }

        [JsonProperty("HSL")]
        public bool HSL { get; set; }

        [JsonProperty("HSV")]
        public bool HSV { get; set; }

        [JsonProperty("CMYK")]
        public bool CMYK { get; set; }

        [JsonProperty("HSB")]
        public bool HSB { get; set; }

        [JsonProperty("HSI")]
        public bool HSI { get; set; }

        [JsonProperty("HWB")]
        public bool HWB { get; set; }

        [JsonProperty("NCol")]
        public bool NCol { get; set; }

        [JsonProperty("CIELAB")]
        public bool CIELAB { get; set; }

        [JsonProperty("CIEXYZ")]
        public bool CIEXYZ { get; set; }

        [JsonProperty("VEC4")]
        public bool VEC4 { get; set; }

        [JsonProperty("Decimal")]
        public bool Decimal { get; set; }
    }
}