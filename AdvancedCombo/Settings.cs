using System.IO;
using Newtonsoft.Json;

namespace AdvancedCombo {
    public class Settings {
        private static readonly string SettingPath = Path.Combine(Main.Instance.ModulePath, "Settings.json");
        public static Settings Instance;
        public bool AutoTileCombo = true;
        public bool FirstOnly = true;
        public string GreenString = "<color=#60FF4E>G.Combo</color>";
        public string YellowString = "<color=#A0FF4E>Y.Combo</color>";
        public string RedString = "<color=#FF6F4E>R.Combo</color>";
        
        public static Settings CreateInstance() {
            Instance = File.Exists(SettingPath) ? JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingPath)) : new Settings();
            return Instance;
        }

        public void Save() {
            File.WriteAllText(SettingPath, JsonConvert.SerializeObject(Instance, Formatting.Indented));
        }
    }
}