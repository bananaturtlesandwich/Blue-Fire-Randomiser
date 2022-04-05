public static class Indexes
{
    public static void DumpIndexes()
    {
        File.Delete(@".\dump.txt");
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                /*foreach (PropertyData data in export.Data)
                    if (data is BytePropertyData _byte && _byte.GetEnumBase(Map) == FString.FromString("E_Emotes"))
                        File.AppendAllText(@".\dump.txt", $"Map: {MapFile}\nObject:{export.ObjectName}\nByte:{Map.GetNameReference(_byte.Value)}\n\n");*/
                if(export.ObjectName.ToString().Contains("_EmoteStatue_")&&export.Data[2]is BytePropertyData _byte)
                    File.AppendAllText(@".\dump.txt", "\""+Map.GetNameReference(_byte.Value).ToString()+"\",");
        }
    }


    //Item Patterns: Base Enum is Items and we do not want doors to be included unless you want to unlock a door with a ruby or smthn
    //Spirit Patterns: Base Enum is Spirits but there's nothing else :)
    //Tunic Patterns: Base Enum is Tunics...that's it!
    //Weapon Patterns: Base Enum is Weapons...that's it!
    //Emote Statue Patterns: _EmoteStatue_ is always part of the object name. Weirdly, A01_Nuos_EmoteStatue_Wave in A01_AbilityShrine_CenterTree does not have a ByteProperty listed
    //I'll do a test for exclusively emotes first as you can't buy them from a shop and searching for the objectname is more optimised
    public static void RandomiseEmotes()
    {
        string[] Emotes = { "E_Emotes::NewEnumerator6", "E_Emotes::NewEnumerator7", "E_Emotes::NewEnumerator13", "E_Emotes::NewEnumerator8", "E_Emotes::NewEnumerator4", "E_Emotes::NewEnumerator2", "E_Emotes::NewEnumerator12", "E_Emotes::NewEnumerator9", "E_Emotes::NewEnumerator3", "E_Emotes::NewEnumerator11", "E_Emotes::NewEnumerator5", "E_Emotes::NewEnumerator1"};
        Queue<string> ShuffledEmotes=new(HelperFunctions.Shuffle(Emotes));
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
    /*I'll need to do some testing before I continue with this
    public static void RandomiseIndexes()
    {
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map=new UAsset(MapFile, UE4Version.VER_UE4_25);
        }
    }

    public static Queue<BytePropertyData> GetIndexes (UAsset map,string _enum,string[] excludes)
    {
        foreach(NormalExport export in map.Exports)
            foreach(PropertyData data in export.Data)
                if(data is BytePropertyData _byte && _byte.Name.ToString().Contains(_enum))
    }*/
}
