using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands
{
    class ColorPickerActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private ColorPickerService _colorPickerService;

        public ColorPickerActivateCommand()
            : base("Activate", "Presses the assigned keyboard shortcuts to activate.", "ColorPicker")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _colorPickerService = _plugin.ColorPickerService;
            if (_colorPickerService is null)
                return false;

            return true;
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _colorPickerService.Activate();
        }
    }
}
