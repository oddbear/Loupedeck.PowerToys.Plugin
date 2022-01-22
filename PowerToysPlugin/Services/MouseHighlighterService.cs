using Loupedeck.PowerToysPlugin.Helpers;
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
            var settings = GetSettings();
            var shortcut = settings.Properties.ActivationShortcut;
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
