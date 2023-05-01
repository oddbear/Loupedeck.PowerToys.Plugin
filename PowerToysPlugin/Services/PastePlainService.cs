using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Models.PastePlain;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class PastePlainService : BaseSettingsService<PastePlainSettings>
    {
        public PastePlainService()
            : base("PastePlain")
        {
            //
        }

        public void Activate()
        {
            var shortcut = GetProperties<ActivationShortcut>("ActivationShortcut");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
