using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class VideoConferenceService : BaseSettingsService
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

        private ActivationShortcut GetMuteShortcuts(MuteOptions muteOptions)
        {
            switch (muteOptions)
            {
                case MuteOptions.Camera:
                    return base.GetValue<ActivationShortcut>("properties", "mute_camera_hotkey", "value");
                case MuteOptions.Microphone:
                    return base.GetValue<ActivationShortcut>("properties", "mute_microphone_hotkey", "value");
                case MuteOptions.CameraMicrophone:
                default:
                    return base.GetValue<ActivationShortcut>("properties", "mute_camera_and_microphone_hotkey", "value");
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
