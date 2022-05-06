using System;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            try
            {
                var location = GetSettingsPath();
                var directory = Path.GetDirectoryName(location);
                var fileName = Path.GetFileName(location);

                _watcher = new FileSystemWatcher(directory, fileName);
                _watcher.EnableRaisingEvents = true;
                _watcher.Changed += WatcherOnChanged;
            }
            catch
            {
                // If the watcher fails... don't take down Loupedeck.
            }
        }

        public TSettingsModel GetSettings()
        {
            try
            {
                var json = GetSettingsString();
                return JsonConvert.DeserializeObject<TSettingsModel>(json);
            }
            catch
            {
                return default;
            }
        }

        public void UpdateSettings(TSettingsModel settings)
        {
            try
            {
                var olsSettings = GetSettingsString();

                var oldJObject = JObject.Parse(olsSettings);
                var patchJObject = JObject.FromObject(settings);
                oldJObject.Merge(patchJObject);

                var patchedSettings = oldJObject.ToString();

                var location = GetSettingsPath();
                File.WriteAllText(location, patchedSettings);
            }
            catch (Exception e)
            {
                //User must try clicking again.
            }
        }

        private string GetSettingsString()
        {
            try
            {
                var location = GetSettingsPath();
                using (var fileStream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var streamReader = new StreamReader(fileStream))
                {
                    var json = streamReader.ReadToEnd();
                    return json;
                }
            }
            catch
            {
                return default;
            }
        }

        private void WatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            var settings = GetSettings();
            if (settings == null)
                return;

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
