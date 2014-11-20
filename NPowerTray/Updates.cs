using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace NPowerTray
{
    static class Updates
    {
        public static bool AutoCheck()
        {
            if (!CheckPeriodically) 
                return false;

            var currentTime = DateTime.UtcNow;

            var lastCheck = LastCheckUtc;
            var nextCheck = lastCheck.AddDays(7);

            return nextCheck < currentTime;
        }

        public static bool CheckForUpdates(out uint[] newVersion)
        {
            newVersion = null;

            try
            {
                var wr = WebRequest.Create(Program.UpdateUrl);

                var resp = wr.GetResponse();
                var res = resp as HttpWebResponse;
                if (res != null && (int) res.StatusCode >= 300)
                {
                    return false;
                }

                using (var stm = resp.GetResponseStream())
                {
                    if (stm != null)
                    {
                        var data = new StreamReader(stm);
                        var text = data.ReadToEnd();

                        var parts = text.Split(',');
                        var values = new Dictionary<string, string>();
                        foreach (var s in parts)
                        {
                            var vv = s.Trim().Split(' ');
                            values[vv[0]] = vv[1];
                        }

                        var version = Application.ProductVersion.Split('.').Select(uint.Parse).ToArray();

                        newVersion = values["version"].Split('.').Select(uint.Parse).ToArray();

                        if (CompareArraysLeft(newVersion, version) > 0)
                        {
                            return true;
                        }

                        LastCheckUtc = DateTime.UtcNow.Date;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Compares arrays left-aligned. Extra numbers at the end of one array make the array larger.
        /// </summary>
        /// <param name="p">First array</param>
        /// <param name="q">Second array</param>
        /// <returns></returns>
        private static int CompareArraysLeft(uint[] p, uint[] q)
        {
            int a = p.Length;
            int b = q.Length;

            for (int i = 0; i < a && i < b; i++)
            {
                if (p[i] > q[i])
                    return 1;

                if (p[i] < q[i])
                    return -1;
            }

            if (a > b)
                return 1;

            if (b > a)
                return -1;

            return 0;
        }

        public static bool CheckPeriodically
        {
            get { return RegistrySettings.GetConfig(RegistrySettings.ConfigKey.CheckPeriodically, false); }
            set { RegistrySettings.SetConfig(RegistrySettings.ConfigKey.CheckPeriodically, value); }
        }

        public static DateTime LastCheckUtc
        {
            get
            {
                return DateTime.FromFileTimeUtc(
                    RegistrySettings.GetConfig(
                        RegistrySettings.ConfigKey.LastChecked,
                        0L));
            }
            set { RegistrySettings.SetConfig(RegistrySettings.ConfigKey.LastChecked, value.ToFileTimeUtc()); }
        }

    }
}
