using Loupedeck.PowerToysPlugin.Models.MeasureTool;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.MeasureTool
{
    //TODO: Icons
    class MeasureToolCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private MeasureToolService _service;
        private MeasureToolSettings _currentSettings;

        public MeasureToolCommand()
            : base("Enable Screen Ruler",
                "Enable Screen Ruler",
                "MeasureTool")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.MeasureToolService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();
            _service.SettingsUpdated += ServiceOnSettingsUpdated;

            return true;
        }

        private void ServiceOnSettingsUpdated(object sender, MeasureToolSettings e)
        {
            _currentSettings = e;
            base.ActionImageChanged();
        }

        protected override void RunCommand(string actionParameter)
        {
            _service.Activate();
        }
    }
}
