using Loupedeck.PowerToysPlugin.Helpers;
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
            if (_currentSettings is null)
                return;

            _currentSettings.Properties.AwakeKeepDisplayOn = !_currentSettings.Properties.AwakeKeepDisplayOn;
            _service.UpdateSettings(_currentSettings);
            base.ActionImageChanged();
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            if (_currentSettings is null)
                return null;

            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = _currentSettings.Properties.AwakeKeepDisplayOn
                    ? "Loupedeck.PowerToysPlugin.Resources.Modules.Awake.on-80.png"
                    : "Loupedeck.PowerToysPlugin.Resources.Modules.Awake.off-80.png";

                var background = ResourceHelper.GetBackgroundImage(path);
                bitmapBuilder.SetBackgroundImage(background);

                bitmapBuilder.Translate(0, 20);
                var text = GetCommandDisplayName(actionParameter, imageSize);
                bitmapBuilder.DrawText(text, BitmapColor.White, 10);

                return bitmapBuilder.ToImage();
            }
        }

        protected override string GetCommandDisplayName(string actionParameter, PluginImageSize imageSize)
        {
            var state = _currentSettings.Properties.AwakeKeepDisplayOn ? "On" : "Off";
            return $"Awake: {state}";
        }
    }
}
