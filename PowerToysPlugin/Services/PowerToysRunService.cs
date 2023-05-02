using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class PowerToysRunService : BaseSettingsService
    {
        public PowerToysRunService()
            : base("PowerToys Run")
        {
            //
        }
        
        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "open_powerlauncher");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
