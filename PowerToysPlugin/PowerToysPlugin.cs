using Loupedeck.PowerToysPlugin.Services;

namespace Loupedeck.PowerToysPlugin
{
    public class PowerToysPlugin : Plugin
    {
        public AwakeService AwakeService { get; set; }
        public ColorPickerService ColorPickerService { get; set; }

        public PowerToysPlugin()
        {
            AwakeService = new AwakeService();
            ColorPickerService = new ColorPickerService();
        }

        public override void Load()
        {
            //
        }

        public override void Unload()
        {
            AwakeService.Dispose();
        }
        
        public override void RunCommand(string commandName, string parameter)
        {
            //
        }

        public override void ApplyAdjustment(string adjustmentName, string parameter, int diff)
        {
            //
        }
    }
}
