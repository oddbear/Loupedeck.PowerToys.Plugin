using Loupedeck.PowerToysPlugin.Models.TextExtractor;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.TextExtractor
{
    //TODO: Icons
    class TextExtractorCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private TextExtractorService _service;
        private TextExtractorSettings _currentSettings;

        public TextExtractorCommand()
            : base("Enable Text Extractor",
                "Enable Text Extractor",
                "TextExtractor")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.TextExtractorService;
            if (_service is null)
                return false;

            _currentSettings = _service.GetSettings();
            _service.SettingsUpdated += ServiceOnSettingsUpdated;

            return true;
        }

        private void ServiceOnSettingsUpdated(object sender, TextExtractorSettings e)
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
