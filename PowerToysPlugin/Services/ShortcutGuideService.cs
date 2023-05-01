using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.ShortcutGuide;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class ShortcutGuideService : BaseSettingsService<ShortcutGuideSettings>
    {
        public ShortcutGuideService()
            : base("Shortcut Guide")
        {
            //
        }

        public void Activate()
        {
            var shortcut = GetProperties<OpenShortcutguide>("open_shortcutguide");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}