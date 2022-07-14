using UAssetAPI;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.UnrealTypes;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
public static class Helpers
{
    public static int RandInt(int MaxValue, IEnumerable<int> Banned)
    {
        int temp; Random rndm = new Random(); List<int> BannedIndexes = Banned.ToList();
        do temp = rndm.Next(MaxValue); while (BannedIndexes.Contains(temp));
        return temp;
    }

    public static string GetSaveGame() => @"Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset";

    public static IEnumerable<T> Shuffle<T>(IEnumerable<T> target)
    {
        var rndm = new Random();
        return target.OrderBy(x => rndm.Next());
    }

    public static void AddEnumReference(NormalExport export, string propname, string enumname, string enumvalue) =>
        export.Data.Add(new BytePropertyData(FName.FromString(export.Asset, propname))
        {
            ByteType = BytePropertyType.FName,
            EnumType = FName.FromString(export.Asset, enumname),
            EnumValue = FName.FromString(export.Asset, enumvalue)
        });

    public static int GetAmount<T>(IEnumerable<T> target, T query)
    {
        int x = 0;
        foreach (T item in target)
            if (item.Equals(query))
                x++;
        return x;
    }
}