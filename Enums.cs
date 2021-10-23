using System;
using System.Collections.Generic;
using System.Linq;
using UAssetAPI;

namespace BlueFireRando
{
    public partial class Enums
    {
        static public void RandomiseSpirits()
        {
            //Load umap/enum
            UAsset y = new UAsset(@".\Baseassets\Blue Fire\Content\Enums\Spirits.uasset", UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Only one export so for loop isn't needed
            Export baseUs = y.Exports[0];
            if (baseUs is EnumExport us)
            {
                Random rndm = new Random();
                int[] UnusedIndexes = { 3, 5, 6, 8, 16, 15, 17, 18, 19, 20, 22, 23, 24, 26, 29 };
                List<int> UsedIndexes = UnusedIndexes.ToList();
                //If anyone peeking knows a better way to do this please contact me
                //bool valid;
                List<Tuple<FName, long>> eh = us.Enum.Names;
                for (int j = 0; j < 30; j++)
                {
                    if (UnusedIndexes.Contains(j) == false)
                    {
                        int temp;
                        do
                        {
                            temp = rndm.Next(0, 30);
                        }
                        while (UsedIndexes.Contains(temp) || temp == j);
                        eh[j] = new Tuple<FName, long>(us.Enum.Names[j].Item1, temp);
                        UsedIndexes.Add(temp);
                        /*string debug=" ";
                        foreach (var item in UsedIndexes)
                        {
                            debug +=Convert.ToString(item + ", ");
                        }
                        MessageBox.Show(debug);*/
                    }
                }
            }
            y.Write(@".\Randomiser_P\Blue Fire\Content\Enums\Spirits.uasset");
        }
    }
}