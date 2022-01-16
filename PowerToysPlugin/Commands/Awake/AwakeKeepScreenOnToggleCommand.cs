using Loupedeck.PowerToysPlugin.Models.Awake;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.Awake
{
    class AwakeKeepScreenOnToggleCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private AwakeService _service;
        private AwakeSettings _currentSettings;

        public AwakeKeepScreenOnToggleCommand()
            : base("Toggle Keep screen on",
                "Toggles Keep screen on",
                "Awake")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.AwakeService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();
            _service.SettingsUpdated += AwakeServiceOnSettingsUpdated;

            return true;
        }

        private void AwakeServiceOnSettingsUpdated(object sender, AwakeSettings e)
        {
            _currentSettings = e;
            base.ActionImageChanged();
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _currentSettings.Properties.AwakeKeepDisplayOn = !_currentSettings.Properties.AwakeKeepDisplayOn;
            _service.UpdateSettings(_currentSettings);
            base.ActionImageChanged();
        }
        
        protected override string GetCommandDisplayName(string actionParameter, PluginImageSize imageSize)
        {
            var state = _currentSettings.Properties.AwakeKeepDisplayOn ? "On" : "Off";
            return $"Awake: {state}";
        }
    }
}
