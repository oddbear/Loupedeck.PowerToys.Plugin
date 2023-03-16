using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.MeasureTool;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.MeasureTool
{
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

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.MeasureTool.icon-80.png";

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
            return "Screen Ruler";
        }
    }
}
