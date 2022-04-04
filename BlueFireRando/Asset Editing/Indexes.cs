public static class Indexes
{
    public static void DumpIndexes()
    {
        File.Delete(@".\dump.txt");
        foreach (string MapFile in HelperFunctions.GetMaps())
        {
            UAsset Map = new UAsset(MapFile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                foreach (PropertyData data in export.Data)
                    if (data is BytePropertyData _byte && _byte.GetEnumBase(Map) == FString.FromString("Weapons"))
                        File.AppendAllText(@".\dump.txt", $"Map: {MapFile}\nObject:{export.ObjectName}\n\n");
        }
    }


    //Item Patterns: Base Enum is Items and we do not want doors to be included unless you want to unlock a door with a ruby or smthn
    //Spirit Patterns: Base Enum is Spirits but there's nothing else :)
    //Tunic Patterns: Base Enum is Tunics...that's it!
    //Weapon Patterns: Base Enum is Weapons...that's it!
    //Emote Statue Patterns: _EmoteStatue_ is always part of the object name. Weirdly, A01_Nuos_EmoteStatue_Wave in A01_AbilityShrine_CenterTree does not have a ByteProperty listed
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
