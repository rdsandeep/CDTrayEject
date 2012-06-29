using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using MayhemCore;

namespace CDTrayEject
{
    [MayhemModule("Eject CD Tray", "Eject the computer's CD tray")]
    public class TrayEject : ReactionBase
    {
        public override void Perform()
        {
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern void mciSendString(string lpstrCommand,
            string lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
    }
}
