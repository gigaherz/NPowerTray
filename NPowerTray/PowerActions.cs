using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using System.Windows.Forms;

namespace NPowerTray
{
    internal static class PowerActions
    {
        public static void Shutdown(ShutdownMode shutdownMode)
        {
#if DEBUG
            Debug.WriteLine("Shutdown requested with flags: {0}", shutdownMode);
#else
            var mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            var mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system
            mboShutdownParams["Flags"] = ((int) shutdownMode).ToString(CultureInfo.InvariantCulture);
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
            }
#endif
        }

        public static void ShutdownHybrid()
        {
#if DEBUG
            Debug.WriteLine("Hybrid Shutdown requested");
#else
            var osv = Environment.OSVersion;

            if(osv.Platform == PlatformID.Win32NT && osv.Version >= new Version(6,2))
            {
                var hToken = IntPtr.Zero;
                var tkp = new NativeMethods.TokPriv1Luid {Count = 1, Attributes = NativeMethods.SePrivilegeEnabled};

                // Get a token for this process. 

                if (!NativeMethods.OpenProcessToken(NativeMethods.GetCurrentProcess(),
                     NativeMethods.TokenAdjustPrivileges | NativeMethods.TokenQuery, ref hToken))
                    return;

                NativeMethods.LookupPrivilegeValue(null, NativeMethods.SeShutdownName, ref tkp.Luid);
                NativeMethods.AdjustTokenPrivileges(hToken, false, ref tkp, 0, IntPtr.Zero, IntPtr.Zero);
                NativeMethods.InitiateShutdown(null, null, 0,
                                               InitiateShutdownFlags.Hybrid | InitiateShutdownFlags.PowerOff, 0x80000000);
            }
#endif
        }

        public static void SetPowerState(PowerState newState, bool force = false, bool disableWakeupEvents = false)
        {
#if DEBUG
            Debug.WriteLine("Power State change to '{0}' requested: force={1}, disableEvents={2}", newState, force, disableWakeupEvents);
#else
            Application.SetSuspendState(newState, force, disableWakeupEvents);
#endif
        }

        public static void FastUserSwitch()
        {
#if DEBUG
            Debug.WriteLine("Fast User Switch requested");
#else
            if (!NativeMethods.WTSDisconnectSession(NativeMethods.WtsCurrentServerHandle,
                                      NativeMethods.WtsCurrentSession, false))
                throw new Win32Exception();
#endif
        }

        public static void Lock()
        {
#if DEBUG
            Debug.WriteLine("Lock requested");
#else
            NativeMethods.LockWorkStation();
#endif
        }
    }
}