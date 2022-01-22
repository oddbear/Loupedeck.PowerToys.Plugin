using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupedeck.PowerToysPlugin.Helpers
{
    public static class LogAnalyzerHelper
    {
        //private static readonly ConcurrentDictionary<string, Action<bool>> _processNames = new ConcurrentDictionary<string, Action<bool>>();

        private static readonly string _version = "v0.53.3"; //TODO: How does this change in next version?

        static LogAnalyzerHelper()
        {
            //
        }
        
        //public static void Register(string module, Action<bool> action)
        //{
        //    //v0.53.3
        //    //%local%\Microsoft\PowerToys\%Module%\ModuleInterface\Logs\%version%
        //    var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //    var logPath = Path.Combine(localAppData, @"Microsoft\PowerToys", module, @"ModuleInterface\Logs", _version);

        //    //Need to read back over multiple logfiles... system watcher for latest.
        //    //Can optimse to read back until latest known.

        //    var files = Directory.GetFiles(logPath, "*.txt");

        //    var _watcher = new FileSystemWatcher(directory, fileName);

        //    _processNames.TryAdd(processName, action);
        //}

        //public bool SearchLogs(string module)
        //{
        //    //v0.53.3
        //    //%local%\Microsoft\PowerToys\%Module%\ModuleInterface\Logs\%version%
        //    var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //    var logPath = Path.Combine(localAppData, @"Microsoft\PowerToys", module, @"ModuleInterface\Logs", _version);

        //    //Need to read back over multiple logfiles... system watcher for latest.
        //    //Can optimse to read back until latest known.

        //    var files = Directory.GetFiles(logPath, "*.txt");
        //}
    }

    public class LogSearcher
    {
        public string StartEntry { get; set; }

        public bool LastState { get; set; }
    }
}
