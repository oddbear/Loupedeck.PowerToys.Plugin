using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.KeyboardManager;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class KeyboardManagerService : BaseSettingsService<KeyboardManagerSettings>
    {
        public KeyboardManagerService()
            : base("Keyboard Manager")
        {
            ProcessHelper.Register("PowerToys.KeyboardManagerEngine", ProcessIsRunning);
        }

        private void ProcessIsRunning(bool isRunning)
        {
            //TODO: Implement.
        }
    }
}
