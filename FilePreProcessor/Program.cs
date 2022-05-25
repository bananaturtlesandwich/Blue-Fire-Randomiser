using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

static void AddByteProperty(NormalExport export, string propname, string enumname, string enumvalue)
{
    export.Asset.AddNameReference(FString.FromString(propname));
    export.Asset.AddNameReference(FString.FromString(enumname));
    export.Asset.AddNameReference(FString.FromString(enumvalue));
    export.Data.Add(new BytePropertyData(FName.FromString(propname))
    {
        EnumType = FName.FromString(enumname),
        EnumValue = FName.FromString(enumvalue)
    });
}

foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
{
    UAsset Map = new UAsset(@Mapfile, UE4Version.VER_UE4_25);
    bool HasThings = false;
    foreach (NormalExport export in Map.Exports)
        switch (export.GetExportClassType().Value.Value)
        {
            case "Chest_Master_C":
            case "Chest_Dance_C":
            case "Chest_Master_Child_C":
                HasThings = true;
                bool HasInventoryItemType = false;
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
                            HasInventoryItemType = true;
                            break;
                    }
                foreach (PropertyData property in badproperties) export.Data.Remove(property);
                //Add so item can be identified
                if (!HasInventoryItemType)
                    AddByteProperty(export, "Type", "InventoryItemType", "InventoryItemType::NewEnumerator0");
                Map.Write(Mapfile);
                break;
            case "EmoteStatue_BP_C":
            case "Spirit_C":
                HasThings = true;
                break;
            case "Pickup_C":
                foreach (var property in export.Data) if (property.Name == FName.FromString("Type")) HasThings = true;
                break;
        }
    //delete redundant maps (without any items)
    if (!HasThings)
    {
        File.Delete(Mapfile);
        File.Delete(Mapfile.Replace("umap", "uexp"));
    }
}

//clear out builtdata and models
foreach (string file in Directory.GetFiles(@".\Baseassets\World", "*.uasset", SearchOption.AllDirectories))
{
    File.Delete(file);
    if (file.EndsWith("_BuiltData.uasset")) File.Delete(file.Replace("uasset", "ubulk"));
    File.Delete(file.Replace("uasset", "uexp"));
}

//Set all shops to have only one of each that doesn't reset
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