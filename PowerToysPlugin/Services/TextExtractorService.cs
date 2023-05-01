using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Models.TextExtractor;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class TextExtractorService : BaseSettingsService<TextExtractorSettings>
    {
        public TextExtractorService()
            : base("TextExtractor")
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
