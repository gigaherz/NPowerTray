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

        [DllImport("advapi32.dll")]
        internal static extern int InitiateShutdown(
            [MarshalAs(UnmanagedType.LPTStr)] string lpMachineName,
            [MarshalAs(UnmanagedType.LPTStr)] string lpMessage,
            int dwGracePeriod,
            InitiateShutdownFlags dwShutdownFlags,
            uint dwReason);


        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attributes;
        }

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
    }

    [Flags]
    enum InitiateShutdownFlags
    {
        ForceOtherSessions = 0x00000001,
        ForceOwnSession = 0x00000002,
        Restart = 0x00000004,
        PowerOff = 0x00000008,
        NoReboot = 0x00000010,
        OverrideGracePeriod = 0x00000020,
        InstallUpdates = 0x00000040,
        RestartApps = 0x00000080,
        Hybrid = 0x00000200,
    }
}
