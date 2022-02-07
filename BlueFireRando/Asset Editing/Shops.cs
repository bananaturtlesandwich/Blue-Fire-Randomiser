using System.IO;

public static class Shops
{
    public static void RandomiseShop()
    {
        string[] fileentries = HelperFunctions.GetMaps();
        const string shops = @".\Baseassets\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset";
        for(int i = 0; i < 32; i++)
        {
            int[] used=new int[32];
            used[i]=HelperFunctions.RandInt(Globals.ValidExports.Count,used);
        }
        foreach(int )
    }
}
