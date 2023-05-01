using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.Awake
{
    class AwakeKeepScreenOnToggleCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private AwakeService _service;

        public AwakeKeepScreenOnToggleCommand()
            : base("Toggle Keep screen on",
                "Toggles Keep screen on",
                "Awake")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.AwakeService;
            if (_service is null)
                return false;
            
            _service.KeepDisplayOn_ChangedEvent += base.ActionImageChanged;

            return true;
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _service.Toggle();
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = _service.KeepDisplayOnState()
                    ? "Loupedeck.PowerToysPlugin.Resources.Modules.Awake.on-80.png"
                    : "Loupedeck.PowerToysPlugin.Resources.Modules.Awake.off-80.png";

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
            var state = _service.KeepDisplayOnState() ? "On" : "Off";
            return $"Awake: {state}";
        }
    }
}
