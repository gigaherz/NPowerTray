using System;

namespace NPowerTray
{
    [Flags]
    public enum ShutdownMode
    {
        Force = 4,

        LogOff = 0,
        ForceLogOff = LogOff | Force,

        Shutdown = 1,
        ForceShutdown = Shutdown | Force,

        Reboot = 2,
        ForceReboot = Reboot | Force,

        PowerOff = 8,
        ForcePowerOff = PowerOff | Force,
    }
}