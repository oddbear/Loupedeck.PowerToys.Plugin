using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class PastePlainService : BaseSettingsService
    {
        public PastePlainService()
            : base("PastePlain")
        {
            //
        }

        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "ActivationShortcut");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
