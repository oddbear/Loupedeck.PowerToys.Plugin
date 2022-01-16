using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands
{
    class AwakeKeepScreenOnToggleCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private AwakeService _awakeService;
        private AwakeSettings _currentSettings;

        public AwakeKeepScreenOnToggleCommand()
            : base("Toggle Keep screen on", "Toggles Keep screen on", "Awake")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _awakeService = _plugin.AwakeService;
            if (_awakeService is null)
                return false;

            _currentSettings = _awakeService.GetSettings();
            _awakeService.SettingsUpdated += AwakeServiceOnSettingsUpdated;

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
            _awakeService.UpdateSettings(_currentSettings);
            base.ActionImageChanged();
        }
        
        protected override string GetCommandDisplayName(string actionParameter, PluginImageSize imageSize)
        {
            var state = _currentSettings.Properties.AwakeKeepDisplayOn ? "On" : "Off";
            return $"Awake: {state}";
        }
    }
}
