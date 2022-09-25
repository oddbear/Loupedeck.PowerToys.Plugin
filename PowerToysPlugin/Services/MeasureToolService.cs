using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.MeasureTool;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class MeasureToolService : BaseSettingsService<MeasureToolSettings>
    {
        public MeasureToolService()
            : base("Measure Tool")
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
