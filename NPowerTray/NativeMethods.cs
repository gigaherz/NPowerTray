using System;
using System.Runtime.InteropServices;

namespace NPowerTray
{
    static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern void LockWorkStation();

        [DllImport("wtsapi32.dll", SetLastError = true)]
        internal static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);

        internal static readonly int WtsCurrentSession = -1;
        internal static readonly IntPtr WtsCurrentServerHandle = IntPtr.Zero;
    }
}
