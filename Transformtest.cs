using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPI;

namespace BlueFireRando
{
    public partial class Transformtest
    {
        static public void RandTransform(string filepath, string endpath)
        {
            UAsset y = new UAsset(filepath,UE4Version.VER_UE4_25);
            for(int i = 0; i < y.Exports.Count;i++)
            {
                if(y.Exports[i] is NormalExport us && us.ObjectName==FName.FromString("SceneComponent")&&us.Data[0].Name==FName.FromString("RelativeLocation") && us.Data[1].Name == FName.FromString("RelativeRotation"))
                {
                    MessageBox.Show(us.ObjectName.ToString());
                }
            }
        }
    }
}
