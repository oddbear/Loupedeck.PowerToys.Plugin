using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class AlwaysOnTopService : BaseSettingsService
    {
        public AlwaysOnTopService()
            : base("AlwaysOnTop")
        {
            //
        }
        
        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "hotkey", "value");
            if (shortcut is null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
