using System.Collections.Generic;

using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ColorPicker
{
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