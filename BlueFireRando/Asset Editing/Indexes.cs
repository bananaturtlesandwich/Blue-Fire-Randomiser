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
                    if (data is BytePropertyData _byte && _byte.Name.ToString().Contains("Item") && !export.ObjectName.ToString().Contains("Door"))
                        File.AppendAllText(@".\dump.txt", $"Map: {MapFile} Object:{export.ObjectName} Enumerator:{_byte.Name}\n");
        }
    }

    /*public static void RandomiseIndexes()
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
