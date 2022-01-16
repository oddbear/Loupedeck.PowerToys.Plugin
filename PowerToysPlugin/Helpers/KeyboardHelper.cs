using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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

        public static void SendKeys(IReadOnlyCollection<byte> keys)
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
