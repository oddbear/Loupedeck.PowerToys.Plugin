using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class ColorPickerService : BaseSettingsService
    {
        public ColorPickerService()
            : base("ColorPicker")
        {
            //"C:\Users\oddbj\AppData\Local\Microsoft\PowerToys\ColorPicker\settings.json" Contains key presses to execute.
            //"C:\Program Files\PowerToys\modules\ColorPicker\PowerToys.ColorPickerUI.exe"
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
