using UAssetAPI;

foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
{
    UAsset Map = new UAsset(@Mapfile, UE4Version.VER_UE4_25);
    foreach (NormalExport export in Map.Exports)
    {
        switch (export.GetExportClassType().Value.Value)
        {
            case "Chest_Master_C":
            case "Chest_Dance_C":
            case "Chest_Master_Child_C":
            case "EmoteStatue_BP_C":
            case "Spirit_C":
                break;
            case "Pickup_C":
                Console.WriteLine(export.ObjectName.Value.Value);
                break;
        }
    }
}
Console.ReadKey();