public static partial class HelperFunctions
{
    public static int RandInt(int MaxValue, IEnumerable<int> Banned)
    {
        int temp; Random rndm = new Random(); List<int> BannedIndexes = Banned.ToList();
        do temp = rndm.Next(MaxValue); while (BannedIndexes.Contains(temp));
        return temp;
    }

    public static string[] GetMaps() => Directory.GetFiles(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World", "*.umap", SearchOption.AllDirectories).Length > 0 ?
            Directory.GetFiles(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World", "*.umap", SearchOption.AllDirectories) :
            Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);

    public static string GetSaveGame() =>
        File.Exists(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset") ?
        @".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset" :
        @".\Baseassets\BlueFireSaveGame.uasset";

    public static IEnumerable<T> Shuffle<T>(IEnumerable<T> target) => target.OrderBy(x => new Random().Next());
}