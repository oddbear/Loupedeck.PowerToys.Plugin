using Loupedeck.PowerToysPlugin.Models.AlwaysOnTop;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.AlwaysOnTop
{
    class AlwaysOnTopActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private AlwaysOnTopService _service;
        private AlwaysOnTopSettings _currentSettings;

        public AlwaysOnTopActivateCommand()
            : base("Activate Always On Top",
                "Presses the assigned keyboard shortcuts to activate current focused application always on top on/off.",
                "Always On Top")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.AlwaysOnTopService;
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
