using System;
using System.Diagnostics;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Loupedeck.PowerToysPlugin.Services.Shared
{
    public abstract class BaseSettingsService
    {
        protected readonly string _pathName;
        //private readonly FileSystemWatcher _watcher;
        private readonly JsonSerializerSettings _serializerSettings;
        
        public BaseSettingsService(string pathName)
        {
            _pathName = pathName;

            try
            {
                var location = GetSettingsPath();

                _serializerSettings = new JsonSerializerSettings { Error = HandleDeserializationError };
            }
            catch
            {
                // If the watcher fails... don't take down Loupedeck.
            }
        }

        private void HandleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            Trace.TraceError(currentError);

            errorArgs.ErrorContext.Handled = true;
        }

        private JToken GetToken(JObject cursor, params string[] properties)
        {
            foreach (var property in properties)
            {
                var jProperty = cursor?.Property(property);

                //Not done traversing:
                if (jProperty?.Value is JObject jObject)
                {
                    cursor = jObject;
                    continue;
                }

                //Null, not possible to come further:
                if (jProperty?.Value is null)
                    return default;

                //Value, not possible to come further:
                if (jProperty?.Value is JValue value)
                    return value;
            }

            //Done traversing:
            return cursor;
        }

        private string GetSettingsString()
        {
            try
            {
                var location = GetSettingsPath();

                //We will try to read, but not lock the file:
                using (var fileStream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var streamReader = new StreamReader(fileStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch
            {
                return default;
            }
        }

        public string GetSettingsPath()
        {
            var localAppDataLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(localAppDataLocation, @"Microsoft\PowerToys", _pathName, "settings.json");
        }

        public TValue GetValue<TValue>(params string[] properties)
        {
            try
            {
                var json = GetSettingsString();
                var cursor = JsonConvert.DeserializeObject<JObject>(json);
                var token = GetToken(cursor, properties);
                switch (token)
                {
                    case JObject jObject:
                        return jObject.ToObject<TValue>();
                    case JValue jValue:
                        return jValue.ToObject<TValue>();
                    default:
                        return default;
                }
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.Message);
                return default;
            }
        }

        public void SetValue<TValue>(TValue value, params string[] properties)
        {
            try
            {
                var json = GetSettingsString();
                var cursor = JsonConvert.DeserializeObject<JObject>(json, _serializerSettings);
                var token = GetToken(cursor, properties);

                switch (token)
                {
                    case null:
                        throw new InvalidOperationException("Token was not found.");
                    //This shall not be serialized (then it will be "false" instead of false).
                    case JValue jValue:
                        jValue.Value = value;
                        break;
                    //The object in the json, should always have a property as parent (have not seen any arrays yet):
                    case JObject jObject when jObject.Parent is JProperty jProperty:
                        jProperty.Value = JsonConvert.SerializeObject(value);
                        break;
                }

                var location = GetSettingsPath();
                var updatedJson = JsonConvert.SerializeObject(cursor);
                File.WriteAllText(location, updatedJson); //Try Writing updated value.
            }
            catch (Exception exception)
            {
                Trace.TraceError(exception.Message);
            }
        }
    }
}
