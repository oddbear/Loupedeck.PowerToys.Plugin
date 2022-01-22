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
            var settings = GetSettings();
            var shortcut = settings.Properties.OpenShortcutguide;
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}