namespace BlueFireRando;

public static class Indexes
{
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
                /*foreach (PropertyData data in export.Data)
                    if (data is BytePropertyData _byte && _byte.GetEnumBase(Map) == FString.FromString("Spirits"))
                        File.AppendAllText(@".\dump.txt", $"Map: {MapFile}\nObject:{export.ObjectName}\nByte:{_byte.GetEnumFull(Map)}\n\n");*/
                if (export.ObjectName.ToString().Contains("_EmoteStatue_") && export.Data[9] is BytePropertyData _byte)
                    File.AppendAllText(@".\dump.txt", "\"" + Map.GetNameReference(_byte.Value).ToString() + "\",");
                /*else if (export.ObjectName.ToString().StartsWith("Dance_Platform_Party_Chest_Spirit_") && export.Data[11] is BytePropertyData byt)
                    File.AppendAllText(@".\dump.txt", "\"" + Map.GetNameReference(byt.Value).ToString() + "\",");*/
            }
        }

        /*UAsset Savegame = new(HelperFunctions.GetSaveGame(), UE4Version.VER_UE4_25);
        if (Savegame.Exports[1] is NormalExport ex)
            foreach (PropertyData data in ex.Data)
                if (data is ArrayPropertyData shop)
                    foreach (StructPropertyData item in shop.Value)
                        if (item.Value[4] is BytePropertyData ItemType && ItemType.GetEnumFull(Savegame).ToString().EndsWith('3'))
                            foreach (var props in item.Value)
                                if (props is BytePropertyData _byte && _byte.GetEnumBase(Savegame) == FString.FromString("Spirits"))
                                    File.AppendAllText(@".\dump.txt", "\"" + _byte.GetEnumFull(Savegame).ToString() + "\",");*/
    }
#endif

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
                {
                    Map.SetNameReference(_byte.Value, FString.FromString(ShuffledEmotes.Dequeue()));
                    Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "")}");
                }
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
                    Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "")}");
                    continue;
                }
                if (export.ObjectName.ToString().StartsWith("Dance_Platform_Party_Chest_Spirit_") && export.Data[11] is BytePropertyData byt)
                {
                    Map.Write($@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps{MapFile.Replace(".\\Baseassets", "")}");
                    Map.SetNameReference(byt.Value, FString.FromString(ShuffledSpirits.Dequeue()));
                }
            }
        }
        UAsset Savegame = new UAsset(HelperFunctions.GetSaveGame(), UE4Version.VER_UE4_25);
        if (Savegame.Exports[1] is NormalExport ex)
            foreach (var data in ex.Data)
                if (data is ArrayPropertyData shop)
                    foreach (var thing in shop.Value)
                        if (thing is StructPropertyData item && item.Value[4] is BytePropertyData ItemType && ItemType.GetEnumFull(Savegame).ToString().EndsWith('3') && item.Value[7] is BytePropertyData Spirit)
                            Savegame.SetNameReference(Spirit.Value, FString.FromString(ShuffledSpirits.Dequeue()));
        Savegame.Write(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset");
    }

    //Item Patterns: Base Enum is Items and we do not want doors to be included unless you want to unlock a door with a ruby or smthn
    //Tunic Patterns: Base Enum is Tunics...that's it!
    //Weapon Patterns: Base Enum is Weapons...that's it!
}
