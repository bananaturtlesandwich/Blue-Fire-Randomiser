namespace BlueFireRando;

public static class Indexes
{
    //Emote Statue Patterns: _EmoteStatue_ is always part of the object name
    ////Weirdly, the wave emote statue does not have a ByteProperty listed
    //The location of the byte property is always the 3rd
    public static void RandomiseEmotes()
    {
        string[] Emotes = { "E_Emotes::NewEnumerator6", "E_Emotes::NewEnumerator7", "E_Emotes::NewEnumerator13", "E_Emotes::NewEnumerator8", "E_Emotes::NewEnumerator4", "E_Emotes::NewEnumerator2", "E_Emotes::NewEnumerator12", "E_Emotes::NewEnumerator9", "E_Emotes::NewEnumerator3", "E_Emotes::NewEnumerator11", "E_Emotes::NewEnumerator5", "E_Emotes::NewEnumerator1" };
        Queue<string> ShuffledEmotes = new(HelperFunctions.Shuffle(Emotes));
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                if (export.ObjectName.ToString().Contains("_EmoteStatue_") && export.Data[2] is BytePropertyData _byte)
                    Map.SetNameReference(_byte.Value, FString.FromString(ShuffledEmotes.Dequeue()));
            Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "").Replace(".\\Randomiser_P\\Blue Fire\\Content\\BlueFire\\Maps", "")}");
        }
    }

    //Spirit Patterns: All spirit objects start with Spirit_ except for Dance_Platform_Party_Chest_Spirit_HammerKing
    //The location of the byte property is always 9 except when it's 1 in Dance_Platform_Party_Chest_Spirit_HammerKing
    public static void RandomiseSpirits()
    {
        string[] Spirits = { "Spirits::NewEnumerator13", "Spirits::NewEnumerator4", "Spirits::NewEnumerator2", "Spirits::NewEnumerator9", "Spirits::NewEnumerator3", "Spirits::NewEnumerator21", "Spirits::NewEnumerator1", "Spirits::NewEnumerator28", "Spirits::NewEnumerator12", "Spirits::NewEnumerator17", "Spirits::NewEnumerator25", "Spirits::NewEnumerator10", "Spirits::NewEnumerator11", "Spirits::NewEnumerator7", "Spirits::NewEnumerator27", "Spirits::NewEnumerator14", "Spirits::NewEnumerator15" };
        Queue<string> ShuffledSpirits = new(HelperFunctions.Shuffle(Spirits));
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
            {
                if (export.ObjectName.ToString().StartsWith("Spirit_") && export.Data[9] is BytePropertyData _byte)
                {
                    Map.SetNameReference(_byte.Value, FString.FromString(ShuffledSpirits.Dequeue()));
                    continue;
                }
                if (export.ObjectName.ToString().StartsWith("Dance_Platform_Party_Chest_Spirit_") && export.Data[11] is BytePropertyData byt)
                    Map.SetNameReference(byt.Value, FString.FromString(ShuffledSpirits.Dequeue()));
            }
            Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "").Replace(".\\Randomiser_P\\Blue Fire\\Content\\BlueFire\\Maps", "")}");
        }
        RandomiseShops(ref ShuffledSpirits, '3', 7);
    }

    //Item Patterns: Base Enum is Items and we do not want doors to be included unless you want to unlock a door with a ruby or smthn
    //Too many other variables have Chest_ or Pickup_ at the start of their names so I'll search manually
    public static void RandomiseItems()
    {
        string[] Items = { "Items::NewEnumerator45", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator31", "Items::NewEnumerator17", "Items::NewEnumerator31", "Items::NewEnumerator24", "Items::NewEnumerator26", "Items::NewEnumerator31", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator30", "Items::NewEnumerator42", "Items::NewEnumerator55", "Items::NewEnumerator27", "Items::NewEnumerator70", "Items::NewEnumerator9", "Items::NewEnumerator9", "Items::NewEnumerator24", "Items::NewEnumerator46", "Items::NewEnumerator26", "Items::NewEnumerator6", "Items::NewEnumerator6", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator31", "Items::NewEnumerator6", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator72", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator72", "Items::NewEnumerator31", "Items::NewEnumerator6", "Items::NewEnumerator80", "Items::NewEnumerator31", "Items::NewEnumerator42", "Items::NewEnumerator14", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator42", "Items::NewEnumerator54", "Items::NewEnumerator81", "Items::NewEnumerator14", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator0", "Items::NewEnumerator83", "Items::NewEnumerator81", "Items::NewEnumerator80", "Items::NewEnumerator14", "Items::NewEnumerator91", "Items::NewEnumerator39", "Items::NewEnumerator89", "Items::NewEnumerator31", "Items::NewEnumerator25", "Items::NewEnumerator24" };
        Queue<string> ShuffledItems = new Queue<string>(HelperFunctions.Shuffle(Items));
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                if (!export.ObjectName.ToString().Contains("Door_") && !export.ObjectName.ToString().Contains("Chest_A01_Uthas_Loot_01"))
                    foreach (PropertyData data in export.Data)
                        if (data is BytePropertyData _byte && _byte.GetEnumBase(Map) == FString.FromString("Items"))
                            _byte.Value = Map.AddNameReference(FString.FromString(ShuffledItems.Dequeue()));

            Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "").Replace(".\\Randomiser_P\\Blue Fire\\Content\\BlueFire\\Maps", "")}");
        }
        RandomiseShops(ref ShuffledItems, '0', 0);
    }

    //Tunic Patterns: Base Enum is Tunics...that's it!
    public static void RandomiseTunics()
    {
        string[] Tunics = { "Tunics::NewEnumerator31", "Tunics::NewEnumerator15", "Tunics::NewEnumerator2", "Tunics::NewEnumerator16", "Tunics::NewEnumerator16", "Tunics::NewEnumerator7", "Tunics::NewEnumerator14", "Tunics::NewEnumerator10", "Tunics::NewEnumerator27", "Tunics::NewEnumerator26", "Tunics::NewEnumerator25", "Tunics::NewEnumerator24", "Tunics::NewEnumerator23", "Tunics::NewEnumerator22", "Tunics::NewEnumerator21", "Tunics::NewEnumerator20", "Tunics::NewEnumerator19", "Tunics::NewEnumerator18", "Tunics::NewEnumerator17" };
        Queue<string> ShuffledTunics = new Queue<string>(HelperFunctions.Shuffle(Tunics));
        RandomiseShops(ref ShuffledTunics, '2', 5);
    }
    //Weapon Patterns: Base Enum is Weapons...that's it!

    private static void RandomiseShops(ref Queue<string> Shuffled, char InventoryItemType, byte ItemIndex)
    {
        UAsset Savegame = new UAsset(HelperFunctions.GetSaveGame(), UE4Version.VER_UE4_25);
        if (Savegame.Exports[1] is NormalExport ex)
            foreach (var data in ex.Data)
                if (data is ArrayPropertyData shop)
                    foreach (var thing in shop.Value)
                        if (thing is StructPropertyData item && item.Value[4] is BytePropertyData ItemType && ItemType.GetEnumFull(Savegame).ToString().EndsWith(InventoryItemType) && item.Value[ItemIndex] is BytePropertyData Item)
                            Item.Value = Savegame.AddNameReference(FString.FromString(Shuffled.Dequeue()));
        Savegame.Write(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset");
    }

#if DEBUG
    //using ObjectNames instead of scanning for enum signatures reduces the number of iterations over irrelevant code so this function is for finding those patterns
    public static void DumpIndexes()
    {
        File.Delete(@".\dump.txt");
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
            {
                foreach (PropertyData data in export.Data)
                    if (data is BytePropertyData _byte && _byte.GetEnumBase(Map) == FString.FromString("Tunics"))
                        File.AppendAllText(@".\dump.txt", "\"" + _byte.GetEnumFull(Map).ToString() + "\",");
            }
        }

        UAsset Savegame = new UAsset(HelperFunctions.GetSaveGame(), UE4Version.VER_UE4_25);
        if (Savegame.Exports[1] is NormalExport ex)
            foreach (var data in ex.Data)
                if (data is ArrayPropertyData shop)
                    foreach (var thing in shop.Value)
                        if (thing is StructPropertyData item && item.Value[4] is BytePropertyData ItemType && ItemType.GetEnumFull(Savegame).ToString().EndsWith('2') && item.Value[5] is BytePropertyData Item)
                            File.AppendAllText(@".\dump.txt", "\"" + Item.GetEnumFull(Savegame).ToString() + "\",");
    }
#endif
}