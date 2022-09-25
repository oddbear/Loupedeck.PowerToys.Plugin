using Loupedeck.PowerToysPlugin.Models.VideoConference;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.VideoConference
{
    //TODO: Icons
    //TODO: Does not work
    class MuteCameraAndMicrophoneCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private VideoConferenceService _service;
        private VideoConferenceSettings _currentSettings;

        public MuteCameraAndMicrophoneCommand()
            : base("Toggle Mute Camera & Microphone",
                "Toggles Mute Camera & Microphone",
                "VideoConference")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.VideoConferenceService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();
            _service.SettingsUpdated += ServiceOnSettingsUpdated;

            return true;
        }

        private void ServiceOnSettingsUpdated(object sender, VideoConferenceSettings e)
        {
            _currentSettings = e;
            base.ActionImageChanged();
        }

        protected override void RunCommand(string actionParameter)
        {
            _service.Activate(MuteOptions.CameraMicrophone);
        }
    }
}