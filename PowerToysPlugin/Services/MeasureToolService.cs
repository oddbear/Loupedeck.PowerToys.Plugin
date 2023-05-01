using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
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
            var shortcut = GetProperties<ActivationShortcut>("ActivationShortcut");
            if (shortcut == null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}
