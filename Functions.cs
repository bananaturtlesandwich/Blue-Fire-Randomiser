using System;
using System.Collections.Generic;
using System.Linq;
using UAssetAPI;
using UAssetAPI.PropertyTypes;

public static class Functions
{
    public static void RandomiseEnum(string filepath, int[] BannedIndexes)
    {
        UAsset enumerator = new UAsset(filepath, UE4Version.VER_UE4_25);
        if (enumerator.Exports[0] is EnumExport ex)
        {
            Random random = new Random();
            var names = ex.Data.ToArray();
            List<int> used = new List<int>();
            int temp = random.Next(names.Length);
            for (int i = 0; i < names.Length; i++) if (!BannedIndexes.Contains(i))
                {
                    while (!BannedIndexes.Contains(temp)) temp = random.Next(names.Length);
                }
        }
        enumerator.Write($@"./Randomiser_P{filepath.Replace("Baseassets", "")}");
    }
}
