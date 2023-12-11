using Overlayer.Core.Patches;

namespace AdvancedCombo {
    [LazyPatch("AdvancedCombo.HitMargin", "scrMisc", "GetHitMargin", Triggers = new[] { "GCombo", "YCombo", "RCombo", "ACombo", "AString", "AValue" })]
    public class HitMarginPatch {
        public static void Postfix(HitMargin __result) {
            if(!Settings.Instance.AutoTileCombo && IsAutoPlayTile()) return;
            if(__result == HitMargin.FailOverload || __result == HitMargin.FailMiss ||
               __result == HitMargin.TooLate || __result == HitMargin.TooEarly) {
                CustomTags.GReset = true;
                CustomTags.GCombo = 0;
                CustomTags.YReset = true;
                CustomTags.YCombo = 0;
                CustomTags.RCombo = 0;
                return;
            }
            CustomTags.RCombo++;
            if(__result == HitMargin.VeryEarly || __result == HitMargin.VeryLate) {
                CustomTags.GReset = true;
                CustomTags.GCombo = 0;
                CustomTags.YReset = true;
                CustomTags.YCombo = 0;
                return;
            }
            CustomTags.YCombo++;
            if(__result == HitMargin.EarlyPerfect || __result == HitMargin.LatePerfect) {
                CustomTags.GReset = true;
                CustomTags.GCombo = 0;
                return;
            }
            CustomTags.GCombo++;
        }

        private static bool IsAutoPlayTile() {
            return scrController.instance.currFloor != null &&
                   scrController.instance.currFloor.nextfloor != null &&
                   scrController.instance.currFloor.nextfloor.auto;
        }
    }
}