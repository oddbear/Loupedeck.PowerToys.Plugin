using System.Collections.Generic;
using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models
{
    public class ColorPickerSettings
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class ActivationShortcut
    {
        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("ctrl")]
        public bool Ctrl { get; set; }

        [JsonProperty("alt")]
        public bool Alt { get; set; }

        [JsonProperty("shift")]
        public bool Shift { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class Changecursor
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

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

    public class Showcolorname
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class Properties
    {
        [JsonProperty("ActivationShortcut")]
        public ActivationShortcut ActivationShortcut { get; set; }

        [JsonProperty("changecursor")]
        public Changecursor Changecursor { get; set; }

        [JsonProperty("copiedcolorrepresentation")]
        public int Copiedcolorrepresentation { get; set; }

        [JsonProperty("activationaction")]
        public int Activationaction { get; set; }

        [JsonProperty("colorhistory")]
        public List<string> Colorhistory { get; set; }

        [JsonProperty("colorhistorylimit")]
        public int Colorhistorylimit { get; set; }

        [JsonProperty("visiblecolorformats")]
        public Visiblecolorformats Visiblecolorformats { get; set; }

        [JsonProperty("showcolorname")]
        public Showcolorname Showcolorname { get; set; }
    }
}
