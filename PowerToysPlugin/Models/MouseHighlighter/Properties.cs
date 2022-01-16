using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.MouseHighlighter
{
    public class Properties
    {
        [JsonProperty("activation_shortcut")]
        public ActivationShortcut ActivationShortcut { get; set; }

        [JsonProperty("left_button_click_color")]
        public LeftButtonClickColor LeftButtonClickColor { get; set; }

        [JsonProperty("right_button_click_color")]
        public RightButtonClickColor RightButtonClickColor { get; set; }

        [JsonProperty("highlight_opacity")]
        public HighlightOpacity HighlightOpacity { get; set; }

        [JsonProperty("highlight_radius")]
        public HighlightRadius HighlightRadius { get; set; }

        [JsonProperty("highlight_fade_delay_ms")]
        public HighlightFadeDelayMs HighlightFadeDelayMs { get; set; }

        [JsonProperty("highlight_fade_duration_ms")]
        public HighlightFadeDurationMs HighlightFadeDurationMs { get; set; }
    }
}