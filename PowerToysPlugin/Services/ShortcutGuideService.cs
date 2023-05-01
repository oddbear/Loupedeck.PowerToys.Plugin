using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class ShortcutGuideService : BaseSettingsService
    {
        public ShortcutGuideService()
            : base("Shortcut Guide")
        {
            //
        }

        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "open_shortcutguide");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}