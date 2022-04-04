public static class Indexes
{
    public static void RandomiseIndexes()
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
}
