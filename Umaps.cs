using System;
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
                    //loop through subcategories to find chests/spirits or items
                    for (int k = 0; k < ex.Data.Count; k++)
                    {
                        for (int j = 0; j < ex.Data.Count; j++)
                        {
                            Random rndm = new Random();
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