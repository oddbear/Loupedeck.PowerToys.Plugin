using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin.Commands.VideoConference
{
    class MuteMicrophoneCommand : PluginDynamicCommand
    {
        private PowerToysPlugin _plugin;
        private VideoConferenceService _service;

        public MuteMicrophoneCommand()
            : base("Toggle Mute Microphone",
                "Toggles Mute Microphone",
                "VideoConference")
        {
            //
        }

        protected override bool OnLoad()
        {
            _plugin = base.Plugin as PowerToysPlugin;
            if (_plugin is null)
                return false;

            _service = _plugin.VideoConferenceService;
            if (_service is null)
                return false;
            
            return true;
        }
        
        protected override void RunCommand(string actionParameter)
        {
            _service.Activate(MuteOptions.Microphone);
        }

        protected override BitmapImage GetCommandImage(string actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))
            {
                bitmapBuilder.Clear(new BitmapColor(0x00, 0x19, 0x7C));

                var path = "Loupedeck.PowerToysPlugin.Resources.Modules.VideoConference.icon-80.png";

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
            return "Mute Microphone";
        }
    }
}
