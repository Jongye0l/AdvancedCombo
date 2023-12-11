using System;
using Overlayer.Core.Tags;

namespace AdvancedCombo {
    public class CustomTags {
        private static readonly Settings Settings = Settings.Instance;
        private static readonly string GreenValue = "Green";
        private static readonly string YellowValue = "Yellow";
        private static readonly string RedValue = "Red";
        public static bool GReset = false;
        public static bool YReset = false;
        [FieldTag]
        public static int GCombo;
        [FieldTag]
        public static int YCombo;
        [FieldTag]
        public static int RCombo;

        [Tag]
        public static int ACombo() {
            return Settings.FirstOnly ?
                YReset ? RCombo : GReset ? YCombo : GCombo
                : Math.Max(Math.Max(GCombo, YCombo), RCombo);
        }

        [Tag]
        public static string AString() {
            return Settings.FirstOnly ?
                YReset ? Settings.RedString : GReset ? Settings.YellowString : Settings.GreenString
                : RCombo > YCombo ? Settings.RedString : YCombo > GCombo ? Settings.YellowString : Settings.GreenString;
        }

        [Tag]
        public static string AValue() {
            return Settings.FirstOnly ?
                YReset ? RedValue : GReset ? YellowValue : GreenValue
                : RCombo > YCombo ? RedValue : YCombo > GCombo ? YellowValue : GreenValue;
        }
    }
}