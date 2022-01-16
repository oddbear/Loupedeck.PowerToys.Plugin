using System;
using System.IO;

using Newtonsoft.Json;

namespace Loupedeck.PowerToysPlugin.Services
{
    public abstract class BaseSettingsService<TSettingsModel> : IDisposable
    {
        private readonly string _pathName;
        private readonly FileSystemWatcher _watcher;

        public event EventHandler<TSettingsModel> SettingsUpdated;

        public BaseSettingsService(string pathName)
        {
            _pathName = pathName;

            var location = GetSettingsPath();
            var directory = Path.GetDirectoryName(location);
            var fileName = Path.GetFileName(location);

            _watcher = new FileSystemWatcher(directory, fileName);
            _watcher.Changed += WatcherOnChanged;
        }

        public TSettingsModel GetSettings()
        {
            var location = GetSettingsPath();
            var json = File.ReadAllText(location);
            return JsonConvert.DeserializeObject<TSettingsModel>(json);
        }

        public void UpdateSettings(TSettingsModel settings)
        {
            var location = GetSettingsPath();
            var json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(location, json);
        }

        private void WatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            var settings = GetSettings();
            var handler = SettingsUpdated;
            handler?.Invoke(this, settings);
        }

        protected string GetSettingsPath()
        {
            var localAppDataLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(localAppDataLocation, @"Microsoft\PowerToys", _pathName, "settings.json");
        }

        public void Dispose() => _watcher?.Dispose();
    }
}
