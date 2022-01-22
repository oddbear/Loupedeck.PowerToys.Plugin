using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin
{
    public class PowerToysPlugin : Plugin
    {
        public AlwaysOnTopService AlwaysOnTopService { get; }
        public AwakeService AwakeService { get; }
        public ColorPickerService ColorPickerService { get; }
        public FancyZonesService FancyZonesService { get; }
        public KeyboardManagerService KeyboardManagerService { get; }
        public MouseHighlighterService MouseHighlighterService { get; }
        public PowerToysRunService PowerToysRunService { get; }
        public ShortcutGuideService ShortcutGuideService { get; }
        public VideoConferenceService VideoConferenceService { get; }

        public override bool HasNoApplication => true;
        public override bool UsesApplicationApiOnly => true;

        public PowerToysPlugin()
        {
            AlwaysOnTopService = new AlwaysOnTopService();
            AwakeService = new AwakeService();
            ColorPickerService = new ColorPickerService();
            FancyZonesService = new FancyZonesService();
            KeyboardManagerService = new KeyboardManagerService();
            MouseHighlighterService = new MouseHighlighterService();
            PowerToysRunService = new PowerToysRunService();
            ShortcutGuideService = new ShortcutGuideService();
            VideoConferenceService = new VideoConferenceService();
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
            FancyZonesService.Dispose();
            KeyboardManagerService.Dispose();
            MouseHighlighterService.Dispose();
            PowerToysRunService.Dispose();
            ShortcutGuideService.Dispose();
            VideoConferenceService.Dispose();
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
