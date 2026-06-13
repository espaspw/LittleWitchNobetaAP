using LittleWitchNobetaAP.Utils;
using MelonLoader;

namespace LittleWitchNobetaAP.Archipelago;

public class ArchipelagoSaveFile
{
    private static readonly MelonPreferences_Category ArchipelagoSlotInfoCategory =
        MelonPreferences.CreateCategory("LwnApSaveFileCategory", "LwnApSaveFileCategory", false, false);

    private readonly MelonPreferences_Entry<int> _receivedItemCount;
    private readonly MelonPreferences_Entry<string> _seed;
    private readonly MelonPreferences_Entry<string> _checkedLoreItemLocations;
    /*private MelonPreferences_Entry<string> _hostName;
    private MelonPreferences_Entry<string> _slotName;
    private MelonPreferences_Entry<string> _password;
    private MelonPreferences_Entry<string> _port;
    private MelonPreferences_Entry<List<long>> _receivedItems;
    private MelonPreferences_Entry<List<long>> _sentLocations;
    private MelonPreferences_Entry<Dictionary<long, List<SceneEvent>>> _storedEvents;*/

    public ArchipelagoSaveFile(string seed)
    {
        _receivedItemCount = ArchipelagoSlotInfoCategory.HasEntry("ReceivedItemCount")
            ? ArchipelagoSlotInfoCategory.GetEntry<int>("ReceivedItemCount")
            : ArchipelagoSlotInfoCategory.CreateEntry("ReceivedItemCount", 0);
        
        _seed = ArchipelagoSlotInfoCategory.HasEntry("Seed")
            ? ArchipelagoSlotInfoCategory.GetEntry<string>("Seed")
            : ArchipelagoSlotInfoCategory.CreateEntry("Seed", "-1");
        
        _checkedLoreItemLocations = ArchipelagoSlotInfoCategory.HasEntry("CheckedLoreItemLocations")
            ? ArchipelagoSlotInfoCategory.GetEntry<string>("CheckedLoreItemLocations")
            : ArchipelagoSlotInfoCategory.CreateEntry("CheckedLoreItemLocations", "");
        
        var saveFilePath = $"UserData/Slot{LwnApMod.SelectedSaveSlot}.cfg";
        var saveFileExists = File.Exists(saveFilePath);

        ArchipelagoSlotInfoCategory.SetFilePath(saveFilePath);
        if (!saveFileExists)
        {
            _seed.Value = seed;
        }
        else
        {
            Melon<LwnApMod>.Logger.Msg($"_receivedItemCount null?: {_receivedItemCount == null}");
            Melon<LwnApMod>.Logger.Msg($"_checkedLoreItemLocations null?: {_checkedLoreItemLocations == null}");
            Melon<LwnApMod>.Logger.Msg($"_seed null?: {_seed == null}");
            Melon<LwnApMod>.Logger.Msg($"ServerData null?: {ArchipelagoClient.ServerData == null}");
            Melon<LwnApMod>.Logger.Msg($"ServerData.Index null?: {ArchipelagoClient.ServerData.Index == null}");
            Melon<LwnApMod>.Logger.Msg($"ServerData.CheckedLoreItemLocations null?: {ArchipelagoClient.ServerData.CheckedLoreItemLocations == null}");
            
            Melon<LwnApMod>.Logger.Msg($"Item count: {_receivedItemCount.Value}");
            Melon<LwnApMod>.Logger.Msg($"Checked Lore Items: {string.Join(',', _checkedLoreItemLocations.Value)}");
            ArchipelagoClient.ServerData.Index = _receivedItemCount.Value;
            ArchipelagoClient.ServerData.CheckedLoreItemLocations = _checkedLoreItemLocations.Value
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
        }

        /*_hostName = ArchipelagoSlotInfoCategory.CreateEntry("HostName", string.Empty);
        _slotName = ArchipelagoSlotInfoCategory.CreateEntry("SlotName", string.Empty);
        _password = ArchipelagoSlotInfoCategory.CreateEntry("Password", string.Empty);
        _port = ArchipelagoSlotInfoCategory.CreateEntry("Port", string.Empty);
        _receivedItems = ArchipelagoSlotInfoCategory.CreateEntry("ReceivedItems", new List<long>());
        _sentLocations = ArchipelagoSlotInfoCategory.CreateEntry("SentLocations", new List<long>());
        _storedEvents = ArchipelagoSlotInfoCategory.CreateEntry("SentLocations", new Dictionary<long, List<SceneEvent>>());*/
    }

    public void UpdateItemCount(int itemCount)
    {
        _receivedItemCount.Value = itemCount;
    }

    public void AddCheckedLoreItemLocation(int loreItemLocation)
    {
        var currentList = _checkedLoreItemLocations.Value.Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        currentList.Add(loreItemLocation);
        _checkedLoreItemLocations.Value = string.Join(',', currentList);
    }

    public void Save()
    {
        if (Singletons.GameSave is null) return;

        Melon<LwnApMod>.Logger.Msg("Saving archipelago state...");
        ArchipelagoSlotInfoCategory.SaveToFile();
        Melon<LwnApMod>.Logger.Msg("Archipelago state saved");
    }
}