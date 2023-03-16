using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.TextExtractor;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.TextExtractor
{
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

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.TextExtractor.icon-80.png";

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
            return "Text Extractor";
        }
    }
}
