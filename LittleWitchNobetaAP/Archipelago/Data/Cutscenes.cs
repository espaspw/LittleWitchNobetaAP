// ReSharper disable once CheckNamespace
namespace LittleWitchNobetaAP.Archipelago;

public class CutsceneTrigger
{
    public StageId StageId { get; init; }
    public string Trigger { get; init; } = "";
    public Func<bool> ShouldSkip { get; init; } = () => true;
}

public static partial class ArchipelagoData
{
    public static class CutscenesToSkip
    {
        public static readonly List<CutsceneTrigger> Cutscenes = new()
        {
            // Initial cutscene when entering shrine. Without the cutscene the player will spawn facing the wrong
            // way (which isn't a big issue). This removal is required for randomized start as this triggers even
            // if player enters Shrine through a different entrance.
            new CutsceneTrigger()
            {
                StageId = StageId.Shrine,
                Trigger = "/SEM/AreaEvent/Room01/Other/Room01_OpenDoorScript",
                ShouldSkip = () =>
                    (ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false) ||
                    ((ArchipelagoClient.ServerData.Settings?.StartLevel !=
                      ArchipelagoSettings.StartLevelSetting.OkunShrine))
            },
            // Cutscene when you enter Underground after first boss. This triggers even if the player enters through
            // the shortcut door, which teleports the player to the start and breaks logic
            new CutsceneTrigger()
            {
                StageId = StageId.Underground,
                Trigger = "/SEM/AreaEvent/Room01/Other/LoadScript_Room01",
            },
            // Cutscene where the cat explains using ice magic to pass the fire barriers
            new CutsceneTrigger()
            {
                StageId = StageId.Underground,
                Trigger = "/SEM/AreaEvent/Room07To08/Other/LoadScript",
                ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false
            },
            // Skips cutscene before Tania when walking through the hall with broken dolls
            new CutsceneTrigger()
            {
                StageId = StageId.Underground,
                Trigger = "/SEM/AreaEvent/Room09/Other/LoadScript",
                ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false
            },
            // Removes cutscene from entering Lava Ruins from Underground, which forces player into statue pit
            // This has to be paired with moving the rebirth point of the Underground door (or logic will need
            // to be modified)
            new CutsceneTrigger()
            {
                StageId = StageId.LavaRuins,
                Trigger = "/SEM/AreaEvent/Room01/Other/LoadScript",
            },
            // TODO: figure out what this is...
            new CutsceneTrigger()
            {
                StageId = StageId.LavaRuins,
                Trigger = "/SEM/AreaEvent/Room07To08/Other/LoadScript",
                ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false
            },
            // Skips cutscene near Fire pickup
            new CutsceneTrigger()
            {
                StageId = StageId.LavaRuins,
                Trigger = "/SEM/AreaEvent/Room05/Other/LoadScript_Room05",
                ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false
            },
            // Skips cutscene at entrance of Dark Tunnel where player loses hat
            // As this would normally enable hat lost flag, the hat retrieval cutscene also won't trigger
            // TODO: Currently disabled since it might interfere with light orb logic
            // new CutsceneTrigger()
            // {
            //     StageId = StageId.DarkTunnel,
            //     Trigger = "/SEM/AreaEvent/Room01/Other/LoadScript01",
            //     ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableUnimportantCutscenes ?? false
            // },
            new CutsceneTrigger()
            {
                StageId = StageId.DarkTunnel,
                Trigger = "/SEM/AreaEvent/Room08_02/Other/LoadScriptRoom08",
                ShouldSkip = () => ArchipelagoClient.ServerData.Settings?.DisableDarkTunnelBridgeCollapse ?? false
            },
            new CutsceneTrigger()
            {
                StageId = StageId.DarkTunnel,
                Trigger = "/SEM/AreaEvent/Room08_02/Other/LoadScriptRoom08_02",
            },
            new CutsceneTrigger()
            {
                StageId = StageId.DarkTunnel,
                Trigger = "/SEM/AreaEvent/Room08_02/Other/LoadScriptRoom08_03",
            },
            // Cutscene that plays when you initially load into stage
            // These are disabled unconditionally because they could allow incorrect warping if a player loads a save
            // within Spirit Realm or Abyss but hasn't played the cutscene yet, which warps them to the start
            new CutsceneTrigger()
            {
                StageId = StageId.SpiritRealm,
                Trigger = "/SEM/AreaEvent/Room01/Other/LoadScriptRoom01",
            },
            new CutsceneTrigger()
            {
                StageId = StageId.Abyss,
                Trigger = "/SEM/AreaEvent/RoomStart/Other/LoadScript_RoomStart",
            },
            // Cutscene when Nobeta passes the final teleporter into final boss room
            new CutsceneTrigger()
            {
                StageId = StageId.Abyss,
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/DelayLoadScript",
            },
        };

        public static readonly ILookup<int, CutsceneTrigger> ByStageId =
            Cutscenes.ToLookup(c => (int)c.StageId);
    }
}