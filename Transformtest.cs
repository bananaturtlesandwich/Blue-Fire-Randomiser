using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

namespace BlueFireRando
{
    public partial class Transformtest
    {
        static public void RandTransform(string filepath, string endpath)
        {
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            for (int i = 0; i < y.Exports.Count; i++)
            {
                if (y.Exports[i] is NormalExport us)
                {
                    string chestref = us.ObjectName.ToString();
                    if (chestref.Contains("Chest") || chestref.StartsWith("Spirit"))
                    {
                        for (int j = 0; j < us.Data.Count; j++)
                        {
                            if (us.Data[j].Name.Equals(FName.FromString("RootComponent")) && us.Data[j] is ObjectPropertyData ob)
                            {
                                //MessageBox.Show(y.Exports[Convert.ToInt32(ob.Value.ToString())].ObjectName.ToString());
                                //FINALLY!!!!!
                                if (y.Exports[Convert.ToInt32(ob.Value.ToString())] is NormalExport egg)
                                {
                                    foreach (var data in egg.Data)
                                    {
                                        if (data.Name.Equals(FName.FromString("RelativeLocation")) && data is StructPropertyData loc)
                                        {
                                            loc.Value = new List<PropertyData>
                                            {
                                                new VectorPropertyData(FName.FromString("Vector"))
                                                {
                                                    Value= new FVector(50,50,50)
                                                }
                                            };
                                        }
                                        if (data.Name.Equals(FName.FromString("RelativeRotation")))
                                        {

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            y.Write(endpath);
        }
    }
}
