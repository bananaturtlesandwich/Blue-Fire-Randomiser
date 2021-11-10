using System;
using System.Collections.Generic;
using System.Linq;
using UAssetAPI;

namespace BlueFireRando
{
    public partial class Enums
    {
        static public void RandomiseEnums(string filepath, string endpath, int indexes, int[] UnusedIndexes, bool flip)
        {
            //Load enum
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyBinaryEquality() ? "yes" : "no")}");
            //Only one export so for loop isn't needed
            Export baseUs = y.Exports[0];
            if (baseUs is EnumExport us)
            {
                Random rndm = new Random();
                List<int> UsedIndexes = UnusedIndexes.ToList();
                //If anyone peeking knows a better way to do this please contact me
                //bool valid;
                List<Tuple<FName, long>> eh = us.Enum.Names;
                for (int j = 0; j < indexes; j++)
                {
                    if (flip == false)
                    {
                        if (UnusedIndexes.Contains(j) == false)
                        {
                            int temp;
                            do
                            {
                                temp = rndm.Next(0, indexes);
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
                    else
                    {
                        if (UnusedIndexes.Contains(j))
                        {
                            int temp;
                            do
                            {
                                temp = rndm.Next(0, indexes);
                            }
                            while (UsedIndexes.Contains(temp) == false || temp == j);
                            eh[j] = new Tuple<FName, long>(us.Enum.Names[j].Item1, temp);
                            UsedIndexes.Add(temp);
                        }
                    }

                }
            }
            y.Write(endpath);
        }

        static public void RandomiseEnums(string filepath, string exitpath, int indexes)
        {
            //Load umap/enum
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Only one export so for loop isn't needed
            Export baseUs = y.Exports[0];
            if (baseUs is EnumExport us)
            {
                Random rndm = new Random();
                List<int> UsedIndexes = new List<int>();
                List<Tuple<FName, long>> eh = us.Enum.Names;
                for (int j = 0; j < indexes; j++)
                {
                    int temp;
                    do
                    {
                        temp = rndm.Next(0, indexes);
                    }
                    while (UsedIndexes.Contains(temp) || temp == j);
                    eh[j] = new Tuple<FName, long>(us.Enum.Names[j].Item1, temp);
                    UsedIndexes.Add(temp);
                }
            }
            y.Write(exitpath);
        }
    }
}