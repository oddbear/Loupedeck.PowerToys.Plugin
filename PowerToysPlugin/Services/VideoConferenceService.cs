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
                    return settings.Properties.MuteCameraHotkey.Value;
                case MuteOptions.Microphone:
                    return settings.Properties.MuteMicrophoneHotkey.Value;
                case MuteOptions.CameraMicrophone:
                    return settings.Properties.MuteCameraAndMicrophoneHotkey.Value;
                default:
                    return settings.Properties.MuteCameraAndMicrophoneHotkey.Value;
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
