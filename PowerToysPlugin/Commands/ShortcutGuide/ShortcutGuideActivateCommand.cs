using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.ShortcutGuide
{
    class ShortcutGuideActivateCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private ShortcutGuideService _service;

        public ShortcutGuideActivateCommand()
            : base("Open Shortcut Guide",
                "Presses the assigned keyboard shortcuts to activate.",
                "Shortcut Guide")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.ShortcutGuideService;
            if (_service is null)
                return false;
            
            return true;
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

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.ShortcutGuide.icon-80.png";

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
            return "Shortcut Guide";
        }
    }
}
