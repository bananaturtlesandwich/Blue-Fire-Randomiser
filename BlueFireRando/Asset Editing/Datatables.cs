using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UAssetAPI;
using static ButtonBools;

public static class Datatables
{
    public static void CreateDTDirectories()
    {
        if(Emotes) Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\Emote");
        if(Spirits)Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Amulets");
        //Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Stat");
        if(Tunics) Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Tunics");
        if(Weapons) Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Weapons");
    }

    public static void RandomiseDatatable(string uasset)
    {
        UAsset DataTable = new UAsset(uasset, UE4Version.VER_UE4_25);
        Random rndm = new Random();
        if (DataTable.Exports[0] is DataTableExport DTE)
        {
            var shuffle = DTE.Table.Data.OrderBy(item => rndm.Next()).ToList();
            DTE.Table.Data = shuffle;
        }
        DataTable.Write($@"./Randomiser_P/Blue Fire/Content{uasset.Replace("Baseassets", "")}");
    }
}