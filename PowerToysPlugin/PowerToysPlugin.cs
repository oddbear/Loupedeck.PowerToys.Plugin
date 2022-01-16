using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin
{
    public class PowerToysPlugin : Plugin
    {
        public AlwaysOnTopService AlwaysOnTopService { get; }
        public AwakeService AwakeService { get; }
        public ColorPickerService ColorPickerService { get; }
        public MouseHighlighterService MouseHighlighterService { get; }
        public PowerToysRunService PowerToysRunService { get; }

        public override bool HasNoApplication => true;
        public override bool UsesApplicationApiOnly => true;

        public PowerToysPlugin()
        {
            AlwaysOnTopService = new AlwaysOnTopService();
            AwakeService = new AwakeService();
            ColorPickerService = new ColorPickerService();
            MouseHighlighterService = new MouseHighlighterService();
            PowerToysRunService = new PowerToysRunService();
        }

        public override void Load()
        {
            LoadPluginIcons();
        }

        public override void Unload()
        {
            AlwaysOnTopService.Dispose();
            AwakeService.Dispose();
            ColorPickerService.Dispose();
            MouseHighlighterService.Dispose();
            PowerToysRunService.Dispose();
        }
        
        public override void RunCommand(string commandName, string parameter)
        {
            //
        }

        public override void ApplyAdjustment(string adjustmentName, string parameter, int diff)
        {
            //
        }

        private void LoadPluginIcons()
        {
            //var resources = this.Assembly.GetManifestResourceNames();
            Info.Icon16x16 = EmbeddedResources.ReadImage("Loupedeck.PowerToysPlugin.Resources.Icons.icon-16.png");
            Info.Icon32x32 = EmbeddedResources.ReadImage("Loupedeck.PowerToysPlugin.Resources.Icons.icon-32.png");
            Info.Icon48x48 = EmbeddedResources.ReadImage("Loupedeck.PowerToysPlugin.Resources.Icons.icon-48.png");
            Info.Icon256x256 = EmbeddedResources.ReadImage("Loupedeck.PowerToysPlugin.Resources.Icons.icon-256.png");
        }
    }
}
