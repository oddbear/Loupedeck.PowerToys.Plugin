using Loupedeck.PowerToysPlugin.Models.ColorPicker;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.ColorPicker
{
    class ColorPickerActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private ColorPickerService _service;
        private ColorPickerSettings _currentSettings;

        public ColorPickerActivateCommand()
            : base("Activate ColorPicker",
                "Presses the assigned keyboard shortcuts to activate.",
                "ColorPicker")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.ColorPickerService;
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
