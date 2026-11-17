using UnityEngine;

// ReSharper disable once CheckNamespace
namespace LittleWitchNobetaAP.Archipelago;

public enum BreakableItemType
{
    Jug,
    Barrel,
    Doll,
    Crystal,
}

public class BreakableItem
{
    public StageId StageId { get; init; }
    public BreakableItemType Type { get; init; }
    public string LocationName { get; init; } = "";

    public string Path { get; init; } = "";

    // Position is used since the path isn't guaranteed to be unique
    // For this rare case, we use the object position as well to differentiate which check it is
    public Vector3? Position { get; init; }
}

public static partial class ArchipelagoData
{
    public static class BreakableItems
    {
        private static readonly List<BreakableItem> ItemList = new()
        {
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first blue crystal 1", Path = "/Scene/Room02/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first blue crystal 2", Path = "/Scene/Room02/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first blue crystal 3", Path = "/Scene/Room02/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first blue crystal 4", Path = "/Scene/Room02/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first ranged enemy 1", Path = "/Scene/Room02/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first ranged enemy 2", Path = "/Scene/Room02/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near first ranged enemy 3", Path = "/Scene/Room02/Special/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 1", Path = "/Scene/Room03/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 2", Path = "/Scene/Room03/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 3", Path = "/Scene/Room03/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 4", Path = "/Scene/Room03/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 5", Path = "/Scene/Room03/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 6", Path = "/Scene/Room03/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 7", Path = "/Scene/Room03/Special/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 8", Path = "/Scene/Room03/Special/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 9", Path = "/Scene/Room03/Special/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 10", Path = "/Scene/Room03/Special/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 11", Path = "/Scene/Room03/Special/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 12", Path = "/Scene/Room03/Special/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 13", Path = "/Scene/Room03/Special/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in first barrier room 14", Path = "/Scene/Room03/Special/DamageJug (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug, LocationName = "Shrine - Jug in side alcove 1",
                Path = "/Scene/Room03/Special/DamageJug (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug, LocationName = "Shrine - Jug in side alcove 2",
                Path = "/Scene/Room03/Special/DamageJug (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Shrine - Barrel in grand gallery statue room 1",
                Path = "/Scene/Room03ToRoom04_Save/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Shrine - Barrel in grand gallery statue room 2",
                Path = "/Scene/Room03ToRoom04_Save/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 1", Path = "/Scene/Room04/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 2", Path = "/Scene/Room04/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 3", Path = "/Scene/Room04/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 4", Path = "/Scene/Room04/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 5", Path = "/Scene/Room04/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug near second blue crystal 6", Path = "/Scene/Room04/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room 1", Path = "/Scene/Room05/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room 2", Path = "/Scene/Room05/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room 3", Path = "/Scene/Room05/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room 4", Path = "/Scene/Room05/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room 5", Path = "/Scene/Room05/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug in meet cat room behind bars", Path = "/Scene/Room05/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug besides Grand Hall statue 1", Path = "/Scene/Room06_Save/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug besides Grand Hall statue 2",
                Path = "/Scene/Room06_Save/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug behind Underground shortcut gate 1",
                Path = "/Scene/Room06_Save/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug behind Underground shortcut gate 2",
                Path = "/Scene/Room06_Save/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug behind Secret Boss gate 1",
                Path = "/Scene/Room06_Save/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Shrine - Jug behind Secret Boss gate 2",
                Path = "/Scene/Room06_Save/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Shrine - Barrel before boss 1", Path = "/Scene/Room_Boss/Special/DamageBarrel01"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Shrine - Barrel before boss 2", Path = "/Scene/Room_Boss/Special/DamageBarrel02"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Shrine - Barrel before boss 3", Path = "/Scene/Room_Boss/Special/DamageBarrel03"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug after first drop near stairs 1",
                Path = "/Scene/Room07/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug after first drop near stairs 2",
                Path = "/Scene/Room07/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug after first drop near stairs 3",
                Path = "/Scene/Room07/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug after first drop near stairs 4",
                Path = "/Scene/Room07/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug after first drop near stairs 5",
                Path = "/Scene/Room07/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 1",
                Path = "/Scene/Room07/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 2",
                Path = "/Scene/Room07/Special/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 3",
                Path = "/Scene/Room07/Special/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 4",
                Path = "/Scene/Room07/Special/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 5",
                Path = "/Scene/Room07/Special/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room 6",
                Path = "/Scene/Room07/Special/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room hallway 1",
                Path = "/Scene/Room07/Special/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room hallway 2",
                Path = "/Scene/Room07/Special/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room hallway 3",
                Path = "/Scene/Room07/Special/DamageJug (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room stairwell 1",
                Path = "/Scene/Room07/Special/DamageJug (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room stairwell 2",
                Path = "/Scene/Room07/Special/DamageJug (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room stairwell 3",
                Path = "/Scene/Room07/Special/DamageJug (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in first fire barrier room stairwell 4",
                Path = "/Scene/Room07/Special/DamageJug (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in hallway after first fire barrier 1",
                Path = "/Scene/Room07ToRoom08/Special/DamageJug (18)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in hallway after first fire barrier 2",
                Path = "/Scene/Room07ToRoom08/Special/DamageJug (19)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in hallway after first fire barrier 3",
                Path = "/Scene/Room07ToRoom08/Special/DamageJug (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug besides second fire barrier 1",
                Path = "/Scene/Room09/Special/DamageJug (40)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug besides second fire barrier 2",
                Path = "/Scene/Room09/Special/DamageJug (41)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug besides second fire barrier 3",
                Path = "/Scene/Room09/Special/DamageJug (42)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on first floor of second fire barrier room 1",
                Path = "/Scene/Room09/Special/DamageJug (43)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on first floor of second fire barrier room 2",
                Path = "/Scene/Room09/Special/DamageJug (44)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on first floor of second fire barrier room 3",
                Path = "/Scene/Room09/Special/DamageJug (45)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on first floor of second fire barrier room 4",
                Path = "/Scene/Room09/Special/DamageJug (46)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on first floor of second fire barrier room 5",
                Path = "/Scene/Room09/Special/DamageJug (47)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel near second fire barrier switch",
                Path = "/Scene/Room09/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug right before secret boss 1",
                Path = "/Scene/Room09ToRoom10/Special/DamageJug (48)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug right before secret boss 2",
                Path = "/Scene/Room09ToRoom10/Special/DamageJug (49)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel right before secret boss 1",
                Path = "/Scene/Room09ToRoom10/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel right before secret boss 2",
                Path = "/Scene/Room09ToRoom10/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 1",
                Path = "/Scene/Room10/Special/DamageJug (50)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 2",
                Path = "/Scene/Room10/Special/DamageJug (51)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 3",
                Path = "/Scene/Room10/Special/DamageJug (52)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 4",
                Path = "/Scene/Room10/Special/DamageJug (53)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 5",
                Path = "/Scene/Room10/Special/DamageJug (60)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 6",
                Path = "/Scene/Room10/Special/DamageJug (61)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 7",
                Path = "/Scene/Room10/Special/DamageJug (62)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in secret boss arena 8",
                Path = "/Scene/Room10/Special/DamageJug (63)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena 1",
                Path = "/Scene/Room10/Special/DamageJug (54)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena 2",
                Path = "/Scene/Room10/Special/DamageJug (55)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena near chest 1",
                Path = "/Scene/Room10/Special/DamageJug (56)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena near chest 2",
                Path = "/Scene/Room10/Special/DamageJug (57)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena near chest 3",
                Path = "/Scene/Room10/Special/DamageJug (58)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug above secret boss arena near chest 4",
                Path = "/Scene/Room10/Special/DamageJug (59)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel besides secret passage statue 1",
                Path = "/Scene/Room08_Save/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel besides secret passage statue 2",
                Path = "/Scene/Room08_Save/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Barrel,
                LocationName = "Secret Passage - Barrel besides secret passage statue 3",
                Path = "/Scene/Room08_Save/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in hallway after secret passage statue 1",
                Path = "/Scene/Room08_Save/Special/DamageJug (36)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug in hallway after secret passage statue 2",
                Path = "/Scene/Room08_Save/Special/DamageJug (37)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug before drop to second fire barrier switch 1",
                Path = "/Scene/Room08ToRoom09/Special/DamageJug (38)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug before drop to second fire barrier switch 2",
                Path = "/Scene/Room08ToRoom09/Special/DamageJug (39)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 1",
                Path = "/Scene/Room08_Save/Special/DamageJug (29)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 2",
                Path = "/Scene/Room08_Save/Special/DamageJug (30)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 3",
                Path = "/Scene/Room08_Save/Special/DamageJug (31)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 4",
                Path = "/Scene/Room08_Save/Special/DamageJug (32)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 5",
                Path = "/Scene/Room08_Save/Special/DamageJug (33)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 6",
                Path = "/Scene/Room08_Save/Special/DamageJug (34)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on upper level of spiral staircase 7",
                Path = "/Scene/Room08_Save/Special/DamageJug (35)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 1",
                Path = "/Scene/Room08_Save/Special/DamageJug (21)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 2",
                Path = "/Scene/Room08_Save/Special/DamageJug (22)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 3",
                Path = "/Scene/Room08_Save/Special/DamageJug (23)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 4",
                Path = "/Scene/Room08_Save/Special/DamageJug (24)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 5",
                Path = "/Scene/Room08_Save/Special/DamageJug (25)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 6",
                Path = "/Scene/Room08_Save/Special/DamageJug (26)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 7",
                Path = "/Scene/Room08_Save/Special/DamageJug (27)"
            },
            new BreakableItem
            {
                StageId = StageId.Shrine, Type = BreakableItemType.Jug,
                LocationName = "Secret Passage - Jug on lower level of spiral staircase 8",
                Path = "/Scene/Room08_Save/Special/DamageJug (28)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near first goddess statue 1",
                Path = "/Scene/Room02_Save/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near first goddess statue 2",
                Path = "/Scene/Room02_Save/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near first goddess statue 3",
                Path = "/Scene/Room02_Save/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll near first goddess statue 1",
                Path = "/Scene/Room02ToRoom03/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll near first goddess statue 2",
                Path = "/Scene/Room02ToRoom03/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll near first goddess statue 3",
                Path = "/Scene/Room02ToRoom03/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll near first goddess statue 4",
                Path = "/Scene/Room02ToRoom03/Special/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in falling rock room 1",
                Path = "/Scene/Room03/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in falling rock room 2",
                Path = "/Scene/Room03/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 1",
                Path = "/Scene/Room03/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 2",
                Path = "/Scene/Room03/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 3",
                Path = "/Scene/Room03/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 4",
                Path = "/Scene/Room03/Special/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 5",
                Path = "/Scene/Room03/Special/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 6",
                Path = "/Scene/Room03/Special/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 7",
                Path = "/Scene/Room03/Special/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in falling rock room 8",
                Path = "/Scene/Room03/Special/DamageDollWeak03 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in wooden ramp scaffolding room 1",
                Path = "/Scene/Room04/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in wooden ramp scaffolding room 2",
                Path = "/Scene/Room04ToRoom05/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in wooden ramp scaffolding room 1",
                Path = "/Scene/Room04/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in wooden ramp scaffolding room 2",
                Path = "/Scene/Room04/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in wooden ramp scaffolding room 3",
                Path = "/Scene/Room04/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in wooden ramp scaffolding room 4",
                Path = "/Scene/Room04/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in wooden ramp scaffolding room 5",
                Path = "/Scene/Room04/Special/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll before large mushroom room",
                Path = "/Scene/Room04ToRoom05/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel before large mushroom room",
                Path = "/Scene/Room04ToRoom05/Special/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel on large mushroom room upper path 1",
                Path = "/Scene/Room05/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel on large mushroom room upper path 2",
                Path = "/Scene/Room05/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel on large mushroom room upper path 3",
                Path = "/Scene/Room05/Special/DamageBarrel (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel on large mushroom room upper path 4",
                Path = "/Scene/Room05/Special/DamageBarrel (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel on large mushroom room circular ramp",
                Path = "/Scene/Room05/Special/DamageBarrel (22)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 1",
                Path = "/Scene/Room05/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 2",
                Path = "/Scene/Room05/Special/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 3",
                Path = "/Scene/Room05/Special/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 4",
                Path = "/Scene/Room05/Special/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 5",
                Path = "/Scene/Room05/Special/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 6",
                Path = "/Scene/Room05/Special/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 7",
                Path = "/Scene/Room05/Special/DamageBarrel (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 8",
                Path = "/Scene/Room05/Special/DamageBarrel (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 9",
                Path = "/Scene/Room05/Special/DamageBarrel (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 10",
                Path = "/Scene/Room05/Special/DamageBarrel (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 11",
                Path = "/Scene/Room05/Special/DamageBarrel (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in large mushroom room pit 12",
                Path = "/Scene/Room05/Special/DamageBarrel (21)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll on large mushroom room upper path 1",
                Path = "/Scene/Room05/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll on large mushroom room upper path 2",
                Path = "/Scene/Room05/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll on large mushroom room upper path 3",
                Path = "/Scene/Room05/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll on large mushroom room ledge with chest 1",
                Path = "/Scene/Room05/Special/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll on large mushroom room ledge with chest 2",
                Path = "/Scene/Room05/Special/DamageDollWeak (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in large mushroom room pit 1",
                Path = "/Scene/Room05/Special/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in large mushroom room pit 2",
                Path = "/Scene/Room05/Special/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in large mushroom room pit 3",
                Path = "/Scene/Room05/Special/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in large mushroom room pit 4",
                Path = "/Scene/Room05/Special/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in pathway after large mushroom room 1",
                Path = "/Scene/Room05ToRoom06/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in pathway after large mushroom room 2",
                Path = "/Scene/Room05ToRoom06/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in pathway after large mushroom room 1",
                Path = "/Scene/Room05ToRoom06/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in pathway after large mushroom room 2",
                Path = "/Scene/Room05ToRoom06/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in pathway after large mushroom room 3",
                Path = "/Scene/Room05ToRoom06/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug near grand hall statue 1",
                Path = "/Scene/Room07_Save/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug near grand hall statue 2",
                Path = "/Scene/Room07_Save/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug near grand hall statue 3",
                Path = "/Scene/Room07_Save/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near fire barrier blue crystal 1",
                Path = "/Scene/Room07To08/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near fire barrier blue crystal 2",
                Path = "/Scene/Room07To08/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel near fire barrier blue crystal 3",
                Path = "/Scene/Room07To08/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 1",
                Path = "/Scene/Room08/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 2",
                Path = "/Scene/Room08/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 3",
                Path = "/Scene/Room08/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 4",
                Path = "/Scene/Room08/Special/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 5",
                Path = "/Scene/Room08/Special/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 6",
                Path = "/Scene/Room08/Special/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in fire barrier spiral staircase room 7",
                Path = "/Scene/Room08/Special/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in fire barrier spiral staircase room 1",
                Path = "/Scene/Room08/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in fire barrier spiral staircase room 2",
                Path = "/Scene/Room08/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in hall after spiral staircase 1",
                Path = "/Scene/Room08To09/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in hall after spiral staircase 2",
                Path = "/Scene/Room08To09/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in hall after spiral staircase 3",
                Path = "/Scene/Room08To09/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in hall after spiral staircase 4",
                Path = "/Scene/Room08To09/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in hall after spiral staircase 1",
                Path = "/Scene/Room08To09/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in hall after spiral staircase 2",
                Path = "/Scene/Room08To09/Special/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in hall after spiral staircase 3",
                Path = "/Scene/Room08To09/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in hall after spiral staircase 4",
                Path = "/Scene/Room08To09/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 1",
                Path = "/Scene/Room09/Special/DamageDollWeak (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 2",
                Path = "/Scene/Room09/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 3",
                Path = "/Scene/Room09/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 4",
                Path = "/Scene/Room09/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 5",
                Path = "/Scene/Room09/Special/DamageDollWeak02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 6",
                Path = "/Scene/Room09/Special/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 7",
                Path = "/Scene/Room09/Special/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 8",
                Path = "/Scene/Room09/Special/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 9",
                Path = "/Scene/Room09/Special/DamageDollWeak03 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 10",
                Path = "/Scene/Room09/Special/DamageDollWeak02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 11",
                Path = "/Scene/Room09/Special/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 12",
                Path = "/Scene/Room09/Special/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 13",
                Path = "/Scene/Room09/Special/DamageDollWeak03 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 14",
                Path = "/Scene/Room09/Special/DamageDollWeak02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 15",
                Path = "/Scene/Room09/Special/DamageDollWeak (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 16",
                Path = "/Scene/Room09/Special/DamageDollWeak (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 17",
                Path = "/Scene/Room09/Special/DamageDollWeak03 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 18",
                Path = "/Scene/Room09/Special/DamageDollWeak (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in broken doll room 19",
                Path = "/Scene/Room09/Special/DamageDollWeak02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in Tania arena 1",
                Path = "/Scene/RoomBoss/Object/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in Tania arena 2",
                Path = "/Scene/RoomBoss/Object/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Barrel,
                LocationName = "Underground - Barrel in Tania arena 3",
                Path = "/Scene/RoomBoss/Object/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 1",
                Path = "/Scene/RoomBoss/Object/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 2",
                Path = "/Scene/RoomBoss/Object/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 3",
                Path = "/Scene/RoomBoss/Object/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 4",
                Path = "/Scene/RoomBoss/Object/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 5",
                Path = "/Scene/RoomBoss/Object/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Jug,
                LocationName = "Underground - Jug in Tania arena 6",
                Path = "/Scene/RoomBoss/Object/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 1",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 2",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 3",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak03 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 4",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 5",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 6",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 7",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 8",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 9",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 10",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 11",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 12",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 13",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak03 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 14",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Underground, Type = BreakableItemType.Doll,
                LocationName = "Underground - Doll in Tania arena 15",
                Path = "/Scene/RoomBoss/Object/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near lobby statue 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel",
                Position = new Vector3(-34.290f, -4.000f, 27.950f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near lobby statue 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (1)",
                Position = new Vector3(-32.745f, -4.000f, 28.277f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel",
                Position = new Vector3(7.470f, 0.000f, 30.550f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (1)",
                Position = new Vector3(7.480f, 0.000f, 29.550f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 4",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 5",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 6",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near Dark Tunnel exit 7",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near lobby statue 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug",
                Position = new Vector3(-31.836f, -4.000f, 27.395f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near lobby statue 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (1)",
                Position = new Vector3(-48.811f, -4.000f, 27.965f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near lobby statue 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (2)",
                Position = new Vector3(-48.052f, -4.000f, 27.965f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug",
                Position = new Vector3(2.298f, 0.000f, 10.271f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (1)",
                Position = new Vector3(3.608f, 0.000f, 11.066f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (2)",
                Position = new Vector3(2.686f, 0.000f, 11.105f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 4",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 5",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 6",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near Dark Tunnel exit 7",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in hallway after lobby",
                Path = "/Scene/Room01ToRoom02/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in hallway after lobby",
                Path = "/Scene/Room01ToRoom02/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near rising platforms room entrance 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near rising platforms room entrance 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony bottom floor 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony bottom floor 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony bottom floor 3",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony bottom floor 4",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony top floor 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony top floor 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel on rising platforms room left balcony top floor 3",
                Path = "/Scene/Room02/DamagedObjedt/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room entrance 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room entrance 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room entrance 3",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room center 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room center 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near rising platforms room center 3",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on rising platforms room right balcony top floor 1",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on rising platforms room right balcony top floor 2",
                Path = "/Scene/Room02/DamagedObjedt/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in hallway north of rising platforms room 1",
                Path = "/Scene/Room02ToRoom03/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in hallway north of rising platforms room 2",
                Path = "/Scene/Room02ToRoom03/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in hallway north of rising platforms room",
                Path = "/Scene/Room02ToRoom03/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in breakable wall hidden path after rising platforms 1",
                Path = "/Scene/Room02ToRoom04/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in breakable wall hidden path after rising platforms 2",
                Path = "/Scene/Room02ToRoom04/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll on top floor after rising platforms 1",
                Path = "/Scene/Room02ToRoom04/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll on top floor after rising platforms 2",
                Path = "/Scene/Room02ToRoom04/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll on top floor after rising platforms 3",
                Path = "/Scene/Room02ToRoom04/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on stair landing after rising platforms 1",
                Path = "/Scene/Room02ToRoom04/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on stair landing after rising platforms 2",
                Path = "/Scene/Room02ToRoom04/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room with hidden dropdown path 1",
                Path = "/Scene/Room03/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room with hidden dropdown path 2",
                Path = "/Scene/Room03/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room with hidden dropdown path 3",
                Path = "/Scene/Room03/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room with hidden dropdown path 4",
                Path = "/Scene/Room03/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel at top ledge in broken floor room after hidden dropdown path 1",
                Path = "/Scene/Room03/Special/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel at top ledge in broken floor room after hidden dropdown path 2",
                Path = "/Scene/Room03/Special/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel at top ledge in broken floor room after hidden dropdown path 3",
                Path = "/Scene/Room03/Special/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel at top ledge in broken floor room after hidden dropdown path 4",
                Path = "/Scene/Room03/Special/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel at top ledge in broken floor room after hidden dropdown path 5",
                Path = "/Scene/Room03/Special/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room at start of hidden dropdown path 1",
                Path = "/Scene/Room03/Special/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in broken floor room at start of hidden dropdown path 2",
                Path = "/Scene/Room03/Special/DamageBarrel (10)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near edge in broken floor room",
                Path = "/Scene/Room03/Special/DamageJug",
                Position = new Vector3(-161.500f, -4.000f, 153.660f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in hallway after broken floor room 1",
                Path = "/Scene/Room03/Special/DamageJug (1)",
                Position = new Vector3(-157.000f, -4.000f, 129.660f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in hallway after broken floor room 2",
                Path = "/Scene/Room03/Special/DamageJug (2)",
                Position = new Vector3(-158.000f, -4.000f, 129.660f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Barrel in broken floor room hidden dropdown path hallway 1",
                Path = "/Scene/Room03/Special/DamageJug (3)",
                Position = new Vector3(-187.000f, -8.000f, 178.660f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Barrel in broken floor room hidden dropdown path hallway 2",
                Path = "/Scene/Room03/Special/DamageJug (4)",
                Position = new Vector3(-187.500f, -8.000f, 178.160f)
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near fake floor 1",
                Path = "/Scene/Room04/DamagedObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near fake floor 2",
                Path = "/Scene/Room04/DamagedObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near fake floor 3",
                Path = "/Scene/Room04/DamagedObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in spewing lava room 1",
                Path = "/Scene/Room05ToRoom06/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in spewing lava room 2",
                Path = "/Scene/Room05ToRoom06/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in spewing lava room 1",
                Path = "/Scene/Room05ToRoom06/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in spewing lava room 2",
                Path = "/Scene/Room05ToRoom06/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near fire spell chest",
                Path = "/Scene/Room06/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near fire spell chest 1",
                Path = "/Scene/Room06/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near fire spell chest 2",
                Path = "/Scene/Room06/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug above fire spell chest double staircase 1",
                Path = "/Scene/Room06/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug above fire spell chest double staircase 2",
                Path = "/Scene/Room06/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug above fire spell chest double staircase 3",
                Path = "/Scene/Room06/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in lava maze room top left 1",
                Path = "/Scene/Room07/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in lava maze room top left 2",
                Path = "/Scene/Room07/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in lava maze room top left 3",
                Path = "/Scene/Room07/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel in lava maze room top left 4",
                Path = "/Scene/Room07/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll in lava maze room center 1",
                Path = "/Scene/Room07/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll in lava maze room center 2",
                Path = "/Scene/Room07/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Doll,
                LocationName = "Lava Ruins - Doll in lava maze room center 3",
                Path = "/Scene/Room07/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug at start of lava maze room 1",
                Path = "/Scene/Room07/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug at start of lava maze room 2",
                Path = "/Scene/Room07/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug at start of lava maze room 3",
                Path = "/Scene/Room07/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near exit of lava maze room 1",
                Path = "/Scene/Room07/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near exit of lava maze room 2",
                Path = "/Scene/Room07/Special/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near exit of lava maze room 3",
                Path = "/Scene/Room07/Special/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in lava maze room center 1",
                Path = "/Scene/Room07/Special/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug in lava maze room center 2",
                Path = "/Scene/Room07/Special/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near moving ring lava maze side 1",
                Path = "/Scene/Room08/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near moving ring lava maze side 2",
                Path = "/Scene/Room08/Special/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near moving ring lava maze side 3",
                Path = "/Scene/Room08/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near moving ring Monica side 1",
                Path = "/Scene/Room08/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near moving ring Monica side 2",
                Path = "/Scene/Room08/Special/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on moving ring jumping puzzle staircase platform 1",
                Path = "/Scene/Room08/Special/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on moving ring jumping puzzle staircase platform 2",
                Path = "/Scene/Room08/Special/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug on moving ring jumping puzzle staircase platform 3",
                Path = "/Scene/Room08/Special/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Jug,
                LocationName = "Lava Ruins - Jug near moving ring jumping puzzle chest",
                Path = "/Scene/Room08/Special/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near dead end statue 1",
                Path = "/Scene/Room09_Save/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near dead end statue 2",
                Path = "/Scene/Room09_Save/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near dead end statue 3",
                Path = "/Scene/Room09_Save/Special/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.LavaRuins, Type = BreakableItemType.Barrel,
                LocationName = "Lava Ruins - Barrel near dead end statue 4",
                Path = "/Scene/Room09_Save/Special/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first statue 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first statue 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first statue 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first statue 4",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Underground exit door 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Underground exit door 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Underground exit door 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Underground exit door 4",
                Path = "/Scene/Room01_Save/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near Underground exit door 1",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near Underground exit door 2",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near Underground exit door 3",
                Path = "/Scene/Room01_Save/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll before light switch barrier 1",
                Path = "/Scene/Room01To04/DamageObject/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll before light switch barrier 2",
                Path = "/Scene/Room01To04/DamageObject/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 1",
                Path = "/Scene/Room01To04/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 2",
                Path = "/Scene/Room01To04/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 3",
                Path = "/Scene/Room01To04/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 4",
                Path = "/Scene/Room01To04/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 5",
                Path = "/Scene/Room01To04/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug before light switch barrier 6",
                Path = "/Scene/Room01To04/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first magic switch 1",
                Path = "/Scene/Room02/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first magic switch 2",
                Path = "/Scene/Room02/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near ledge before first magic barrier 1",
                Path = "/Scene/Room02/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near ledge before first magic barrier 2",
                Path = "/Scene/Room02/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near ledge before first magic barrier 3",
                Path = "/Scene/Room02/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll near first magic switch",
                Path = "/Scene/Room02/DamageObject/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near first magic switch 1",
                Path = "/Scene/Room02/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near first magic switch 2",
                Path = "/Scene/Room02/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near chest peekhole wall 1",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near chest peekhole wall 2",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll near chest peekhole wall",
                Path = "/Scene/Room02To0103/DamageObject/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near chest peekhole wall 1",
                Path = "/Scene/Room02To0103/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near chest peekhole wall 2",
                Path = "/Scene/Room02To0103/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in hallway before hat 1",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in hallway before hat 2",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in hallway before hat",
                Path = "/Scene/Room02To0103/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel right before hat 1",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel right before hat 2",
                Path = "/Scene/Room02To0103/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug right before hat",
                Path = "/Scene/Room02To0103/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near first mimic chest",
                Path = "/Scene/Room03/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on ledge near first mimic chest 1",
                Path = "/Scene/Room03/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on ledge near first mimic chest 2",
                Path = "/Scene/Room03/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on broken staircase after first mimic chest",
                Path = "/Scene/Room03/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of broken staircase near dark hole",
                Path = "/Scene/Room03/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first mimic chest 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near first mimic chest 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel on broken staircase after first mimic chest 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel on broken staircase after first mimic chest 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel on broken staircase after first mimic chest 3",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel on broken staircase after first mimic chest 4",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near broken staircase after first mimic chest 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near broken staircase after first mimic chest 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel before broken staircase jump after first mimic chest 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel before broken staircase jump after first mimic chest 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel before broken staircase jump after first mimic chest 3",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (10)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near scaffolding 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (11)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near scaffolding 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (12)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near dark hole 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (13)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near dark hole 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (14)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near hat exit 1",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (15)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near hat exit 2",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (16)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at top of broken staircase near hat exit 3",
                Path = "/Scene/Room03/DamageObject/DamageBarrel (17)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 1",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 2",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 3",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 4",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 5",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 6",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 7",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 8",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark hole with wind spell chest 9",
                Path = "/Scene/Room03/DamageObject/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near entrance stairs above dark maze 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near entrance stairs above dark maze 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near entrance stairs above dark maze 3",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near puppeteer above dark maze 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near puppeteer above dark maze 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze near light orb 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze near light orb 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze below puppeteer 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze below puppeteer 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze near chest 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze near chest 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (10)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze near chest 3",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (12)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze at bottom of chest staircase 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (13)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze at bottom of chest staircase 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (14)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze at bottom of southmost staircase 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (15)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in dark maze at bottom of southmost staircase 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (16)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel above dark maze near exit 1",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (17)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel above dark maze near exit 2",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (18)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze near chest 1",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze near chest 2",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze near chest 3",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze near chest 4",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze at bottom of staircase near puppeteer",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll in dark maze near light orb",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug above dark maze near exit staircase",
                Path = "/Scene/Room04/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug above dark maze at top of chest staircase 1",
                Path = "/Scene/Room04/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug above dark maze at top of chest staircase 2",
                Path = "/Scene/Room04/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark maze at bottom of chest staircase",
                Path = "/Scene/Room04/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark maze near southmost staircase 1",
                Path = "/Scene/Room04/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark maze near southmost staircase 2",
                Path = "/Scene/Room04/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark maze near light orb",
                Path = "/Scene/Room04/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at end of dark maze",
                Path = "/Scene/Room04/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Doll,
                LocationName = "Dark Tunnel - Doll at end of dark maze",
                Path = "/Scene/Room04/DamageObject/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel at end of dark maze",
                Path = "/Scene/Room04/DamageObject/DamageBarrel (19)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel before mimic chest room",
                Path = "/Scene/Room05/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in mimic chest room",
                Path = "/Scene/Room05/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 1",
                Path = "/Scene/Room05/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 2",
                Path = "/Scene/Room05/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 3",
                Path = "/Scene/Room05/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 4",
                Path = "/Scene/Room05/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 5",
                Path = "/Scene/Room05/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 6",
                Path = "/Scene/Room05/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in mimic chest room 7",
                Path = "/Scene/Room05/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark room before depths statue 1",
                Path = "/Scene/Room05/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in dark room before depths statue 2",
                Path = "/Scene/Room05/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near depths statue 1",
                Path = "/Scene/Room05To06_Save/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near depths statue 2",
                Path = "/Scene/Room05To06_Save/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near depths statue 3",
                Path = "/Scene/Room05To06_Save/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near depths statue 4",
                Path = "/Scene/Room05To06_Save/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 1",
                Path = "/Scene/Room06/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 2",
                Path = "/Scene/Room06/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 3",
                Path = "/Scene/Room06/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 4",
                Path = "/Scene/Room06/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 5",
                Path = "/Scene/Room06/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 6",
                Path = "/Scene/Room06/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 7",
                Path = "/Scene/Room06/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near thunder barrier blue crystal 8",
                Path = "/Scene/Room06/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in path after thunder barrier 1",
                Path = "/Scene/Room06To07/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in path after thunder barrier 2",
                Path = "/Scene/Room06To07/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in path after thunder barrier 3",
                Path = "/Scene/Room06To07/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near floating platforms blue crystal 1",
                Path = "/Scene/Room07/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near floating platforms blue crystal 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near floating platforms blue crystal 3",
                Path = "/Scene/Room07/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near floating platforms blue crystal 4",
                Path = "/Scene/Room07/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near floating platforms blue crystal 5",
                Path = "/Scene/Room07/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in side room right before floating platforms 1",
                Path = "/Scene/Room07/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in side room right before floating platforms 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in side room right before floating platforms 3",
                Path = "/Scene/Room07/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in side room right before floating platforms 4",
                Path = "/Scene/Room07/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in side room right before floating platforms 5",
                Path = "/Scene/Room07/DamageObject/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug below floating platform switches 1",
                Path = "/Scene/Room07/DamageObject/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug below floating platform switches 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 1",
                Path = "/Scene/Room07/DamageObject/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (13)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 3",
                Path = "/Scene/Room07/DamageObject/DamageJug (14)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 4",
                Path = "/Scene/Room07/DamageObject/DamageJug (15)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 5",
                Path = "/Scene/Room07/DamageObject/DamageJug (16)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on bottom floor after floating platforms 6",
                Path = "/Scene/Room07/DamageObject/DamageJug (17)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 1",
                Path = "/Scene/Room07/DamageObject/DamageJug (18)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (19)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 3",
                Path = "/Scene/Room07/DamageObject/DamageJug (20)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 4",
                Path = "/Scene/Room07/DamageObject/DamageJug (21)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 5",
                Path = "/Scene/Room07/DamageObject/DamageJug (22)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 6",
                Path = "/Scene/Room07/DamageObject/DamageJug (23)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 7",
                Path = "/Scene/Room07/DamageObject/DamageJug (24)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 8",
                Path = "/Scene/Room07/DamageObject/DamageJug (25)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor on chest side 9",
                Path = "/Scene/Room07/DamageObject/DamageJug (26)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 1",
                Path = "/Scene/Room07/DamageObject/DamageJug (27)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 2",
                Path = "/Scene/Room07/DamageObject/DamageJug (28)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 3",
                Path = "/Scene/Room07/DamageObject/DamageJug (29)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 4",
                Path = "/Scene/Room07/DamageObject/DamageJug (30)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 5",
                Path = "/Scene/Room07/DamageObject/DamageJug (31)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on top floor near exit after floating platforms 6",
                Path = "/Scene/Room07/DamageObject/DamageJug (32)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Dawnruin Castle entrance statue 1",
                Path = "/Scene/Room08Script_02_Save/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Dawnruin Castle entrance statue 2",
                Path = "/Scene/Room08Script_02_Save/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near Dawnruin Castle entrance statue 3",
                Path = "/Scene/Room08Script_02_Save/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near castle hall stairs 1",
                Path = "/Scene/Room09/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near castle hall stairs 2",
                Path = "/Scene/Room09/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in castle hall side room",
                Path = "/Scene/Room09/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near castle hall entrance 1",
                Path = "/Scene/Room09/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near castle hall entrance 2",
                Path = "/Scene/Room09/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near castle hall entrance 3",
                Path = "/Scene/Room09/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on castle hall stairs landing 1",
                Path = "/Scene/Room09/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on castle hall stairs landing 2",
                Path = "/Scene/Room09/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug on castle hall stairs landing 3",
                Path = "/Scene/Room09/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall stairs 1",
                Path = "/Scene/Room09/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall stairs 2",
                Path = "/Scene/Room09/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall stairs 3",
                Path = "/Scene/Room09/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall near exit 1",
                Path = "/Scene/Room09/DamageObject/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall near exit 2",
                Path = "/Scene/Room09/DamageObject/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug at top of castle hall near exit 3",
                Path = "/Scene/Room09/DamageObject/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug near castle hall stairs",
                Path = "/Scene/Room09/DamageObject/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near last statue 1",
                Path = "/Scene/Room09ToBoss_Save/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near last statue 2",
                Path = "/Scene/Room09ToBoss_Save/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near last statue 3",
                Path = "/Scene/Room09ToBoss_Save/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel near last statue 4",
                Path = "/Scene/Room09ToBoss_Save/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 1",
                Path = "/Scene/Room10/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 2",
                Path = "/Scene/Room10/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 3",
                Path = "/Scene/Room10/DamageObject/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 4",
                Path = "/Scene/Room10/DamageObject/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 5",
                Path = "/Scene/Room10/DamageObject/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 6",
                Path = "/Scene/Room10/DamageObject/DamageJug (13)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 7",
                Path = "/Scene/Room10/DamageObject/DamageJug (14)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 8",
                Path = "/Scene/Room10/DamageObject/DamageJug (15)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 9",
                Path = "/Scene/Room10/DamageObject/DamageJug (16)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 10",
                Path = "/Scene/Room10/DamageObject/DamageJug (17)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 11",
                Path = "/Scene/Room10/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 12",
                Path = "/Scene/Room10/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 13",
                Path = "/Scene/Room10/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 14",
                Path = "/Scene/Room10/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 15",
                Path = "/Scene/Room10/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 16",
                Path = "/Scene/Room10/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 17",
                Path = "/Scene/Room10/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Jug,
                LocationName = "Dark Tunnel - Jug in Knight enemy arena 18",
                Path = "/Scene/Room10/DamageObject/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 1",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 2",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 3",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 4",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 5",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 6",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (5)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 7",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 8",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 9",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.DarkTunnel, Type = BreakableItemType.Barrel,
                LocationName = "Dark Tunnel - Barrel in Vanessa arena 10",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near spawn 1",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near spawn 2",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near spawn 3",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 1",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 2",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 3",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 4",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 5",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 6",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_01 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 7",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 8",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 9",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal around first statue 10",
                Path = "/Scene/Room01_Near_Save/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 1",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 2",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 3",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 4",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 5",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 6",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on pathway after first statue 7",
                Path = "/Scene/Room01To02_Near/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 1",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 2",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 3",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 4",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 5",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 6",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 7",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 8",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 9",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 10",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 11",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard bottom floor 12",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard top floor 1",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard top floor 2",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard top floor 3",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard top floor 4",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first courtyard top floor 5",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in hallway before first bow enemy 1",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in hallway before first bow enemy 2",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in hallway before first bow enemy 3",
                Path = "/Scene/Room02_Near/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Barrel,
                LocationName = "Spirit Realm - Trap Barrel in center of first courtyard",
                Path = "/Scene/Room02_Near/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 1",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02",
                Position = new Vector3(-188.466f, 14.524f, 7.956f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 2",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-192.306f, 14.090f, -9.139f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 3",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (2)",
                Position = new Vector3(-189.073f, 14.090f, -8.249f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 4",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 5",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in first bow enemy arena 6",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on platforms after first bow enemy 1",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on platforms after first bow enemy 2",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on platforms after first bow enemy 3",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in doorway after first bow enemy 1",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02",
                Position = new Vector3(-205.498f, 22.090f, 12.778f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in doorway after first bow enemy 2",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-206.969f, 22.090f, 10.195f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in doorway after first bow enemy 3",
                Path = "/Scene/Room02To03_Near/DamageObject/DamageCrystal_02 (2)",
                Position = new Vector3(-203.878f, 22.017f, 10.812f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on floating islands before second structure 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on floating islands before second structure 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on lowest pathway on second structure 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on lowest pathway on second structure 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on lowest pathway on second structure 3",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after first sword enemy on second structure 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after first sword enemy on second structure 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after first sword enemy on second structure 3",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster on second structure middle floor 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster on second structure middle floor 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster on second structure middle floor 3",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure middle floor edge path",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure middle floor stairwell",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor 3",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor 4",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor 5",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor edge path 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure top floor edge path 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure exit path 1",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure exit path 2",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second structure exit path 3",
                Path = "/Scene/Room03_Near/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 1",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 2",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 3",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 4",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 5",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 6",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_01 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 7",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 8",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 9",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 10",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 11",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 12",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near second statue 13",
                Path = "/Scene/Room03To04_Save/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (26)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 3",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (27)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 4",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (28)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 5",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (29)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure blue crystal 6",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (30)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure arcane barrier 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure arcane barrier 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (25)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal inside third structure arcane barrier",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 3",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 4",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 5",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after third structure arcane barrier 6",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first island after third structure arcane barrier 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first island after third structure arcane barrier 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second island after third structure arcane barrier 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second island after third structure arcane barrier 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second island after third structure arcane barrier 3",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on third island after third structure arcane barrier 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on third island after third structure arcane barrier 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on third structure second floor 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on third structure second floor 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on third structure second floor 3",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (31)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third structure magic switch",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_01 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on islands after third structure 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on islands after third structure 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 1",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 2",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 3",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 4",
                Path = "/Scene/Room04/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 5",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02",
                Position = new Vector3(-500.507f, 53.000f, -11.935f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 6",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02",
                Position = new Vector3(-512.495f, 49.004f, -45.246f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 7",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-502.019f, 53.000f, -8.360f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 8",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-514.694f, 49.004f, -44.177f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 9",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 10",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 11",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on path to Seal after third structure 12",
                Path = "/Scene/Room04To05/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 1",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 2",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 3",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 4",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 5",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 6",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 7",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 8",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 9",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 10",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 11",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 12",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 13",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 14",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 15",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 16",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 17",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 18",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 19",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 1 arena 20",
                Path = "/Scene/Room05/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 1",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02",
                Position = new Vector3(-498.828f, 24.890f, -155.141f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 2",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02",
                Position = new Vector3(-509.474f, 25.000f, -158.869f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 3",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 4",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 5",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before Seal 2 arena 6",
                Path = "/Scene/Room05To06_Near/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 1",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 2",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 3",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 4",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 5",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 6",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 7",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 8",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 9",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 10",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 11",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 12",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 13",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 14",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 15",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 16",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 17",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 18",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (25)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 19",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (26)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 20",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (27)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 21",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (28)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 22",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (29)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 23",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 24",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (30)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 25",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (31)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 26",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (32)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 27",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (33)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 28",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (34)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 29",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (35)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 30",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (36)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 31",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 32",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 33",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 34",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 35",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in Seal 2 arena 36",
                Path = "/Scene/Room06/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near shortcut gate",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after shortcut gate 1",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal after shortcut gate 2",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on stairs to shortcut gate 1",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on stairs to shortcut gate 2",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on stairs to shortcut gate 3",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 1",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_01"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 2",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_01 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 3",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_01 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 4",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_01 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 5",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 6",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near third statue 7",
                Path = "/Scene/Room06To07_Near_Save/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on entrance path 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02",
                Position = new Vector3(-322.255f, 21.100f, -175.764f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on entrance path 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-295.136f, 20.051f, -193.127f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on entrance path 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (2)",
                Position = new Vector3(-303.637f, 19.380f, -192.849f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on entrance path 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on entrance path 5",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near elevator magic switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near elevator magic switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near elevator magic switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to elevator magic switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to elevator magic switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to elevator magic switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on island at elevator bottom 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on island at elevator bottom 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on island at elevator bottom 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to magic barrier switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02",
                Position = new Vector3(-293.861f, 29.000f, -183.432f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to magic barrier switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (25)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to magic barrier switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (26)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to magic barrier switch 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (27)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near magic barrier switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_01"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near magic barrier switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_01 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near magic barrier switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_01 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near magic barrier switch 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (28)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near teleporter 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near teleporter 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near absorption chest 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02",
                Position = new Vector3(-261.489f, 20.758f, -169.268f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near absorption chest 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (1)",
                Position = new Vector3(-264.548f, 20.501f, -168.478f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near absorption chest 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (2)",
                Position = new Vector3(-263.576f, 20.501f, -167.761f)
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near fire barrier switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near fire barrier switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near fire barrier switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon near fire barrier switch 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path after elevator 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path after elevator 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path after elevator 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path after elevator 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path after elevator 5",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to teleporter magic switch 1",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (29)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to teleporter magic switch 2",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (30)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to teleporter magic switch 3",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (31)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to teleporter magic switch 4",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (32)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal in canyon on path to teleporter magic switch 5",
                Path = "/Scene/Room07/DamageObject/DamageCrystal_02 (33)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster after teleporter 1",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster after teleporter 2",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster after teleporter 3",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal cluster after teleporter 4",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 1",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 2",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 3",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 4",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 5",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 6",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 7",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 8",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 9",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on first stair structure after teleporter 10",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 1",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 2",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 3",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 4",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 5",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal on second stair structure after teleporter 6",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal above third stair structure after teleporter 1",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal above third stair structure after teleporter 2",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before path to final statue 1",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before path to final statue 2",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before path to final statue 3",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal before path to final statue 4",
                Path = "/Scene/Room08_Near/DamageObject/DamageCrystal_02 (25)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 1",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 2",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 3",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 4",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 5",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 6",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_01 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 7",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 8",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 9",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 10",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 11",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.SpiritRealm, Type = BreakableItemType.Crystal,
                LocationName = "Spirit Realm - Crystal near final statue 12",
                Path = "/Scene/Room09_Save/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near first statue 1",
                Path = "/Scene/RoomStart/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near first statue 2",
                Path = "/Scene/RoomStart/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near first statue 3",
                Path = "/Scene/RoomStart/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 1",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 2",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 3",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 4",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 5",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal near first teleporter 6",
                Path = "/Scene/RoomStart/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 1",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak01_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 2",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak01_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 3",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak01_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 4",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak02_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 5",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak02_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 6",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak02_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 7",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak03_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 8",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak03_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll on path to first teleporter 9",
                Path = "/Scene/RoomStart/DamageObject/DamageDollWeak03_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel at Shrine trial start 1",
                Path = "/Scene/Act02Room04/DamageObject/DamageBarrel",
                Position = new Vector3(-57.087f, -90.000f, -171.999f)
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel at Shrine trial start 2",
                Path = "/Scene/Act02Room04/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel at Shrine trial start 3",
                Path = "/Scene/Act02Room04/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Trap Barrel in Shrine trial",
                Path = "/Scene/Act02Room04/DamageObject/DamageBarrel",
                Position = new Vector3(-59.783f, -89.000f, -185.994f)
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 1",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 2",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 3",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 4",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 5",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 6",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 7",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 8",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 9",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 10",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 11",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine trial trap barrel room 12",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal behind Shrine trial trap gates 1",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal behind Shrine trial trap gates 2",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal behind Shrine trial trap gates 3",
                Path = "/Scene/Act02Room04/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine trial trap barrel room 1",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine trial trap barrel room 2",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine trial trap barrel room 3",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug behind Shrine trial trap gates 1",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug behind Shrine trial trap gates 2",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug behind Shrine trial trap gates 3",
                Path = "/Scene/Act02Room04/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 1",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak01_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 2",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak01_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 3",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak01_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 4",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak02_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 5",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak02_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 6",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak02_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 7",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak03_Dark"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 8",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak03_Dark (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Shrine trial hallway 9",
                Path = "/Scene/Act02Room04ToRoom05/DamageObject/DamageDollWeak03_Dark (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room upper floor 1",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room upper floor 2",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room upper floor 3",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room upper floor 4",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room behind bars",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 1",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 2",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 3",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 4",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 5",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 6",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 7",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 8",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 9",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 10",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 11",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 12",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 13",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 14",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 15",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 16",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 17",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 18",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 19",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Shrine Trial giant maid room lower floor 20",
                Path = "/Scene/Act02Room05/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine Trial giant maid room lower floor 1",
                Path = "/Scene/Act02Room05/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine Trial giant maid room lower floor 2",
                Path = "/Scene/Act02Room05/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine Trial giant maid room lower floor 3",
                Path = "/Scene/Act02Room05/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine Trial giant maid room lower floor 4",
                Path = "/Scene/Act02Room05/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Shrine Trial giant maid room lower floor 5",
                Path = "/Scene/Act02Room05/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near central statue 1",
                Path = "/Scene/RoomCentral/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near central statue 2",
                Path = "/Scene/RoomCentral/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near central statue 3",
                Path = "/Scene/RoomCentral/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 1",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 2",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 3",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 4",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 5",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 6",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 7",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 8",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Underground trial clear switch 9",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 1",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 2",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 3",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 4",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 5",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 6",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 7",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 8",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Lava Ruins trial clear switch 9",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 1",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 2",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 3",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 4",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (21)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 5",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (22)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 6",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (23)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 7",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (24)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 8",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (25)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal around Dark Tunnel trial clear switch 9",
                Path = "/Scene/RoomCentral/DamageObject/DamageCrystal_02 (26)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room upper pathway 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room upper pathway 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room upper pathway 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room upper pathway 4",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room circular ramp",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (22)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 4",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 5",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 6",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 7",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 8",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 9",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 10",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 11",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial mushroom room pit 12",
                Path = "/Scene/Act03Room05/DamageObject/DamageBarrel (21)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room entrance 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room entrance 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room entrance 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 4",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 5",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 6",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 7",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 8",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 9",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 10",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 11",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 12",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 13",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 14",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial mushroom room pit 15",
                Path = "/Scene/Act03Room05/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room upper pathway 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room upper pathway 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room upper pathway 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll near Underground trial exit teleporter 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll near Underground trial exit teleporter 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak03 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room pit 1",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room pit 2",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room pit 3",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial mushroom room pit 4",
                Path = "/Scene/Act03Room05/DamageObject/DamageDollWeak03 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial hallway after first room 1",
                Path = "/Scene/Act03Room05ToRoom06/Special/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Underground trial hallway after first room 2",
                Path = "/Scene/Act03Room05ToRoom06/Special/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial hallway after first room 1",
                Path = "/Scene/Act03Room05ToRoom06/Special/DamageDollWeak"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial hallway after first room 2",
                Path = "/Scene/Act03Room05ToRoom06/Special/DamageDollWeak02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Doll,
                LocationName = "Abyss - Doll in Underground trial hallway after first room 3",
                Path = "/Scene/Act03Room05ToRoom06/Special/DamageDollWeak03"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 1",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 2",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 3",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 4",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 5",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 6",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 7",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 8",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Underground trial first room 9",
                Path = "/Scene/Act03Room06/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 1",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 2",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 3",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 4",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 5",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Underground trial start 6",
                Path = "/Scene/Act03Room06/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Lava Ruins trial upper floor 1",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Lava Ruins trial upper floor 2",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageBarrel (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Lava Ruins trial upper floor 3",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageBarrel (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Lava Ruins trial upper floor 4",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageBarrel (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial upper floor 1",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial upper floor 2",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial upper floor 3",
                Path = "/Scene/Act04Room05ToRoom06/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel in Lava Ruins trial bottom floor",
                Path = "/Scene/Act04Room06/DamageObject/DamageBarrel"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 1",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 2",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 3",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 4",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 5",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 6",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial middle floor 7",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 1",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 2",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 3",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 4",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 5",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 6",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 7",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 8",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 9",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 10",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 11",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 12",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 13",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Lava Ruins trial bottom floor 14",
                Path = "/Scene/Act04Room06/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial bottom floor 1",
                Path = "/Scene/Act04Room06/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial bottom floor 2",
                Path = "/Scene/Act04Room06/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial middle floor 1",
                Path = "/Scene/Act04Room06/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial middle floor 2",
                Path = "/Scene/Act04Room06/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Lava Ruins trial middle floor 3",
                Path = "/Scene/Act04Room06/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 1",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 2",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 3",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 4",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 5",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial first room 6",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 1",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 2",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 3",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 4",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 5",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial before maid enemy room 6",
                Path = "/Scene/Act05Room09To10/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 1",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 2",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 3",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 4",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 5",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 6",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 7",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 8",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 9",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 10",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 11",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (18)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 12",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (19)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 13",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 14",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (20)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 15",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 16",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 17",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 18",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 19",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 20",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Crystal,
                LocationName = "Abyss - Crystal in Dark Tunnel trial maid enemy room 21",
                Path = "/Scene/Act05Room10/DamageObject/DamageCrystal_02 (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 1",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 2",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (1)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 3",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (10)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 4",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (11)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 5",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (12)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 6",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (13)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 7",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (14)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 8",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (15)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 9",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (16)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 10",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (17)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 11",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (2)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 12",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (3)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 13",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (4)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 14",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (5)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 15",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 16",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 17",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Jug,
                LocationName = "Abyss - Jug in Dark Tunnel trial maid enemy room 18",
                Path = "/Scene/Act05Room10/DamageObject/DamageJug (9)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near final statue 1",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (6)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near final statue 2",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (7)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near final statue 3",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (8)"
            },
            new BreakableItem
            {
                StageId = StageId.Abyss, Type = BreakableItemType.Barrel,
                LocationName = "Abyss - Barrel near final statue 4",
                Path = "/Scene/RoomBoss/DamageObject/DamageBarrel (9)"
            },
        };

        public static readonly Dictionary<int, ILookup<string, BreakableItem>> ByStageIdAndPath = ItemList
            .GroupBy(b => (int)b.StageId)
            .ToDictionary(
                group => group.Key,
                group => group.ToLookup(b => b.Path)
            );
    }
}