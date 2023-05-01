using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Models.VideoConference;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class VideoConferenceService : BaseSettingsService<VideoConferenceSettings>
    {
        public VideoConferenceService()
            : base("Video Conference")
        {
            //
        }
        
        public void Activate(MuteOptions muteOptions)
        {
            var shortcut = GetMuteShortcuts(muteOptions);
            if (shortcut is null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }

        private IKeyboardShortcut GetMuteShortcuts(MuteOptions muteOptions)
        {
            var settings = GetSettings();
            if (settings == null)
                return null;

            switch (muteOptions)
            {
                case MuteOptions.Camera:
                    return GetProperties<MuteCameraHotkey>("mute_camera_hotkey")?.Value;
                case MuteOptions.Microphone:
                    return GetProperties<MuteMicrophoneHotkey>("mute_microphone_hotkey")?.Value;
                case MuteOptions.CameraMicrophone:
                default:
                    return GetProperties<MuteCameraAndMicrophoneHotkey>("mute_camera_and_microphone_hotkey")?.Value;
            }
        }
    }

    public enum MuteOptions
    {
        Camera,
        Microphone,
        CameraMicrophone
    }
}
