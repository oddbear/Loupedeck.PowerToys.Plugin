using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Models.VideoConference
{
    public class Properties
    {
        [JsonProperty("mute_camera_and_microphone_hotkey")]
        public MuteCameraAndMicrophoneHotkey MuteCameraAndMicrophoneHotkey { get; set; }

        [JsonProperty("mute_microphone_hotkey")]
        public MuteMicrophoneHotkey MuteMicrophoneHotkey { get; set; }

        [JsonProperty("mute_camera_hotkey")]
        public MuteCameraHotkey MuteCameraHotkey { get; set; }

        [JsonProperty("selected_camera")]
        public SelectedCamera SelectedCamera { get; set; }

        [JsonProperty("selected_mic")]
        public SelectedMic SelectedMic { get; set; }

        [JsonProperty("toolbar_position")]
        public ToolbarPosition ToolbarPosition { get; set; }

        [JsonProperty("toolbar_monitor")]
        public ToolbarMonitor ToolbarMonitor { get; set; }

        [JsonProperty("camera_overlay_image_path")]
        public CameraOverlayImagePath CameraOverlayImagePath { get; set; }

        [JsonProperty("theme")]
        public object Theme { get; set; }

        [JsonProperty("hide_toolbar_when_unmuted")]
        public HideToolbarWhenUnmuted HideToolbarWhenUnmuted { get; set; }
    }
}