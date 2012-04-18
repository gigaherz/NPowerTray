using System;
using Microsoft.Win32;

namespace NPowerTray
{
    class RegistrySettings
    {
        public enum ConfigKey
        {
            CheckPeriodically,
            LastChecked,
            DefaultAction,
        }

        public static bool TryGetConfig<T>(ConfigKey key, out T value)
        {
            var updatesKey = Program.BaseKey.OpenSubKey(Program.AppKey);
            if (updatesKey == null)
            {
                value = default(T);
                return false;
            }

            var v = updatesKey.GetValue(key.ToString());
            updatesKey.Close();

            if (v == null)
            {
                value = default(T);
                return false;
            }

            if (typeof(T) == typeof(bool))
            {
                value = (T)(object)bool.Parse((string)v);
                return true;
            }

            if (typeof(T) == typeof(double))
            {
                value = (T)(object)double.Parse((string)v);
                return true;
            }

            if (typeof(T) != v.GetType())
            {
                value = default(T);
                return false;
            }

            value = (T)v;
            return true;
        }

        public static T GetConfig<T>(ConfigKey key, T defaultValue = default(T))
        {
            T value;

            if(!TryGetConfig(key, out value))
            {
                if (typeof (T) == typeof (long))
                    SetConfig(key, defaultValue, RegistryValueKind.QWord);
                else
                    SetConfig(key, defaultValue);
                return defaultValue;
            }

            return value;
        }

        public static void SetConfig(ConfigKey key, long value)
        {
            SetConfig(key, value, RegistryValueKind.QWord);
        }

        public static void SetConfig(ConfigKey key, int value)
        {
            SetConfig(key, value, RegistryValueKind.DWord);
        }

        public static void SetConfig(ConfigKey key, byte[] value)
        {
            SetConfig(key, value, RegistryValueKind.Binary);
        }

        public static void SetConfig<T>(ConfigKey key, T value, RegistryValueKind valueKind = RegistryValueKind.String)
        {
            T oldValue;

            if (TryGetConfig(key, out oldValue))
            {
                if(oldValue.Equals(value))
                    return;
            }

            var updatesKey = Program.BaseKey.CreateSubKey(Program.AppKey);
            if (updatesKey == null) return;

            if (updatesKey.GetValueKind(key.ToString()) != valueKind)
                updatesKey.DeleteValue(key.ToString());

            updatesKey.SetValue(key.ToString(), value, valueKind);
            updatesKey.Close();
        }

    }
}

