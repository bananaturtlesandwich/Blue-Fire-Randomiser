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
        public class Spirits
        {
            /*xStructPropertyData location = new StructPropertyData(FName.FromString("RelativeLocation"))
            {
                StructType = FName.FromString("Vector"),
                Value = new List<PropertyData>
                {
                    new VectorPropertyData(FName.FromString("Vector"))
                    {
                        Value = new FVector() // Translation in unreal units (X, Y, Z)
                    }
                }
            };
            StructPropertyData rotation = new StructPropertyData(FName.FromString("RelativeRotation"))
            {
                StructType = FName.FromString("Rotator"),
                Value = new List<PropertyData>
                {
                    new RotatorPropertyData(FName.FromString("Vector"))
                    {
                        Value = new FRotator() // Translation in unreal units (X, Y, Z)
                    }
                }
            };*/
            ObjectPropertyData mesh = new ObjectPropertyData(FName.FromString("SkeletalMesh"))
            {
                
            };
            BytePropertyData spirit = new BytePropertyData(FName.FromString("Spirit"));
        }
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