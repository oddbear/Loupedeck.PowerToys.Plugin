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
#if DEBUG
        //TODO: Just for testing, marked as deprecated in PowerToys.
        public VideoConferenceService VideoConferenceService { get; }
#endif
        public MeasureToolService MeasureToolService { get; }
        public TextExtractorService TextExtractorService { get; }

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
#if DEBUG
            VideoConferenceService = new VideoConferenceService();
#endif
            MeasureToolService = new MeasureToolService();
            TextExtractorService = new TextExtractorService();
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
#if DEBUG
            VideoConferenceService.Dispose();
#endif
            MeasureToolService.Dispose();
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
