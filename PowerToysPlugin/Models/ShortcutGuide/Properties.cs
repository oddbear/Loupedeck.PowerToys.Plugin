using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.ShortcutGuide
{
    public class Properties
    {
        [JsonProperty("open_shortcutguide")]
        public OpenShortcutguide OpenShortcutguide { get; set; }

        [JsonProperty("overlay_opacity")]
        public OverlayOpacity OverlayOpacity { get; set; }

        [JsonProperty("use_legacy_press_win_key_behavior")]
        public UseLegacyPressWinKeyBehavior UseLegacyPressWinKeyBehavior { get; set; }

        [JsonProperty("press_time")]
        public PressTime PressTime { get; set; }

        [JsonProperty("theme")]
        public Theme Theme { get; set; }

        [JsonProperty("disabled_apps")]
        public DisabledApps DisabledApps { get; set; }
    }
}