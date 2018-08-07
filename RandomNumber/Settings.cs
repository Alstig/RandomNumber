using Microsoft.Win32;
using System;
using System.Linq;
using System.Drawing;

namespace RandomNumber
{
    static class Settings
    {
        #region Public settings

        public static int Interval
        {
            get
            {
                var keyValue = GetKeyValue("Interval");
                if (string.IsNullOrEmpty(keyValue) || !int.TryParse(keyValue, out var interval))
                    interval = 2000; // Default value

                return interval;
            }
            set
            {
                RootKey.SetValue("Interval", value.ToString());
            }
        }

        public static bool UpdateNumberOnClick
        {
            get
            {
                var keyValue = GetKeyValue("UpdateNumberOnClick");
                if (string.IsNullOrEmpty(keyValue) || !bool.TryParse(keyValue, out var updateNumberOnClick))
                    updateNumberOnClick = true; // Default value

                return updateNumberOnClick;
            }
            set
            {
                RootKey.SetValue("UpdateNumberOnClick", value);
            }
        }
        
        public static Color BackgroundColor
        {
            get
            {
                return GetColor("BackgroundColor", Color.Black);
            }
            set
            {
                RootKey.SetValue("BackgroundColor", GetArgb(value));
            }
        }

        public static Color TextColor
        {
            get
            {
                return GetColor("TextColor", Color.White);
            }
            set
            {
                RootKey.SetValue("TextColor", GetArgb(value));
            }
        }

        #endregion

        #region Private helpers

        private static RegistryKey RootKey
        {
            get
            {
                string subKeyName = "Software\\Bärnsten\\RandomNumber";
                var rootKey = Registry.CurrentUser.OpenSubKey(subKeyName, true);
                if (rootKey == null)
                {
                    Registry.CurrentUser.CreateSubKey(subKeyName);
                    rootKey = Registry.CurrentUser.OpenSubKey(subKeyName, true);
                }

                return rootKey;
            }
        }

        private static string GetKeyValue(string name)
        {
            if (RootKey.GetValueNames().Contains(name))
                return RootKey.GetValue(name).ToString();

            return string.Empty;
        }

        private static int GetArgb(Color color)
        {
            byte[] bytes = new byte[] { color.A, color.R, color.G, color.B };
            var argb = BitConverter.ToInt32(bytes, 0);

            return argb;
        }

        private static Color GetColor(string keyName, Color defaultColor)
        {
            var color = defaultColor;

            var keyValue = GetKeyValue(keyName);
            if (!string.IsNullOrEmpty(keyValue) && int.TryParse(keyValue, out var argb))
            {
                try
                {
                    var bytes = BitConverter.GetBytes(argb);
                    color = Color.FromArgb(bytes[0], bytes[1], bytes[2], bytes[3]);
                }
                catch { }
            }

            return color;
        }

        #endregion
    }
}
