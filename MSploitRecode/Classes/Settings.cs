using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WebSocketSharp;

namespace MSploitRecode.Classes
{
    public struct SettingsData
    {
        public string API;
        public string UI;

        public bool? ToolsUIEnabled;
        public bool? TopMost;
        public bool? MultiInstance;
        public bool? AutoAttach;
    }

    public class Settings
    {
        // Converters //
        private static string ToJson(SettingsData data)
        {
            return JsonConvert.SerializeObject(data);
        }

        private static SettingsData FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<SettingsData>(jsonString);
        }

        // Save, Get //
        public static (SettingsData data, bool success) GetSettings()
        {
            try
            {
                if (!File.Exists(Data.SettingsFile))
                    return (new SettingsData { }, false);

                string DATA = File.ReadAllText(Data.SettingsFile);
                return (FromJson(DATA), true);
            }
            catch { return (new SettingsData { }, false); }
        }

        public static void SaveSettings(SettingsData data)
        {
            try
            {
                SettingsData dataFromCurrentFile = GetSettings().data;
                object fixedData = new SettingsData { };

                foreach (FieldInfo field in data.GetType().GetFields())
                {
                    var fieldData = field.GetValue(data);
                    var fieldDataFromFile = field.GetValue(dataFromCurrentFile);

                    if (fieldData == fieldDataFromFile || fieldData == null ||
                        (fieldData is string str && string.IsNullOrEmpty(str)))
                        field.SetValueDirect(__makeref(fixedData), fieldDataFromFile);
                    else
                        field.SetValueDirect(__makeref(fixedData), fieldData);
                    
                }

                File.WriteAllText(Data.SettingsFile, ToJson((SettingsData)fixedData));
            }
            catch (Exception e) { MessageBox.Show("Failed to save settings:\n" + e.Message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
