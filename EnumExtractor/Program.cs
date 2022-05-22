using UAssetAPI;
using UAssetAPI.PropertyTypes;

foreach (string Enumfile in Directory.GetFiles(".\\Enums", "*.uasset", SearchOption.AllDirectories))
{
    UAsset Enum = new UAsset(Enumfile, UE4Version.VER_UE4_25);
    if (Enum.Exports[0] is EnumExport export)
    {
        Console.WriteLine("enum " + Enumfile.Split('\\')[^1].Replace(".uasset", "") + '{');
        if (export.Data[0] is MapPropertyData map) foreach (var entry in map.Value)
                Console.WriteLine("    " + ((TextPropertyData)entry.Value).CultureInvariantString.Value + '=' + ((NamePropertyData)entry.Key).Value.Value.Value[13..] + ',');
        Console.WriteLine('}');
    }

}