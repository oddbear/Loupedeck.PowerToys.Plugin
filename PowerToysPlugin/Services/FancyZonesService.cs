using System;

using Loupedeck.PowerToysPlugin.Helpers;
using Loupedeck.PowerToysPlugin.Models;
using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class FancyZonesService : BaseSettingsService
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
            var shortcut = base.GetValue<ActivationShortcut>("properties", "fancyzones_editor_hotkey", "value");
            if (shortcut is null)
                return;
            
            KeyboardHelper.SendKeys(shortcut);
        }
    }
}