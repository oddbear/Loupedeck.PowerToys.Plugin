using Loupedeck.PowerToysPlugin.Helpers;
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
            var settings = GetSettings();
            if (settings == null)
                return;

            var shortcut = settings.Properties.ActivationShortcut;
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
