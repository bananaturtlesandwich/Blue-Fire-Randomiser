using System.IO;
using System.Windows.Forms;
using UAssetAPI;
using static BlueFireRando.Checks;

public static class Maps
{
    public static void RandomiseMap()
    {
        #region creating necessary directories
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
        #endregion

        string[] fileentries = Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);//Get all the map files
        foreach (string file in fileentries)
        {
            UAsset map = new UAsset(file, UE4Version.VER_UE4_25);
            MessageBox.Show($"Data preserved:{(map.VerifyBinaryEquality() ? "yes" : "no")}");
            foreach (var export in map.Exports) if (checks.ContainsKey(export.ObjectName.ToString()) && export is NormalExport norm) foreach (var datapiece in norm.Data) if (datapiece.Name == FName.FromString("RootComponent")) MessageBox.Show(datapiece.RawValue.ToString());
        }
    }
}