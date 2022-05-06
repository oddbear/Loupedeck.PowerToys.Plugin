using System;

using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models.FancyZones;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class FancyZonesService : BaseSettingsService<FancyZonesSettings>
    {
        public event EventHandler<bool> IsRunningUpdated;
        public bool IsRunning { get; private set; }

        public FancyZonesService()
            : base("FancyZones")
        {
            ProcessHelper.Register("PowerToys.FancyZones", ProcessIsRunning);
        }

        private void ProcessIsRunning(bool isRunning)
        {
            if (IsRunning != isRunning)
                IsRunningUpdated?.Invoke(this, isRunning);

            IsRunning = isRunning;
        }

        public void Activate()
        {
            var settings = GetSettings();
            if (settings == null)
                return;

            var shortcut = settings.Properties.FancyzonesEditorHotkey.Value;
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}