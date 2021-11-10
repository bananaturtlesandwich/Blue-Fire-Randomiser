using System;
using System.Collections.Generic;
using UAssetAPI;
using UAssetAPI.PropertyTypes;

namespace BlueFireRando
{
    public partial class Umaps
    {
        public static void Randomise(string filepath, string endpath, bool randomisespirits, bool randomisekeyitems, bool randomiseweapons, bool randomisetunics, bool randomiseemotes)
        {
            //Load umap
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyBinaryEquality() ? "yes" : "no")}");
            //Loop through exports
            for (int i = 0; i < y.Exports.Count; i++)
            {
                Export export = y.Exports[i];
                if (export is NormalExport ex)
                {
                    Random rndm = new Random();
                    string[,] nonothings =
                    {
                        //lol I've never used multi-dimensional arrays before
                        {"Items::NewEnumerator6","Items::NewEnumerator7","Items::NewEnumerator9","Items::NewEnumerator12","Items::NewEnumerator15","Items::NewEnumerator19","Items::NewEnumerator22","Items::NewEnumerator23","Items::NewEnumerator24","Items::NewEnumerator25","Items::NewEnumerator29","Items::NewEnumerator30","Items::NewEnumerator31","Items::NewEnumerator32","Items::NewEnumerator33","Items::NewEnumerator34","Items::NewEnumerator35","Items::NewEnumerator36","Items::NewEnumerator39","Items::NewEnumerator40","Items::NewEnumerator41","Items::NewEnumerator44","Items::NewEnumerator49","Items::NewEnumerator51","Items::NewEnumerator52","Items::NewEnumerator53","Items::NewEnumerator56","Items::NewEnumerator57","Items::NewEnumerator58","Items::NewEnumerator59","Items::NewEnumerator60","Items::NewEnumerator66","Items::NewEnumerator68","Items::NewEnumerator69","Items::NewEnumerator71","Items::NewEnumerator72","Items::NewEnumerator73","Items::NewEnumerator74","Items::NewEnumerator75","Items::NewEnumerator76","Items::NewEnumerator77","Items::NewEnumerator78","Items::NewEnumerator84","Items::NewEnumerator87","Items::NewEnumerator89","Items::NewEnumerator92","Items::NewEnumerator93","Items::NewEnumerator94","Items::NewEnumerator95","Items::NewEnumerator96","Items::NewEnumerator97" },
                        {"Spirits::","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",""},
                        {"Abilities::","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",""}
                    };
                    //loop through subcategories to find chests/spirits or items
                    for (int k = 0; k < ex.Data.Count; k++)
                    {
                        for (int j = 0; j < ex.Data.Count; j++)
                        {
                            if (ex.Data[j].Name.Equals(FName.FromString("Item")) && ex.Data[j] is BytePropertyData byt)
                            {
                                byt.EnumType = y.AddNameReference(FString.FromString("Items"));
                                byt.Value = y.AddNameReference(FString.FromString("Items::NewEnumerator" + 14));
                            }
                            if (ex.Data[j].Name.Equals(FName.FromString("Spirit")) && ex.Data[j] is BytePropertyData bit)
                            {
                                bit.EnumType = y.AddNameReference(FString.FromString("Spirits"));
                                bit.Value = y.AddNameReference(FString.FromString("Spirits::NewEnumerator" + 13));
                            }
                            if (ex.Data[j].Name.Equals(FName.FromString("Ability")) && ex.Data[j] is BytePropertyData bite)
                            {
                                bite.EnumType = y.AddNameReference(FString.FromString("Abilities"));
                                bite.Value = y.AddNameReference(FString.FromString("Abilities::NewEnumerator" + 13));
                            }
                        }
                    }
                }
            }
            y.Write(endpath);
        }
    }
}