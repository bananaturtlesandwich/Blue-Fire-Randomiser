using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

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
                bool HasType = false;
                List<PropertyData> badproperties = new();
                for (int i = 0; i < export.Data.Count; i++)
                    //make it so amount is always 1 and key item is set by the rando
                    switch (export.Data[i].Name.Value.Value)
                    {
                        case "Amount":
                        case "KeyItem":
                            badproperties.Add(export.Data[i]);
                            break;
                        case "Type":
                            HasType = true;
                            break;
                    }
                if (!HasType)
                {
                    Map.AddNameReference(FString.FromString("Type"));
                    Map.AddNameReference(FString.FromString("InventoryItemType"));
                    Map.AddNameReference(FString.FromString("InventoryItemType::NewEnumerator3"));
                    export.Data.Add(new BytePropertyData(FName.FromString("Type"))
                    {
                        ByteType = BytePropertyType.FName,
                        EnumType = FName.FromString("InventoryItemType"),
                        EnumValue = FName.FromString("\"InventoryItemType::NewEnumerator3\",")
                    });
                }
                foreach (PropertyData property in badproperties) export.Data.Remove(property);
                Map.Write(Mapfile);
                HasThings = true;
                break;
            case "EmoteStatue_BP_C":
            case "Spirit_C":
                HasThings = true;
                break;
            case "Pickup_C":
                foreach (var property in export.Data) if (property.Name == FName.FromString("Type")) HasThings = true;
                break;
        }
    }
    if (!HasThings)
    {
        File.Delete(Mapfile);
        File.Delete(Mapfile.Replace("umap", "uexp"));
    }
}

UAsset Savegame = new UAsset(@".\Baseassets\BlueFireSaveGame.uasset", UE4Version.VER_UE4_25);
foreach (var prop in ((NormalExport)Savegame.Exports[1]).Data)
    if (prop.Name.Value.Value.Contains("Shop"))
        foreach (StructPropertyData Stock in ((ArrayPropertyData)prop).Value)
            foreach (var StockProp in Stock.Value)
            {
                if (StockProp.Name.Value.Value == "Amount_6_185C591747EF40A592FB63886FDB4281")
                    ((IntPropertyData)StockProp).Value = 1;
                if (StockProp.Name.Value.Value == "OriginalAmount_11_58C3C17D426D49A439C0EE85D7E9B6EC")
                    ((IntPropertyData)StockProp).Value = 1;
                if (StockProp.Name.Value.Value == "Resets_8_E303F5DF4270CCEE83F05F974F3661C9")
                    ((BoolPropertyData)StockProp).Value = false;
            }
Savegame.Write(Savegame.FilePath);