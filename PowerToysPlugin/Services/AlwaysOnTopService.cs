using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.AlwaysOnTop;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class AlwaysOnTopService : BaseSettingsService<AlwaysOnTopSettings>
    {
        public AlwaysOnTopService()
            : base("AlwaysOnTop")
        {
            ProcessHelper.Register("PowerToys.AlwaysOnTop", ProcessIsRunning);
        }

        private void ProcessIsRunning(bool isRunning)
        {
            //TODO: Implement.
        }

        public void Activate()
        {
            var settings = GetSettings();
            var shortcut = settings.Properties.Hotkey.Value;
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
