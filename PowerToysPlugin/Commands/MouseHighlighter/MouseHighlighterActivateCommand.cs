using Loupedeck.PowerToysPlugin.Models.MouseHighlighter;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.MouseHighlighter
{
    class MouseHighlighterActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private MouseHighlighterService _service;
        private MouseHighlighterSettings _currentSettings;

        public MouseHighlighterActivateCommand()
            : base("Activate Mouse Clicks",
                "Presses the assigned keyboard shortcuts to activate.",
                "Mouse Utilities")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.MouseHighlighterService;
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
