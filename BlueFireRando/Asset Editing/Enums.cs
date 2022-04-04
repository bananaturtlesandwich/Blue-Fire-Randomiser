public static class Enums
{
    public static void RandomiseEnum(string filepath, int[] BannedIndexes)
    {
        UAsset enumerator = new UAsset(filepath, UE4Version.VER_UE4_25);
        if (enumerator.Exports[0] is EnumExport ex)
        {
            var names = ex.Enum.Names; List<int> used = BannedIndexes.ToList(); int temp;
            for (int i = 0; i < names.Count; i++) if (!BannedIndexes.Contains(i))
                {
                    temp = HelperFunctions.RandInt(names.Count, used);
                    names[i] = new Tuple<FName, long>(names[i].Item1, temp);
                    used.Add(temp);
                }
            enumerator.Write($@"./Randomiser_P/Blue Fire/Content{filepath.Replace("Baseassets", "")}");
        }
    }
}
