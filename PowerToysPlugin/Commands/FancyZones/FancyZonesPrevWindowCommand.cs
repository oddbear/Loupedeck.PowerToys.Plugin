using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.FancyZones
{
    class FancyZonesPrevWindowCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private FancyZonesService _service;

        public FancyZonesPrevWindowCommand()
            : base("Prev Window",
                "Presses the assigned keyboard shortcuts to prev window.",
                "Fancy Zones")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.FancyZonesService;
            if (_service is null)
                return false;
            
            _service.IsRunningUpdated += ServiceOnIsRunningUpdated;

            return true;
        }

        private void ServiceOnIsRunningUpdated(object sender, bool e)
        {
            base.ActionImageChanged();
        }

        protected override void RunCommand(string actionParameter)
        {
            _service.PrevWindow();
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.FancyZones.prev-80.png";

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
            return "Prev Window";
        }
    }
}
