using LittleWitchNobetaAP.Utils;
using UnityEngine;
using Il2Cpp;

// ReSharper disable once CheckNamespace
namespace LittleWitchNobetaAP.Archipelago;

public enum BarrierType
{
    MagicPuzzle,
    MetalGate,
}

public class BarrierMapping
{
    public StageId StageId { get; init; }
    public BarrierType Type { get; init; } = BarrierType.MagicPuzzle;
    public string LocationName { get; init; } = "";
    public string ItemName { get; init; } = "";
    public string TriggerPath { get; init; } = "";
    public List<BarrierAction> Actions { get; init; } = new();
}

public class StageLoadAction
{
    public StageId StageId { get; init; }
    public string? ItemName { get; init; }
    public List<BarrierAction> Actions { get; init; } = new();
}

public static partial class ArchipelagoData
{
    public static class Barriers
    {
        public static readonly List<BarrierMapping> BarrierMappings = new()
        {
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Shrine - First magic switch",
                ItemName = "Shrine First Magic Barrier",
                // Triggers when switch device destroyed
                TriggerPath = "/SEM/AreaEvent/Room03/Other/Room03_LoadScript",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room03/Other/MagicWall_Room03" },
                },
            },
            // Room04_02 should probably be disabled to prevent soft lock on random barriers,
            // although players can always return to shrine
            // Also /SEM/AreaEvent/Room04/Other/MagicWall_Room04_L is not disabled to prevent players
            // from breaking the switch without magic
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Shrine - Second magic switch",
                ItemName = "Shrine Second Magic Barrier",
                // Triggers when switch device behind barrier destroyed
                TriggerPath = "/SEM/AreaEvent/Room04/Other/LoadScript_Room04_02",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room04/Other/MagicWall_Room04" },
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room04/Other/MagicWall_Room04_02" },
                },
            },
            // Cutscene trigger for getting near room entrance, which forces player into room and creates barriers
            // SEM/AreaEvent/Room05/Other/Room05_LoadScript
            // May want to disable 04MagicWall01 to prevent softlock
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Shrine - Meet Cat barrier",
                ItemName = "Shrine Meet Cat Magic Barrier",
                // Triggers when enemies defeated and player gets near cat
                TriggerPath = "/SEM/AreaEvent/Room05/Other/Room05_LoadScript02",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room05/Other/04MagicWall01" },
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room05/Other/05MagicWall02" },
                },
            },
            // Should manually open magic wall to previous room if not unlocked as well
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                Type = BarrierType.MetalGate,
                LocationName = "Shrine - Underground shortcut gate switch",
                ItemName = "Shrine Underground Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room06_Save/Special/SceneSwitch01_Room06",
                Actions = new()
                {
                    new OpenDoorAction { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room06/Other/DoorBars01" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room07/Other/Tarp_Wall_Room07" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                Type = BarrierType.MetalGate,
                LocationName = "Secret Passage - Boss shortcut gate switch",
                ItemName = "Shrine Secret Boss Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room06_Save/Special/SceneSwitch02_Room06",
                Actions = new()
                {
                    new OpenDoorAction { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room06/Other/DoorBars02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Shrine - Secret passage magic switch",
                ItemName = "Secret Passage Entrance Magic Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room06To07/Other/LoadScript",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room06To07/Other/MagicWall_Room06To07" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                Type = BarrierType.MetalGate,
                LocationName = "Secret Passage - Secret area shortcut gate switch",
                ItemName = "Shrine Secret Area Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room06ToRoom07/Special/SceneSwitchRoom07To08",
                Actions = new()
                {
                    new OpenDoorAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room06To07/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Secret Passage - Defeat Enraged Armor barrier",
                ItemName = "Defeat Enraged Armor Barrier",
                // Triggers when boss is defeated
                TriggerPath = "/SEM/AreaEvent/Room10/Other/OpenScriptEvent_Room10",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room10/Other/05.MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Secret Passage - First fire barrier magic switch",
                ItemName = "Secret Passage First Fire Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room07/Other/LoadScript_Room06To07",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room07/Other/MagicWall_Room07" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                LocationName = "Secret Passage - Second fire barrier magic switch",
                ItemName = "Secret Passage Second Fire Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room09/Other/LoadScript_Room06To07",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room09/Other/MagicWall_Room09" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Shrine,
                Type = BarrierType.MetalGate,
                LocationName = "Secret Passage - Dark Tunnel shortcut gate switch",
                ItemName = "Secret Passage Dark Tunnel Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room08_Save/Special/SceneSwitchRoom08",
                Actions = new()
                {
                    new OpenDoorAction
                        { StageId = StageId.Shrine, Path = "/SEM/AreaEvent/Room08/Other/DoorBars01_Room08" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                LocationName = "Underground - Magic barrier switches at maid enemy",
                ItemName = "Underground Magic Barrier At Maid Enemy",
                // Triggers when 3 fire switches are destroyed
                TriggerPath = "/SEM/AreaEvent/Room06/Other/Room06_LoadScript",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room06/Other/MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                Type = BarrierType.MetalGate,
                LocationName = "Underground - Lava ruins shortcut gate switch",
                ItemName = "Underground Lava Ruins Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room07_Save/Special/SceneSwitch",
                Actions = new()
                {
                    new OpenDoorAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room07/Other/DoorBars_Room07_01" },
                    new OpenDoorAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room07/Other/DoorBars_Room07_02" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room07/Other/Tarp_Wall_Room07" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall01" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall02" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall03" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall04" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                Type = BarrierType.MetalGate,
                LocationName = "Underground - Tania shortcut switch on statue side",
                ItemName = "Underground Tania Shortcut Gate On Grand Hall Side",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room09To07/Other/SceneSwitch01",
                Actions = new()
                {
                    new OpenDoorAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room09To07/Other/DoorBars02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                LocationName = "Underground - After fire magic switch",
                ItemName = "Underground Fire Barrier Magic Barrier",
                // Triggers when switch inside fire trap is destroyed
                TriggerPath = "/SEM/AreaEvent/Room08/Other/Room08_LoadScript",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/MagicWall" },
                    new FireTrapReleaseAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/FireTrap" },
                    new FireTrapReleaseAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/FireTrap" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                Type = BarrierType.MetalGate,
                LocationName = "Underground - Tania shortcut switch on Tania side",
                ItemName = "Underground Tania Shortcut Gate On Tania Side",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room09To07/Other/SceneSwitch02",
                Actions = new()
                {
                    new OpenDoorAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room09To07/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                LocationName = "Underground - Defeat enemies barrier",
                ItemName = "Underground Enemy Magic Barrier",
                // Triggers when lever is flipped
                TriggerPath = "/SEM/AreaEvent/Room09/Other/MagicWall",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room09/Other/MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Underground,
                LocationName = "Underground - Tania boss arena barrier",
                ItemName = "Underground Tania Arena Barrier",
                // Triggers when Tania is defeated
                TriggerPath = "/SEM/AreaEvent/RoomBoss/Other/LoadScript02",
                Actions = new()
                {
                    new MagicWallReleaseAction
                    {
                        StageId = StageId.Underground,
                        Path = "/SEM/AreaEvent/RoomBoss/Other/10MagicWall02",
                    },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Magic platform switch at shotgun enemies",
                ItemName = "Lava Ruins Magic Platforms",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room02/Other/LoadScript",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room02/Other/MoveFloor01" },
                    new MoveFloorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room02/Other/MoveFloor02" },
                    new MoveFloorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room02/Other/MoveFloor03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                Type = BarrierType.MetalGate,
                LocationName = "Lava Ruins - Fake floor shortcut gate switch",
                ItemName = "Lava Ruins Fake Floor Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room01_Save/Special/SceneSwitchR",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/DoorBars01_02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Defeat scissor enemy barrier",
                ItemName = "Lava Ruins Scissor Enemy Barrier",
                // Triggers when magic wall release event triggers after defeating scissor enemy
                TriggerPath = "/SEM/AreaEvent/Room04/Other/MagicWall01",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room04/Other/MagicWall01" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room04/Other/MagicWall02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Lift magic switch at scissor enemy",
                ItemName = "Lava Ruins Scissor Enemy Lift",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room04/Other/LoadScript",
                Actions = new()
                {
                    new ElevatorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room04/Other/Elevator_Room04" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Fire magic switch",
                ItemName = "Lava Ruins Fire Magic Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room06/Other/LoadScript",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room06/Other/MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Activate moving ring",
                ItemName = "Lava Ruins Moving Ring",
                // Triggers when player gets near the activation prompt for the moving ring
                TriggerPath = "/SEM/AreaEvent/Room08/Other/OpenScriptRoom08On",
                Actions = new()
                {
                    new ElevatorAction()
                    {
                        StageId = StageId.LavaRuins,
                        Path = "/SEM/AreaEvent/Room08/Other/Elevator_Room08",
                        // We don't want to immediately start the movement on item received
                        DoNotExecuteOnItem = true,
                    },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                Type = BarrierType.MetalGate,
                LocationName = "Lava Ruins - Monica shortcut switch",
                ItemName = "Lava Ruins Monica Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room08ToBack/Special/SceneSwitch01",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room08ToBack/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                LocationName = "Lava Ruins - Monica boss arena barrier",
                ItemName = "Lava Ruins Monica Arena Barrier",
                // Triggers when Monica is defeated
                TriggerPath = "/SEM/AreaEvent/RoomBoss02/Other/LoadScriptBoss03",
                Actions = new()
                {
                    new MagicWallReleaseAction
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/RoomBoss/Other/MagicWall03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.LavaRuins,
                Type = BarrierType.MetalGate,
                LocationName = "Lava Ruins - Monica warp gate switch",
                ItemName = "Lava Ruins Monica Warp Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room01_Save/Special/SceneSwitchL",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/DoorBars01" },
                    new OpenDoorAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/DoorBars01 04" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - First magic barrier switch",
                ItemName = "Dark Tunnel First Magic Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room02/Other/LoadScript_Room02",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room02/Other/MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                Type = BarrierType.MetalGate,
                LocationName = "Dark Tunnel - First gate switch",
                ItemName = "Dark Tunnel First Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room02/Special/SceneSwitch",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room02/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - Light switch after getting the hat",
                ItemName = "Dark Tunnel Light Switch Barrier",
                // Triggers when crystal ball is filled with light
                TriggerPath = "/SEM/AreaEvent/Room01To02/Other/LoadScript_CrystalBallCompleteSlowMotion ",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room01To04/Other/MagicWall (1)" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - Thunder barrier magic switches",
                ItemName = "Dark Tunnel Thunder Barrier",
                // Triggers when three switches in thunder barrier room are destroyed
                TriggerPath = "/SEM/AreaEvent/Room06/Other/LoadScript_Room06",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (1)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (2)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (3)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (4)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (5)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (6)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (7)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (8)" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (9)" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - Floating platform switch one",
                ItemName = "Dark Tunnel Floating Platform One",
                // Triggers when middle switch is destroyed
                TriggerPath = "/Scene/Room07/Special/SwitchDevice (1)/AttackabclObject0701",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room07/Other/MoveFloor01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - Floating platform switch two",
                ItemName = "Dark Tunnel Floating Platform Two",
                // Triggers when right switch is destroyed
                TriggerPath = "/Scene/Room07/Special/SwitchDevice (2)/AttackabclObject0702",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room07/Other/MoveFloor02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.DarkTunnel,
                LocationName = "Dark Tunnel - Floating platform switch three",
                ItemName = "Dark Tunnel Floating Platform Three",
                // Triggers when left switch is destroyed
                TriggerPath = "/Scene/Room07/Special/SwitchDevice (3)/AttackabclObject0703",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room07/Other/MoveFloor03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                Type = BarrierType.MetalGate,
                LocationName = "Spirit Realm - Wind spell chest gate switch",
                ItemName = "Spirit Realm Wind Spell Chest Gate",
                // Triggers when lever is flipped.
                // Note this gate is useless but will require return to statue if not given.
                TriggerPath = "/Scene/Room02_Near/Special/SceneSwitch_R02",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room02/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                Type = BarrierType.MetalGate,
                LocationName = "Spirit Realm - Ice spell chest gate switch in right side alcove",
                ItemName = "Spirit Realm Ice Spell Chest Gate",
                // Triggers when lever is flipped.
                // Note this gate is useless but will require return to statue if not given.
                TriggerPath = "/Scene/Room04/Spical/SceneSwitch",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/L05Room04HiddenDoor" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Arcane barrier magic switches",
                ItemName = "Spirit Realm Arcane Barrier",
                // Triggers when the three switches are destroyed in a row
                TriggerPath = "/SEM/AreaEvent/Room04/Other/OpenScriptRoom04",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/00_MoveFloor01" },
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/01_MoveFloor02" },
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/02_MoveFloor03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Platform shortcut switch",
                ItemName = "Spirit Realm Platform Shortcut",
                // Triggers when the switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room04/Other/OpenScriptRoom04_02",
                Actions = new()
                {
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/00_MoveFloor01 (1)" },
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/01_MoveFloor02 (1)" },
                    new MoveFloorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room04/Other/02_MoveFloor03 (1)" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - First Seal magic barrier",
                ItemName = "Spirit Realm First Seal Magic Barrier",
                // Triggers when Seal (stage 1) is defeated
                TriggerPath = "/SEM/AreaEvent/Room05/Other/LoadScriptRoom05_02",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room05/Other/29_MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Second Seal magic barrier",
                ItemName = "Spirit Realm Second Seal Magic Barrier",
                // Triggers when Seal (stage 2) is defeated
                TriggerPath = "/SEM/AreaEvent/Room06/Other/03_MagicWall01",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room06/Other/03_MagicWall01" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room06/Other/04_MagicWall02" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room06/Other/05_MagicWall03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                Type = BarrierType.MetalGate,
                LocationName = "Spirit Realm - Statue shortcut gate switch",
                ItemName = "Spirit Realm Statue Shortcut Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room03To04_Save/Special/SceneSwitch_R03To04",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room03To04/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Elevator magic switch",
                ItemName = "Spirit Realm Elevator",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room07/Other/LoadScriptR0701",
                Actions = new()
                {
                    // This lift is a special class OpenDoor_Act06Room07MoveFloor that extends OpenDoor
                    new OpenDoorAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/00_MoveFloor" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Fire control magic switch",
                ItemName = "Spirit Realm Fire Deactivation",
                // Triggers when fire switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room07/Other/LoadScriptR0702",
                Actions = new()
                {
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap01" },
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap02" },
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap03" },
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap04" },
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap05" },
                    new FireTrapReleaseAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap06" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Magic switch barrier switch",
                ItemName = "Spirit Realm Magic Switch Barrier",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Room07/Special/SceneSwitch",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                    {
                        StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/MagicWall01",
                        DoNotExecuteOnItem = true,
                    },
                    new MagicWallReleaseAction()
                    {
                        StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/MagicWall02",
                        DoNotExecuteOnItem = true,
                    },
                    new MagicWallReleaseAction()
                    {
                        StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/MagicWall03",
                        DoNotExecuteOnItem = true,
                    },
                    new MagicWallReleaseAction()
                    {
                        StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/MagicWall04",
                        DoNotExecuteOnItem = true,
                    },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.SpiritRealm,
                LocationName = "Spirit Realm - Teleporter magic switch",
                ItemName = "Spirit Realm Teleporter",
                // Triggers when top switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Room07/Other/LoadScriptR0704",
                Actions = new()
                {
                    new TeleportEnableAction()
                        { StageId = StageId.SpiritRealm, Path = "/Scene/Special/PE_Teleport_Room07" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                Type = BarrierType.MetalGate,
                LocationName = "Abyss - First gate switch",
                ItemName = "Abyss First Gate",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Act02Room04/Special/SceneSwitch_RoomAct02",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/DoorBars01" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                Type = BarrierType.MetalGate,
                LocationName = "Abyss - Trap gate trigger",
                ItemName = "Abyss Trap Gates",
                // Triggers when player leaves the area
                TriggerPath = "/SEM/AreaEvent/Act02/AreaCreateEnemy/03_MonsterCallCreate",
                Actions = new()
                {
                    new OpenDoorAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/DoorBars02" },
                    new OpenDoorAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/DoorBars03" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Giant maid barrier",
                ItemName = "Abyss After Giant Maid Barrier",
                // Triggers when lever is flipped
                TriggerPath = "/SEM/AreaEvent/Act02/Other/MagicWall0201",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/MagicWall0201" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/MagicWall0202" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act02/Other/MagicWall0203" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Underground trial activate scissor enemies magic switch",
                ItemName = "Abyss Underground Trial Exit Barrier",
                // Triggers when switch in pit is destroyed, unlocking the exit barrier but activating stone enemies
                TriggerPath = "/SEM/AreaEvent/Act03/Other/LoadScript_RoomAct03",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act03/Other/MagicWall0101" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act03/Other/MagicWall0102" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Underground trial scissor enemy barrier",
                ItemName = "Abyss Underground Trial After Scissor Enemy Barrier",
                // Triggers when four stone maid enemies are killed in pit after previous switch
                // Useless item because player can just return to statue
                // This release is also not called if released earlier due to strange behavior with
                // the EnemyDeadEvent2 used to call it, so we shouldn't release barrier on item.
                TriggerPath = "/SEM/AreaEvent/Act03/Other/04_MagicWall0205",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                    {
                        StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act03/Other/04_MagicWall0205",
                        DoNotExecuteOnItem = true
                    },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Underground trial magic switch",
                ItemName = "Abyss Underground Trial Magic Switch",
                // Triggers when switch is destroyed
                TriggerPath = "/Scene/RoomCentral/Special/SwitchDevice_Strengthen (1)/AttackabclObject02_Act03",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0201" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0202" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0203" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Dark tunnel trial maid enemy barrier",
                ItemName = "Abyss Dark Tunnel Trial Maid Enemy Barrier",
                // Triggers when final maid enemy is killed
                TriggerPath = "/SEM/AreaEvent/Act05/Other/MagicWall01",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act05/Other/MagicWall01" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act05/Other/MagicWall02" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Dark Tunnel trial magic switch",
                ItemName = "Abyss Dark Tunnel Trial Magic Switch",
                // Triggers when switch is destroyed
                TriggerPath = "/Scene/RoomCentral/Special/SwitchDevice_Strengthen (2)/AttackabclObject03_Act05",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0301" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0302" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0303" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Lava Ruins trial lower lava switch",
                ItemName = "Abyss Lava Ruins Trial Lower Lava",
                // Triggers when lever is flipped
                TriggerPath = "/Scene/Act04Room05ToRoom06/Special/SceneSwitch",
                Actions = new()
                {
                    new MoveObjectAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act04/Other/00_MoveLava" },
                    new MoveObjectAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act04/Other/01_MoveLavaCollision" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Lava Ruins trial defeat maids enemy barrier",
                ItemName = "Abyss Lava Ruins Trial Maid Enemy Barrier",
                // Triggers when switch is destroyed
                TriggerPath = "/SEM/AreaEvent/Act04/Other/Flag_Act04Clear",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/Act04/Other/MagicWall" },
                },
            },
            new BarrierMapping()
            {
                StageId = StageId.Abyss,
                LocationName = "Abyss - Lava Ruins trial magic switch",
                ItemName = "Abyss Lava Ruins Trial Magic Switch",
                // Triggers when switch is destroyed
                TriggerPath = "/Scene/RoomCentral/Special/SwitchDevice_Strengthen/AttackabclObject01_Act04",
                Actions = new()
                {
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0101" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0102" },
                    new MagicWallReleaseAction()
                        { StageId = StageId.Abyss, Path = "/SEM/AreaEvent/RoomCentral/Other/MagicWall0103" },
                },
            },
        };

        // Barrier actions that are executed on scene load, used to disable things like trap walls, etc.
        // If an item name is specified, the action is only run if the player DOES NOT have the item.
        // This is because some barriers only activate when the player enters a room or triggers an event, meaning
        // it won't prevent players moving backwards during non-vanilla progression (randomized gates, etc.)
        private static readonly List<StageLoadAction> OnStageLoadActions = new()
        {
            // Below are stage load actions that always run ===============================================

            // Disable trap walls in Lava Ruins that push players into the lobby statue area,
            // normally released once the Monica Warp Gate switch is flipped.
            // Care should be taken here: Underground Tania Arena -> Lava Ruins After Monica Gates should not
            // be in logic without unlocking the gate item first.
            new StageLoadAction()
            {
                StageId = StageId.LavaRuins,
                Actions = new()
                {
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall01" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall02" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall03" },
                    new TrapWallReleaseAction()
                        { StageId = StageId.LavaRuins, Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall04" },
                }
            },
            // Disable Dark Tunnel to Lava Ruins door trap wall that prevents the door from being used
            // unless the Lava Ruins stage clear flag is toggled.
            new StageLoadAction()
            {
                StageId = StageId.DarkTunnel,
                Actions = new()
                {
                    new TrapWallReleaseAction() { Path = "/SEM/AreaEvent/Room01/Other/Tarp_Wall" },
                }
            },
            // Remove special DelayMoveFloor objects on the Dark Tunnel three floating platforms
            // as they cause an infinite loop of trying to open the event when the MoveFloor event is blocked
            new StageLoadAction()
            {
                StageId = StageId.DarkTunnel,
                Actions = new()
                {
                    new SpecialAction(() =>
                    {
                        if (ArchipelagoClient.ServerData.Settings?.ShortcutGateBehaviour ==
                            ArchipelagoSettings.ShortcutGateBehaviourType.Vanilla) return;
                        var delay1 = UnityUtils.FindObjectByPath("/SEM/AreaEvent/Room07/Other/DelayMoveFloor01");
                        var delay2 = UnityUtils.FindObjectByPath("/SEM/AreaEvent/Room07/Other/DelayMoveFloor02");
                        var delay3 = UnityUtils.FindObjectByPath("/SEM/AreaEvent/Room07/Other/DelayMoveFloor03");
                        UnityEngine.Object.Destroy(delay1);
                        UnityEngine.Object.Destroy(delay2);
                        UnityEngine.Object.Destroy(delay3);
                    })
                }
            },
            // Set delay for Abyss trap gate events to a large as possible to prevent the parent MultipleEventOpen event
            // from attempting to open the gates every frame when the player doesn't have the gate item.
            new StageLoadAction()
            {
                StageId = StageId.Abyss,
                Actions = new()
                {
                    new SpecialAction(() =>
                    {
                        if (ArchipelagoClient.ServerData.Settings?.ShortcutGateBehaviour ==
                            ArchipelagoSettings.ShortcutGateBehaviourType.Vanilla) return;
                        var trapDoorsEvent = UnityUtils.FindObjectByPath("/SEM/AreaEvent/Act02/Other/OpenDoor");
                        var multipleEventOpen = trapDoorsEvent?.GetComponent<MultipleEventOpen>();
                        if (multipleEventOpen is null || multipleEventOpen.DeltaTime.Length != 3) return;
                        multipleEventOpen.DeltaTime[0] = float.MaxValue;
                        multipleEventOpen.DeltaTime[1] = float.MaxValue;
                    })
                }
            },
            // Enables the cat prompt to get the absorption book item if it's in the scene
            // This overrides the expected state the game has for this prompt to keep the check always accessible
            new StageLoadAction()
            {
                StageId = StageId.Underground,
                Actions = new()
                {
                    new SpecialAction(() =>
                    {
                        var catBook = UnityUtils.FindObjectByPath("/SEM/AreaEvent/Room02/Other/CatBook");
                        if (catBook is null) return;
                        catBook.gameObject.SetActive(true);
                    })
                }
            },

            // Below are stage load actions with an associated item =====================================

            new StageLoadAction()
            {
                // This barrier only activates when the player enters the room from the start, meaning
                // it must be enabled to block backwards movement.
                StageId = StageId.Shrine,
                ItemName = "Shrine First Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room03/Other/MagicWall_Room03" }
                }
            },
            new StageLoadAction()
            {
                // The activation cutscene is right before the barrier. This is enabled to preserve logic,
                // and also prevents the second switch from showing when moving backwards without the barrier item.
                StageId = StageId.Shrine,
                ItemName = "Shrine Second Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room04/Other/MagicWall_Room04" }
                }
            },
            new StageLoadAction()
            {
                // Barrier normally only enables when entering from front, meaning won't block movement
                // from Enranged Armor arena room.
                StageId = StageId.Shrine,
                ItemName = "Secret Passage Second Fire Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room09/Other/MagicWall_Room09" }
                }
            },
            new StageLoadAction()
            {
                StageId = StageId.Shrine,
                ItemName = "Defeat Enraged Armor Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room10/Other/05.MagicWall" }
                }
            },
            new StageLoadAction()
            {
                StageId = StageId.Underground,
                ItemName = "Underground Magic Barrier At Maid Enemy",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room06/Other/MagicWall" }
                }
            },
            new StageLoadAction()
            {
                StageId = StageId.Underground,
                ItemName = "Underground Fire Barrier Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/MagicWall" },
                    new FireTrapStartAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/FireTrap" },
                    new FireTrapStartAction()
                        { StageId = StageId.Underground, Path = "/SEM/AreaEvent/Room08/Other/FireTrap" },
                },
            },
            new StageLoadAction()
            {
                StageId = StageId.Underground,
                ItemName = "Underground Enemy Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/Room09/Other/MagicWall" }
                }
            },

            new StageLoadAction()
            {
                // Barrier after Tania, blocking reverse movement (Lava Ruins -> Underground)
                // Also needed as Tania defeat flag will not be reset
                StageId = StageId.Underground,
                ItemName = "Underground Tania Arena Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/RoomBoss/Other/10MagicWall02" }
                }
            },
            new StageLoadAction()
            {
                // Barrier after Monica, only blocking moving to the teleporter.
                StageId = StageId.LavaRuins,
                ItemName = "Lava Ruins Monica Arena Barrier",
                Actions = new()
                {
                    new MagicWallStartAction() { Path = "/SEM/AreaEvent/RoomBoss/Other/MagicWall03" },
                    // Move arena barrier to next doorway, since in rare cases, if the player returns to statue
                    // after the fight but before picking up the 3 items, the items will move behind the barrier
                    // which could potentially cause an unbeatable state.
                    new SpecialAction(() =>
                    {
                        if (!(Singletons.GameSave?.flags.stage03Clear ?? false)) return;
                        if (ArchipelagoClient.ServerData.Settings?.BarrierBehaviour ==
                            ArchipelagoSettings.MagicPuzzleGateBehaviourType.Vanilla) return;
                        var wallCollision = UnityUtils.FindObjectByPath("/SceneManager/EnemyEffect/MagicWall(Clone)");
                        if (wallCollision is null) return;
                        wallCollision.transform.position = new Vector3(-132.6f, -20f, 320f);
                        wallCollision.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    })
                }
            },
            new StageLoadAction()
            {
                // This barrier only activates when entering the room from the front.
                StageId = StageId.DarkTunnel,
                ItemName = "Dark Tunnel Light Switch Barrier",
                Actions = new()
                {
                    new MagicWallStartAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room01To04/Other/MagicWall (1)" },
                }
            },
            new StageLoadAction()
            {
                // Disable thunder wall if that setting is enabled
                StageId = StageId.DarkTunnel,
                Actions = new()
                {
                    new MagicWallLightningReleaseOnOptionAction()
                    {
                        StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room05/Other/MagicWallLightning_Room05_01"
                    },
                    new MagicWallLightningReleaseOnOptionAction()
                    {
                        StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room05/Other/MagicWallLightning_Room05_02"
                    },
                    new MagicWallLightningReleaseOnOptionAction()
                    {
                        StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWallLightning_Room06"
                    },
                }
            },
            new StageLoadAction()
            {
                // These barriers only activate when entering the room from the front.
                StageId = StageId.DarkTunnel,
                ItemName = "Dark Tunnel Thunder Barrier",
                Actions = new()
                {
                    new MagicWallStartAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (4)" },
                    new MagicWallStartAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (5)" },
                    new MagicWallStartAction()
                        { StageId = StageId.DarkTunnel, Path = "/SEM/AreaEvent/Room06/Other/MagicWall (6)" },
                }
            },
            new StageLoadAction()
            {
                // Seal arena barriers only activate on boss trigger, which don't prevent backwards movement
                StageId = StageId.SpiritRealm,
                ItemName = "Spirit Realm First Seal Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room05/Other/29_MagicWall" },
                }
            },
            new StageLoadAction()
            {
                StageId = StageId.SpiritRealm,
                ItemName = "Spirit Realm Second Seal Magic Barrier",
                Actions = new()
                {
                    new MagicWallStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room06/Other/04_MagicWall02" },
                    new MagicWallStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room06/Other/05_MagicWall03" },
                }
            },
            new StageLoadAction()
            {
                StageId = StageId.SpiritRealm,
                ItemName = "Spirit Realm Fire Deactivation",
                Actions = new()
                {
                    // Normally only starts after first switch is destroyed and elevator activates
                    new FireTrapStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap01" },
                    new FireTrapStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap02" },
                    new FireTrapStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap03" },
                    new FireTrapStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap04" },
                    new FireTrapStartAction()
                        { StageId = StageId.SpiritRealm, Path = "/SEM/AreaEvent/Room07/Other/FireTrap05" },
                }
            }
        };

        public static readonly ILookup<string, BarrierMapping> ByTriggerPath =
            BarrierMappings.ToLookup(b => b.TriggerPath);

        public static readonly ILookup<string, BarrierMapping> ByItemName =
            BarrierMappings.ToLookup(b => b.ItemName);

        public static readonly Dictionary<int, ILookup<string, BarrierMapping>> ByActionPath = BarrierMappings
            .GroupBy(b => b.StageId)
            .ToDictionary(
                group => (int)group.Key,
                group => group.SelectMany(b => b.Actions.Select(action => new { action.Path, barrier = b }))
                    .ToLookup(x => x.Path, x => x.barrier)
            );

        public static readonly ILookup<int, StageLoadAction> OnStageLoadActionsByStageId =
            OnStageLoadActions.ToLookup(b => (int)b.StageId);
    }
}