using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Packets;
using HarmonyLib;
using Il2Cpp;
using LittleWitchNobetaAP.Archipelago;
using LittleWitchNobetaAP.Utils;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

namespace LittleWitchNobetaAP.Patches;

public static class ItemCheckPatches
{
    [HarmonyPatch(typeof(TreasureBox), nameof(TreasureBox.Init))]
    private static class TreasureBoxInit
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void TreasureBoxInitPostfix(ref TreasureBox __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            // remove chest contents
            __instance.ItemType = ItemSystem.ItemType.Null;
        }
    }

    [HarmonyPatch(typeof(TreasureBox), nameof(TreasureBox.SetOpen))]
    private static class TreasureBoxSetOpen
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void TreasureBoxSetOpenPostfix(TreasureBox __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (!ArchipelagoClient.IsAuthenticated || ArchipelagoClient.Session is null) return;

            Melon<LwnApMod>.Logger.Msg($"Opened chest {__instance.name}");
            var chestName = ArchipelagoData.GameLocationToDescriptiveLocation(__instance.name);

            // Special exception because TreasureBox instance name TreasureBox_Room03 exists twice
            if (Game.sceneManager.stageId == 3 && __instance.name == "TreasureBox_Room03")
            {
                ArchipelagoClient.Session.Locations.CompleteLocationChecks(
                    ArchipelagoClient.Session.Locations.GetLocationIdFromName(
                        "Little Witch Nobeta", "Underground - Chest in alcove before falling rocks"));
                Melon<LwnApMod>.Logger.Msg($"Chest AP name: Underground - Chest in alcove before falling rocks");
            }
            else
            {
                ArchipelagoClient.Session.Locations.CompleteLocationChecks(
                    ArchipelagoClient.Session.Locations.GetLocationIdFromName("Little Witch Nobeta",
                        ArchipelagoData.GameLocationToDescriptiveLocation(__instance.name)));

                Melon<LwnApMod>.Logger.Msg($"Chest AP name: {chestName}");
                Melon<LwnApMod>.Logger.Msg(
                    $"Chest AP Id: {ArchipelagoClient.Session.Locations.GetLocationIdFromName("Little Witch Nobeta", chestName)}");
                Melon<LwnApMod>.Logger.Msg($"Chest client Id: {ArchipelagoData.GetLocationIdByName(chestName)}");
            }
        }
    }

    [HarmonyPatch(typeof(CatEvent), nameof(CatEvent.OpenEvent))]
    private static class CatEventOpenEvent
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static bool CatEventOpenEventPrefix(CatEvent __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (__instance.name is "04_CatAbsorbSkill" or "04_SkillBookAgain"
                && ArchipelagoClient.IsAuthenticated
                && ArchipelagoClient.Session is not null)
                ArchipelagoClient.Session.Locations.CompleteLocationChecks(
                    ArchipelagoClient.Session.Locations.GetLocationIdFromName("Little Witch Nobeta",
                        ArchipelagoData.GameLocationToDescriptiveLocation(__instance.name)));

            return false;
        }
    }

    // Disable thunder from Vanessa
    [HarmonyPatch(typeof(SceneEvent), nameof(SceneEvent.InitData))]
    private static class SceneEventInitData
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void LoadScriptInitPostfix(SceneEvent __instance, SceneEventManager SEM)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (__instance.name is not "LoadScriptRoomBossEnd"
                || !ArchipelagoClient.IsAuthenticated
                || ArchipelagoClient.Session is null) return;

            var loadScript = __instance.Cast<LoadScript>();
            var newEvents = loadScript.Event.SkipLast(1).ToArray();
            loadScript.Event = newEvents;

            ArchipelagoClient.Session.Locations.CompleteLocationChecks(
                ArchipelagoClient.Session.Locations.GetLocationIdFromName(
                    "Little Witch Nobeta", "Spirit Realm - Thunder spell from Vanessa V2"));
            ArchipelagoClient.Session.Locations.CompleteLocationChecks(
                ArchipelagoClient.Session.Locations.GetLocationIdFromName(
                    "Little Witch Nobeta", "Spirit Realm - 101. Proud King's Crafted Soul Shard from Vanessa V2"));
        }
    }

    // Item pickup
    [HarmonyPatch(typeof(PlayerItem), nameof(PlayerItem.PickUp))]
    private static class PlayerItemPickUp
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static bool ItemPickUpPrefix(PlayerItem __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            Melon<LwnApMod>.Logger.Msg($"Picked up item {__instance.GetItemData().name}");
            if (!__instance.GetItemData().name.Contains("Item_Property")) return true;
            var propertyId = __instance.GetItemData().GetPropertyID();
            Melon<LwnApMod>.Logger.Msg($"Item property ID:  {propertyId}");

            if (ArchipelagoClient.IsAuthenticated && ArchipelagoClient.Session is not null)
            {
                var loreItems =
                    from item in ArchipelagoData.Items
                    where item.Value == "Lore"
                    orderby int.Parse(new string(item.Key.TakeWhile(char.IsDigit).ToArray()))
                    select item.Key;

                var loreItem = loreItems.ElementAt(propertyId);

                if (loreItem is not null)
                {
                    var locationName =
                        (from item in ArchipelagoData.Locations.Keys
                            where item.Contains(loreItem)
                            select item).FirstOrDefault();

                    if (locationName is not null)
                    {
                        var locationId = ArchipelagoData.GetLocationIdByName(locationName);
                        ArchipelagoClient.Session.Locations.CompleteLocationChecks(locationId);
                        ArchipelagoClient.ServerData.AddCheckedLoreItemLocation(propertyId);
                        Melon<LwnApMod>.Logger.Msg($"Added check lore item location: {propertyId}");
                    }
                    else
                    {
                        Melon<LwnApMod>.Logger.Error($"Did not find a location for lore item: {loreItem}");
                    }
                }
                else
                {
                    Melon<LwnApMod>.Logger.Error(
                        $"Did not find a lore item with id: {propertyId + 1}");
                }
            }

            MelonCoroutines.Start(LwnApMod.RunOnMainThread(() =>
                Object.Destroy(__instance.GetItemData().gameObject)));

            return false;
        }
    }

    // Prevent "No item" prompt from showing when player checks lore item location
    [HarmonyPatch(typeof(Game), nameof(Game.AppearEventPrompt))]
    private static class GameAppearEventPrompt
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static bool BlockNoItemMsg(Game __instance, string content)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            return content != "No item";
        }
    }

    // Because lore item checks won't spawn if a player already has a lore item, but lore
    // items can be randomized, we tell the spawn logic that the player has no lore items
    [HarmonyPatch(typeof(GamePropertyData), nameof(GamePropertyData.HasPropUnlocked))]
    [HarmonyPatch(new[] { typeof(int) })]
    private static class GamePropertyDataHasPropUnlocked
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static bool CheckIfLocationChecked(GamePropertyData __instance, int index, ref bool __result)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (!ArchipelagoClient.IsAuthenticated || ArchipelagoClient.Session is null) return true;

            // Disable all lore items entirely when lore is disabled in settings
            if (ArchipelagoClient.ServerData.Settings?.RandomizeLoreEnabled == ArchipelagoSettings.RandomizeLore.NoLore)
            {
                __result = true;
                return false;
            }

            // Use actual received lore data for special AP lore received menu
            if (ItemMenuPatches.IsOnInjectedMenu) return true;
            // Otherwise return fake lore items for checked locations
            __result = ArchipelagoClient.ServerData.CheckedLoreItemLocations.Contains(index);
            return false;
        }
    }

    // Bosses
    [HarmonyPatch(typeof(NPCManage), nameof(NPCManage.Hit))]
    private static class NpcManageHit
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void NpcManageHitPostfix(NPCManage __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (!__instance.GetIsDeath()) return;

            var descriptiveLocation = ArchipelagoData.GameLocationToDescriptiveLocation(__instance.name);
            //Melon<LwnApMod>.Logger.Msg($"Killed enemy: {__instance.name}");
            if (descriptiveLocation != string.Empty)
                //Melon<LwnApMod>.Logger.Msg($"Sending enemy location: {descriptiveLocation}, {ArchipelagoData.GetLocationIdByName(descriptiveLocation)}");
                ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                    ArchipelagoData.GetLocationIdByName(descriptiveLocation));

            switch (__instance.name)
            {
                case "Boss_Act01_Plus":
                    ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                        ArchipelagoData.GetLocationIdByName("Secret Passage - Teleport from Enraged Armor"));
                    break;
                case "Boss_Level04":
                    ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                        ArchipelagoData.GetLocationIdByName("Dark Tunnel - 100. King's Final Honor from Vanessa"));
                    ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                        ArchipelagoData.GetLocationIdByName("Dark Tunnel - 78. Ancient Throne Rune from Vanessa"));
                    ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                        ArchipelagoData.GetLocationIdByName("Dark Tunnel - 77. The Throne from Vanessa"));
                    break;
                case "Boss_Level06":
                {
                    var statusUpdatePacket = new StatusUpdatePacket
                    {
                        Status = ArchipelagoClientState.ClientGoal
                    };

                    ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
                        ArchipelagoData.GetLocationIdByName(
                            "Abyss - 102. Lost Maiden's Crafted Soul Shard from Nonota"));
                    ArchipelagoClient.Session?.Socket.SendPacket(statusUpdatePacket);
                    break;
                }
            }
        }
    }

    private const float CoordinateTolerance = 3.0f;

    // ReSharper disable InconsistentNaming
    private static void HandleDamageObject(DamageObject __instance)
        // ReSharper restore InconsistentNaming
    {
        if (!ArchipelagoClient.IsAuthenticated || ArchipelagoClient.Session is null)
        {
            return;
        }

        var stageId = Singletons.SceneManager.stageId;
        var path = UnityUtils.GetObjectPath(__instance.gameObject);
        var pos = __instance.transform.position;
        Melon<LwnApMod>.Logger.Msg($"Damage object {path} at {pos.ToString("F2")}.");

        if (!ArchipelagoData.BreakableItems.ByStageIdAndPath.TryGetValue(stageId, out var stageLookup))
            return;
        var matchingItems = stageLookup[path];
        var breakableItems = matchingItems.ToList();
        if (!breakableItems.Any()) return;

        var exactCoordinateMatch = breakableItems.FirstOrDefault(item =>
            item.Position.HasValue &&
            Vector3.Distance(item.Position.Value, pos) <= CoordinateTolerance);

        // Get breakable item matching path name, and must match coordinates if provided for that item
        var matchedItem = exactCoordinateMatch ??
                          breakableItems.FirstOrDefault(item => !item.Position.HasValue);

        if (matchedItem == null) return;

        // Only send check if that setting type is enabled
        var isEnabled = matchedItem.Type switch
        {
            BreakableItemType.Jug => ArchipelagoClient.ServerData.Settings?.RandomizeJugsEnabled ?? false,
            BreakableItemType.Barrel => ArchipelagoClient.ServerData.Settings?.RandomizeBarrelsEnabled ?? false,
            BreakableItemType.Doll => ArchipelagoClient.ServerData.Settings?.RandomizeBrokenDollsEnabled ?? false,
            BreakableItemType.Crystal => ArchipelagoClient.ServerData.Settings?.RandomizeCrystalsEnabled ?? false,
            _ => true
        };

        if (!isEnabled) return;

        Melon<LwnApMod>.Logger.Msg($"Damage object mapped to location ({matchedItem.LocationName}).");
        ArchipelagoClient.Session?.Locations.CompleteLocationChecks(
            ArchipelagoData.GetLocationIdByName(matchedItem.LocationName));
    }

    [HarmonyPatch(typeof(DamageObject), nameof(DamageObject.SetDamage))]
    private static class DamageObjectSetDamage
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void DamageObjectSetDamagePrefix(DamageObject __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            HandleDamageObject(__instance);
        }
    }

    [HarmonyPatch(typeof(DamageObject02), nameof(DamageObject02.SetDamage))]
    private static class DamageObjectSetDamage02
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void DamageObject02SetDamagePrefix(DamageObject __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            HandleDamageObject(__instance);
        }
    }
}