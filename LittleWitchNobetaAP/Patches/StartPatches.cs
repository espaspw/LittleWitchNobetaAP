using HarmonyLib;
using Il2Cpp;
using LittleWitchNobetaAP.Archipelago;
using MelonLoader;
using UnityEngine.UI;

namespace LittleWitchNobetaAP.Patches;

public static class StartPatches
{
    private static string? GameVersionText { get; set; }
    private static string? RandomizerVersionText { get; set; }

    [HarmonyPatch(typeof(UIOpeningMenu), nameof(UIOpeningMenu.Init))]
    private static class UIOpeningMenuInit
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local __instance is needed for Harmony self reference
        private static void OpeningMenuInitPostfix(UIOpeningMenu __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            // Add randomizer plugin version next to game version
            var versionGameObject = __instance.transform.Find("Foreground/Version").gameObject;
            versionGameObject.transform.Translate(0, 5, 0);

            var versionText = versionGameObject.GetComponent<Text>();

            GameVersionText = versionText.text;
            RandomizerVersionText = $"Ver {MyPluginInfo.PluginVersion}";

            versionText.text = $"Game: {GameVersionText} Randomizer: {RandomizerVersionText}";
        }
    }
    
    [HarmonyPatch(typeof(UIOpeningMenu), nameof(UIOpeningMenu.Appear))]
    private static class UIOpeningMenuAppear
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local __instance is needed for Harmony self reference
        private static void OpeningMenuAppearPostfix(UIOpeningMenu __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            Melon<LwnApMod>.Logger.Msg($"Disconnecting from AP server because main menu was entered...");
            ArchipelagoClient.Disconnect();
            LwnApMod.ShowApConnectionUI = false;
        }
    }
}