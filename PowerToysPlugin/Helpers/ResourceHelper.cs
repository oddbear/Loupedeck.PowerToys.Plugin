using System;
using System.IO;

namespace Loupedeck.PowerToysPlugin.Helpers
{
    public static class ResourceHelper
    {
        public static BitmapImage GetBackgroundImage(string path)
        {
#if DEBUG
            try
            {
                //Just a helper method to read from disk instead of EmbeddedResources while debugging.
                var diskPath = GetDebugFilePath(path);

                var bytes = File.ReadAllBytes(diskPath);

                return new BitmapImage(bytes);
            }
            catch
            {
                return EmbeddedResources.ReadImage(path);
            }
#else
            return EmbeddedResources.ReadImage(path);
#endif
        }
        
        private static string GetDebugFilePath(string path)
        {
            //Basepath might be different for other developers (not easy to determine this when debug build is in another folder).
            var basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "git");

            var iconStart = "Loupedeck.PowerToysPlugin.Resources.Icons.";
            var moduleStart = "Loupedeck.PowerToysPlugin.Resources.Modules.";
            if (path.StartsWith(iconStart))
            {
                var relativePath = @"Loupedeck.PowerToys.Plugin\PowerToysPlugin\Resources\Icons";
                var fileName = path.Substring(iconStart.Length);
                return Path.Combine(basePath, relativePath, fileName);
            }
            else
            {
                var relativePath = @"Loupedeck.PowerToys.Plugin\PowerToysPlugin\Resources\Modules";
                path = path.Substring(moduleStart.Length);
                var dot = path.IndexOf('.');
                var module = path.Substring(0, dot);
                var fileName = path.Substring(dot + 1);
                return Path.Combine(basePath, relativePath, module, fileName);
            }
        }
    }
}
