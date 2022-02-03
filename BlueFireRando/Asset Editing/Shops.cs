using System.IO;

public static class Shops
{
    public static void RandomiseShop()//How do I make this compatible with location swapping without overriding data?
    {
        string[] fileentries = Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);//Get all the map files
        const string shops = @".\Baseassets\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset";
    }
}
