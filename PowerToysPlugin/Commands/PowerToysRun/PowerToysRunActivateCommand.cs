using Loupedeck.PowerToysPlugin.Models.PowerToysRun;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.PowerToysRun
{
    class PowerToysRunActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private PowerToysRunService _service;
        private PowerToysRunSettings _currentSettings;

        public PowerToysRunActivateCommand()
            : base("Open Launcher", "Presses the assigned keyboard shortcuts to activate.", "PowerToys Run")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.PowerToysRunService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();

            return true;
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _service.Activate();
        }
    }
}
