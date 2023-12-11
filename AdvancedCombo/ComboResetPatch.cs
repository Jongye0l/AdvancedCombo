using Overlayer.Core.Patches;

namespace AdvancedCombo {
    [LazyPatch("AdvancedCombo.Reset", "Variables", "Reset", Triggers = new[] { "GCombo", "YCombo", "RCombo", "ACombo", "AString", "AValue" })]
    public class ComboResetPatch {
        public static void Postfix() {
            CustomTags.GReset = false;
            CustomTags.GCombo = 0;
            CustomTags.YReset = false;
            CustomTags.YCombo = 0;
            CustomTags.RCombo = 0;
        }
    }
}