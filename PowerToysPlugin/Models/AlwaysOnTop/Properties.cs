using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.AlwaysOnTop
{
    public class Properties
    {
        [JsonProperty("hotkey")]
        public Hotkey Hotkey { get; set; }

        [JsonProperty("frame-enabled")]
        public FrameEnabled FrameEnabled { get; set; }

        [JsonProperty("frame-thickness")]
        public FrameThickness FrameThickness { get; set; }

        [JsonProperty("frame-color")]
        public FrameColor FrameColor { get; set; }

        [JsonProperty("sound-enabled")]
        public SoundEnabled SoundEnabled { get; set; }

        [JsonProperty("do-not-activate-on-game-mode")]
        public DoNotActivateOnGameMode DoNotActivateOnGameMode { get; set; }

        [JsonProperty("excluded-apps")]
        public ExcludedApps ExcludedApps { get; set; }
    }
}