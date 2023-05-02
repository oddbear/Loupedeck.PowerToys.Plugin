using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class MouseHighlighterService : BaseSettingsService
    {
        public MouseHighlighterService()
            : base("MouseHighlighter")
        {
            //
        }

        public void Activate()
        {
            var shortcut = base.GetValue<ActivationShortcut>("properties", "activation_shortcut");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
