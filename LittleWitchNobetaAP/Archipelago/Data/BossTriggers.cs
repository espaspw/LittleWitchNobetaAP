// ReSharper disable once CheckNamespace
namespace LittleWitchNobetaAP.Archipelago;

public class BossTrigger
{
    public StageId StageId { get; init; }
    public string SoulName { get; init; } = "";
    public string Trigger { get; init; } = "";
}

public static partial class ArchipelagoData
{
    public static class BossTriggers
    {
        public static readonly List<BossTrigger> Triggers = new()
        {
            new BossTrigger()
            {
                StageId = StageId.Shrine,
                SoulName = "Specter Armor Soul",
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/LoadScript"
            },
            new BossTrigger()
            {
                StageId = StageId.Shrine,
                SoulName = "Enraged Armor Soul",
                Trigger = "/SEM/AreaEvent/Room10/Other/LoadScriptRoom10"
            },
            new BossTrigger()
            {
                StageId = StageId.Underground,
                SoulName = "Tania Soul",
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/LoadScript"
            },
            new BossTrigger()
            {
                StageId = StageId.LavaRuins,
                SoulName = "Monica Soul",
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/LoadScript"
            },
            new BossTrigger()
            {
                StageId = StageId.DarkTunnel,
                SoulName = "Vanessa Soul",
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/LoadScript_Boss"
            },
            new BossTrigger()
            {
                StageId = StageId.SpiritRealm,
                SoulName = "Vanessa V2 Soul",
                Trigger = "/SEM/AreaEvent/RoomBoss/Other/LoadScriptRoomBoss"
            },
        };

        public static readonly Dictionary<string, BossTrigger> BySoulName =
            Triggers.ToDictionary(t => t.SoulName);
    }
}