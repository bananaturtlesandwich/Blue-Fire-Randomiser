using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UAssetAPI;
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
                int chest = 0;
                if(export is NormalExport ex)
                {
                    //loop through subcategories to find chests
                    for(int j = 0; j < ex.Data.Count; j++)
                    {
                        if (ex.Data[j].Name.Equals("RelativeLocation") && ex.Data[j] is StructPropertyData)
                        {
                            chest++;
                        }
                        if(ex.Data[j].Name.Equals("RelativeRotation") && ex.Data[j] is StructPropertyData)
                        {
                            chest++;
                        }
                    }
                }
            }
        }
    }
}