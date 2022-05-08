using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;

namespace KdProject1.Helper
{
    public static class IsoStore
    {
        public static bool AddOrUpdateValue(string Key, Object value)
        {
            bool valueChanged = false;
            try
            {


                // If the key exists
                if (App.appSettings.Contains(Key))
                {
                    // If the value has changed
                    if (App.appSettings[Key] != value)
                    {
                        // Store the new value
                        App.appSettings[Key] = value;
                        valueChanged = true;
                    }
                }
                // Otherwise create the key.
                else
                {
                    App.appSettings.Add(Key, value);
                    valueChanged = true;
                }
                App.appSettings.Save();

            }
            catch (Exception ex)
            { }
            return valueChanged;
        }

        public static T GetValueOrDefault<T>(string Key, T defaultValue)
        {
            T value;

            // If the key exists, retrieve the value.
            if (App.appSettings.Contains(Key))
            {
                value = (T)App.appSettings[Key];
            }
            // Otherwise, use the default value.
            else
            {
                value = defaultValue;
            }
            return value;
        }

        public static T LoadObjectFromStorage<T>(string FileName)
        {
            T ObjToLoad = default(T);

            try
            {
                using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    if (isf.FileExists(FileName))
                    {
                        using (IsolatedStorageFileStream fs = isf.OpenFile(FileName, System.IO.FileMode.Open))
                        {
                            XmlSerializer ser = new XmlSerializer(typeof(T));
                            ObjToLoad = (T)ser.Deserialize(fs);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //throw new NotImplementedException(error.Message);
            }

            return ObjToLoad;
        }

        public static void SaveObjectToStorage<T>(T ObjectToSave, string FileName)
        {
            TextWriter writer;

            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream fs = isf.OpenFile(FileName, System.IO.FileMode.Create))
                {
                    writer = new StreamWriter(fs);
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, ObjectToSave);
                    writer.Close();
                }
            }
        }

        public static string GetFileName<T>()
        {
            return typeof(T).FullName + ".xml";
        }

        //public static bool IsObjectPersisted<T1>()
        //{
        //    using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
        //    {
        //        return isf.FileExists(GetFileName<T1>());
        //    }
        //}

        public static T LoadSetttingFromStorage<T>(string Key)
        {
            T ObjToLoad = default(T);

            if (IsolatedStorageSettings.ApplicationSettings.Contains(Key))
            {
                ObjToLoad = (T)IsolatedStorageSettings.ApplicationSettings[Key];
            }

            return ObjToLoad;
        }

        public static void SaveSettingToStorage(string Key, object Setting)
        {
            if (!IsolatedStorageSettings.ApplicationSettings.Contains(Key))
            {
                IsolatedStorageSettings.ApplicationSettings.Add(Key, Setting);
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings[Key] = Setting;
            }

        }

        //public static bool IsSettingPersisted(string Key)
        //{
        //    return IsolatedStorageSettings.ApplicationSettings.Contains(Key);
        //}


    }
}
