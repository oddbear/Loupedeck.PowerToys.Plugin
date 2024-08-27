using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace Loupedeck.PowerToysPlugin.Helpers
{
    public static class ProcessHelper
    {
        private static readonly Thread _thread;
        private static readonly ConcurrentDictionary<string, Action<bool>> _processNames = new ConcurrentDictionary<string, Action<bool>>();
        
        static ProcessHelper()
        {
            _thread = new Thread(Worker) {IsBackground = true};
            _thread.Start();
        }

        public static void Register(string processName, Action<bool> action)
        {
            _processNames.TryAdd(processName, action);
        }

        private static void Worker()
        {
            //PowerToys.AlwaysOnTop: Exits
            //PowerToys.FancyZones: Exits
            //PowerToys.KeyboardManagerEngine: Exits
            //PowerToys.PowerLauncher: Exits
            //
            //PowerToys.Awake: Still running after turning off
            //PowerToys.ColorPickerUI: Still running after turning off
            //
            //Video Conference Mute: No process
            //Mouse Utilities: No process
            while (true)
            {
                foreach (var processName in _processNames.Keys)
                {
                    var isRunning = Process.GetProcessesByName(processName).Length > 0;
                    _processNames[processName].Invoke(isRunning);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
