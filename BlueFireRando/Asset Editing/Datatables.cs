using System.Collections.Generic;
using System.IO;
using UAssetAPI;
using UAssetAPI.StructTypes;
using System;
using static ButtonBools;

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

    public static void Shuffle(List<StructPropertyData> list, out List<StructPropertyData> output)
    {
        Random rndm = new Random();
        output = new List<StructPropertyData>();
        for (int i = 0; i < list.Count; i++)
        {
            StructPropertyData temp = list[rndm.Next(list.Count)];
            if (!Vanilla) while (temp.Equals(list[i])) temp = list[rndm.Next(list.Count)];
            output.Add(temp);
            list.Remove(temp);
        }
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