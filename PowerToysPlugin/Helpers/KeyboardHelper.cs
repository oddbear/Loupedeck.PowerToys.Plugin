using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Loupedeck.PowerToysPlugin.Models;

namespace Loupedeck.PowerToysPlugin.Helpers
{
    public static class KeyboardHelper
    {
        //https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
        public const int LeftWin = 0x5B; //VK_LWIN
        public const int LeftShift = 0xA0; //VK_LSHIFT
        public const int Alt = 0x12; //VK_MENU
        public const int Ctrl = 0x11; //VK_CONTROL

        private const int KEYEVENTF_KEYUP = 0x02;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public static void SendKeys(IKeyboardShortcut shortcut)
        {
            if (shortcut is null)
                return;
            
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

            SendKeys(keys);
        }

        private static void SendKeys(IReadOnlyCollection<byte> keys)
        {
            //Set keys:
            foreach (var key in keys)
            {
                keybd_event(key, 0, 0, UIntPtr.Zero);
            }

            //Release keys:
            foreach (var key in keys)
            {
                keybd_event(key, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            }
        }
    }
}
