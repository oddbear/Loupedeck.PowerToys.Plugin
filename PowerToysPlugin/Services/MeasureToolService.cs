using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class MeasureToolService : BaseSettingsService
    {
        public MeasureToolService()
            : base("Measure Tool")
        {
            //
        }

        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "ActivationShortcut");
            if (shortcut is null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
