using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Models.MouseHighlighter;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class MouseHighlighterService : BaseSettingsService<MouseHighlighterSettings>
    {
        public MouseHighlighterService()
            : base("MouseHighlighter")
        {
            //
        }

        public void Activate()
        {
            var shortcut = GetProperties<ActivationShortcut>("activation_shortcut");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
