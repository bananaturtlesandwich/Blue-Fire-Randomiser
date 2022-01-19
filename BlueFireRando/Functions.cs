using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UAssetAPI;
using static Globals;

public static class Functions
{
    public static void RandomiseEnum(string filepath, int[] BannedIndexes)
    {
        UAsset enumerator = new UAsset(filepath, UE4Version.VER_UE4_25);
        //MessageBox.Show($"Data preserved:{(enumerator.VerifyBinaryEquality() ? "yes" : "no")}");
        if (enumerator.Exports[0] is EnumExport ex)
        {
            Random random = new Random();
            var names = ex.Enum.Names;
            List<int> used = BannedIndexes.ToList();
            int temp;
            for (int i = 0; i < names.Count; i++) if (!BannedIndexes.Contains(i))
                {
                    //if we want vanilla items
                    if (Vanilla)
                    {
                        do temp = random.Next(names.Count); while (used.Contains(temp));
                        names[i] = new Tuple<FName, long>(names[i].Item1, temp);
                        used.Add(temp);
                    }
                    else
                    {
                        do temp = random.Next(names.Count); while (used.Contains(temp) || temp == i);
                        names[i] = new Tuple<FName, long>(names[i].Item1, temp);
                        used.Add(temp);
                    }
                }
        }
        enumerator.Write($@"./Randomiser_P/Blue Fire/Content{filepath.Replace("Baseassets", "")}");
    }
}
