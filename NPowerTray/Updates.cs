using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

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

        public static bool CheckForUpdates(out int[] newVersion)
        {
            newVersion = null;

            var wr = WebRequest.Create("http://gigaherz.pcsx2.net/NPowerTray/version.txt");

            var res = (HttpWebResponse)wr.GetResponse();
            if((int)res.StatusCode >= 300)
            {
                return false;
            }

            var stm = res.GetResponseStream();
            if (stm != null)
            {
                var data = new StreamReader(stm);
                var text = data.ReadToEnd();

                var parts = text.Split(',');
                var values = new Dictionary<string, string>();
                foreach(var s in parts)
                {
                    var vv = s.Trim().Split(' ');
                    values[vv[0]] = vv[1];
                }
                
                var version = Application.ProductVersion.Split('.').Select(int.Parse).ToArray();

                newVersion = values["version"].Split('.').Select(int.Parse).ToArray();
                
                if(CompareArraysLeft(newVersion, version) > 0)
                {
                    return true;
                }

                LastCheckUtc = DateTime.UtcNow.Date;
            }

            return false;
        }

        /// <summary>
        /// Compares arrays left-aligned. Extra numbers at the end of one array are compared against zero.
        /// </summary>
        /// <param name="p">First array</param>
        /// <param name="q">Second array</param>
        /// <returns></returns>
        private static int CompareArraysLeft(int[] p, int[] q)
        {
            int a = p.Length;
            int b = q.Length;
            int c = Math.Min(a, b);

            for (int i = 0; i < c; i++, a--, b--)
            {
                int s = Math.Sign(p[i] - q[i]);
                if (s != 0) return s;
            }

            if (a > b)
            {
                for (int i = 0; i < a; i++, a--)
                {
                    int s = Math.Sign(p[i]);
                    if (s != 0) return s;
                }
            }
            else
            {
                for (int i = 0; i < b; i++, b--)
                {
                    int s = Math.Sign(q[i]);
                    if (s != 0) return s;
                }
            }

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
