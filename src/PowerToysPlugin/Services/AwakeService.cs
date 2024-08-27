using System;
using System.IO;

using Loupedeck.PowerToysPlugin.Services.Shared;

namespace Loupedeck.PowerToysPlugin.Services
{
    public class AwakeService : BaseSettingsService, IDisposable
    {
        private readonly FileSystemWatcher _watcher;
        private bool? _cachedKeepDisplayOn;

        public event Action KeepDisplayOn_ChangedEvent;

        public AwakeService()
            : base("Awake")
        {
            var location = GetSettingsPath();
            var directory = Path.GetDirectoryName(location);
            var fileName = Path.GetFileName(location);

            if (Directory.Exists(directory))
            {
                _watcher = new FileSystemWatcher(directory, fileName);
                _watcher.EnableRaisingEvents = true;
                _watcher.Changed += WatcherOnChanged;
            }
        }
        public void Toggle()
        {
            var keepDisplayOn = KeepDisplayOnState();
            base.SetValue(!keepDisplayOn, "properties", "keepDisplayOn");
        }

        public bool KeepDisplayOnState()
        {
            if(_cachedKeepDisplayOn is null)
                _cachedKeepDisplayOn = base.GetValue<bool>("properties", "keepDisplayOn");
            
            return _cachedKeepDisplayOn.Value;
        }

        private void WatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            _cachedKeepDisplayOn = base.GetValue<bool>("properties", "keepDisplayOn");

            var handler = KeepDisplayOn_ChangedEvent;
            handler?.Invoke();
        }

        public void Dispose()
        {
            _watcher?.Dispose();
        }
    }
}
