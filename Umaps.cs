using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

namespace BlueFireRando
{
    public partial class Umaps
    {
        public static void Randomise(string filepath, string endpath,bool randomisespirits,bool randomisekeyitems, bool randomiseweapons, bool randomisetunics,bool randomiseemotes)
        {
            //Load umap
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyBinaryEquality() ? "yes" : "no")}");
            for(int i = 0; i < y.Exports.Count; i++)
            {
                Export export = y.Exports[i];
                if(export is NormalExport ex)
                {
                    //loop through subcategories to find chests
                    for(int j = 0; j < ex.Data.Count; j++)
                    {
                        BytePropertyData spirit = new BytePropertyData(FName.FromString("Spirit"));
                        if (ex.Data[j].Equals(spirit))
                        {
                            spirit.Value=3;
                        }
                    }
                }
            }
        
        }
    }
}