using UAssetAPI;

foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
{
    if (Mapfile.EndsWith("_BuiltData"))
    {
        File.Delete(Mapfile);
        continue;
    }
    UAsset Map = new UAsset(@Mapfile, UE4Version.VER_UE4_25);
    foreach (NormalExport export in Map.Exports)
    {
        var ClassType = export.GetExportClassType().Value.Value;
        if (ClassType == "Chest_Master_C" || ClassType == "Chest_Dance_C" || ClassType == "EmoteStatue_BP_C" || ClassType == "Chest_Master Child_C")
            Console.WriteLine(export.ObjectName.Value.Value);
    }
}
Console.ReadKey();