using UAssetAPI;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.UnrealTypes;

static int RandInt(int MaxValue, IEnumerable<int> Banned)
{
    int temp; Random rndm = new Random(); List<int> BannedIndexes = Banned.ToList();
    do temp = rndm.Next(MaxValue); while (BannedIndexes.Contains(temp));
    return temp;
}

static string[] GetMaps() => Directory.GetFiles(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World", "*.umap", SearchOption.AllDirectories);

static string GetSaveGame() => @"Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset";

static IEnumerable<T> Shuffle<T>(IEnumerable<T> target)
{
    var rndm = new Random();
    return target.OrderBy(x => rndm.Next());
}

static void AddEnumReference(NormalExport export, string propname, string enumname, string enumvalue) =>
    export.Data.Add(new BytePropertyData(FName.FromString(export.Asset, propname))
    {
        ByteType = BytePropertyType.FName,
        EnumType = FName.FromString(export.Asset, enumname),
        EnumValue = FName.FromString(export.Asset, enumvalue)
    });