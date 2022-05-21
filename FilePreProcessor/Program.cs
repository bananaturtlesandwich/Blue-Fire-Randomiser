using UAssetAPI;

foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
{
    UAsset Map = new UAsset(@Mapfile, UE4Version.VER_UE4_25);
    bool HasThings = false;
    foreach (NormalExport export in Map.Exports)
    {
        switch (export.GetExportClassType().Value.Value)
        {
            case "Chest_Master_C":
            case "Chest_Dance_C":
            case "Chest_Master_Child_C":
            case "EmoteStatue_BP_C":
            case "Spirit_C":
                HasThings = true;
                break;
            case "Pickup_C":
                foreach (var property in export.Data) if (property.Name == FName.FromString("Type"))
                        HasThings = true;
                break;
        }
    }
    if (!HasThings) File.Delete(Mapfile);
}