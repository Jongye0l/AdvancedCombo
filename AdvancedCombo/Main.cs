using System.Reflection;
using Overlayer.Core;
using Overlayer.Core.Patches;
using Overlayer.Core.Translation;
using Overlayer.Modules;
using UnityEngine;

namespace AdvancedCombo {
    public class Main : OverlayerModule {
        public static Main Instance;
        public static Settings Settings;
        private static Assembly _assembly;

        public Main() {
            Instance = this;
        }
        
        public override bool IsEnabled { get; set; }

        public override void OnLoad() {
            _assembly = Assembly.GetExecutingAssembly();
            Settings = Settings.CreateInstance();
        }

        public override void OnEnable() {
            LazyPatchManager.Load(_assembly);
            TagManager.Load(typeof(CustomTags));
            TextManager.Refresh();
            IsEnabled = true;
        }

        public override void OnDisable() {
            TagManager.Unload(typeof(CustomTags));
            LazyPatchManager.Unload(_assembly);
            IsEnabled = false;
            MemoryHelper.Clean(CleanOption.All);
        }

        public override void OnUnload() {
            _assembly = null;
        }

        public override void OnGUI() {
            Values values = GetValues();
            GUILayout.Label("AdvancedCombo", new GUIStyle(GUI.skin.label) {
                font = FontManager.GetFont("Default").font,
                fontSize = 50,
                richText = true
            });
            GUILayout.BeginHorizontal();
            GUILayout.Label(values.Credit_Devloper + " : Jongyeol");
            if(GUILayout.Button(values.Credit_Source)) Application.OpenURL("https://github.com/Jongye0l/AdvancedCombo");
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Label(values.Credit_BugReport);
            AddSettingToggle(ref Settings.AutoTileCombo, values.Setting_AutoTileCombo);
            AddSettingToggle(ref Settings.FirstOnly, values.Setting_FirstOnly);
            AddTextField(ref Settings.GreenString, values.Setting_GreenCombo);
            AddTextField(ref Settings.YellowString, values.Setting_YellowCombo);
            AddTextField(ref Settings.RedString, values.Setting_RedCombo);
        }

        private void AddSettingToggle(ref bool value, string text) {
            if(GUILayout.Toggle(value, text)) {
                if(!value) {
                    value = true;
                    Settings.Save();
                }
            } else if(value) {
                value = false;
                Settings.Save();
            }
        }

        private void AddTextField(ref string value, string text) {
            GUILayout.BeginHorizontal();
            GUILayout.Label(text);
            GUILayout.Space(4f);
            string result = GUILayout.TextField(value, GUILayout.Width(300));
            if(!result.Equals(value)) {
                value = result;
                Settings.Save();
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        public static Values GetValues() {
            return Overlayer.Main.Language == Language.Korean ? Values.Korean : Values.English;
        }
    }
}