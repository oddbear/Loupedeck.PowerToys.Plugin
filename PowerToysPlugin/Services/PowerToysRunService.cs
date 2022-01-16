using System.Collections.Generic;

using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.PowerToysRun;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class PowerToysRunService : BaseSettingsService<PowerToysRunSettings>
    {
        public PowerToysRunService()
            : base("PowerToys Run")
        {
            //
        }

        public void Activate()
        {
            var settings = GetSettings();
            var shortcut = settings.Properties.OpenPowerlauncher;

            var keys = new List<byte>();

            if (shortcut.Win)
                keys.Add(KeyboardHelper.LeftWin);

            if (shortcut.Alt)
                keys.Add(KeyboardHelper.Alt);

            if (shortcut.Shift)
                keys.Add(KeyboardHelper.LeftShift);

            if (shortcut.Ctrl)
                keys.Add(KeyboardHelper.Ctrl);

            keys.Add((byte)shortcut.Code); //Ex. 0x43 -> 67 -> C

            KeyboardHelper.SendKeys(keys);
        }
    }
}
