using System.Collections.Generic;
using System.IO;
using UAssetAPI;
using UAssetAPI.StructTypes;
using System;
using static ButtonBools;
using static Locations;

public static class Datatables
{
    public static void CreateDTDirectories()
    {
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\Emote");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Amulets");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Stat");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Tunics");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\Weapons");
    }

    public static void RandomiseDatatable(string uasset)
    {
        UAsset DataTable=new UAsset(uasset,UE4Version.VER_UE4_25);
        List<StructPropertyData> table;
        if (DataTable.Exports[0] is DataTableExport DTE)
        {
            Shuffle(DTE.Table.Data, out table);
            DTE.Table.Data = table;
        }
    }
}