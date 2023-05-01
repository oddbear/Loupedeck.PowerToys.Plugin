using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.PowerToysRun;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class PowerToysRunService : BaseSettingsService<PowerToysRunSettings>
    {
        public PowerToysRunService()
            : base("PowerToys Run")
        {
            ProcessHelper.Register("PowerToys.PowerLauncher", ProcessIsRunning);
        }

        private void ProcessIsRunning(bool isRunning)
        {
            //TODO: Implement.
        }

        public void Activate()
        {
            var shortcut = GetProperties<OpenPowerlauncher>("open_powerlauncher");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
