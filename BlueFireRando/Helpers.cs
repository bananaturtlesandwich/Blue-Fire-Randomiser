public static class Helpers
{
    public static int RandInt(int MaxValue, IEnumerable<int> Banned)
    {
        int temp; Random rndm = new Random(); List<int> BannedIndexes = Banned.ToList();
        do temp = rndm.Next(MaxValue); while (BannedIndexes.Contains(temp));
        return temp;
    }

    public static string[] GetMaps() => Directory.GetFiles(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World", "*.umap", SearchOption.AllDirectories);

    public static string GetSaveGame() => @".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset";

    public static IEnumerable<T> Shuffle<T>(IEnumerable<T> target) => target.OrderBy(x => new Random().Next());

    public static void AddByteProperty(NormalExport export, string propname, string enumname, string enumvalue)
    {
        export.Asset.AddNameReference(FString.FromString(propname));
        export.Asset.AddNameReference(FString.FromString(enumname));
        export.Asset.AddNameReference(FString.FromString(enumvalue));
        export.Data.Add(new BytePropertyData(FName.FromString(propname))
        {
            EnumType = FName.FromString(enumname),
            EnumValue = FName.FromString(enumvalue)
        });
    }
}