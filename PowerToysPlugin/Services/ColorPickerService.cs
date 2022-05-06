using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.ColorPicker;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class ColorPickerService : BaseSettingsService<ColorPickerSettings>
    {
        public ColorPickerService()
            : base("ColorPicker")
        {
            //"C:\Users\oddbj\AppData\Local\Microsoft\PowerToys\ColorPicker\settings.json" Contains key presses to execute.
            //"C:\Program Files\PowerToys\modules\ColorPicker\PowerToys.ColorPickerUI.exe"
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
