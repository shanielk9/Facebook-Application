using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookApplication
{
    public sealed class AppSettings
    {
        private const string k_SettingsFilePath = "AppSettings.xml";
        private static AppSettings s_Instance = null;
        private static object s_LockObj = new object();
        
        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppSettings();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public bool IsLoggedOut { get; set; }

        public bool RememberUser { get; set; }
   
        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            ResetToDefaultSettings();
        }

        public void ResetToDefaultSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            IsLoggedOut = false;
        }

        public void LoadFromFile()
        {
            if (File.Exists(k_SettingsFilePath))
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    s_Instance = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                s_Instance = null;
            }
        }

        public void SaveToFile()
        {
            if (File.Exists(k_SettingsFilePath))
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}