﻿using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

static void AddEnumReference(NormalExport export, string propname, string enumname, string enumvalue)
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
    //to search for redundant map files - is set to true if anything is found
    bool HasThings = false;
    foreach (NormalExport export in Map.Exports)
        switch (export.GetExportClassType().Value.Value)
        {
            case "Chest_Master_C":
            case "Chest_Dance_C":
            case "Chest_Master_Child_C":
                HasThings = true;
                bool HasInventoryItemType = false;
                bool HasItem = false;
                byte ItemType = 0;
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
                            ItemType = Convert.ToByte(((BytePropertyData)export.Data[i]).EnumValue.Value.Value[^1]);
                            break;
                        case "Item":
                        case "Weapon":
                        case "Amulet":
                        case "Tunic":
                        case "Ability":
                            HasItem = true;
                            break;
                    }
                foreach (PropertyData property in badproperties) export.Data.Remove(property);
                //Add so item can be identified
                if (!HasInventoryItemType)
                    AddEnumReference(export, "Type", "InventoryItemType", "InventoryItemType::NewEnumerator0");
                if (!HasItem)
                    switch (ItemType)
                    {
                        //default value for items
                        case (byte)InventoryItemType.Item:
                            AddEnumReference(export, "Item", "Items", "Items::NewEnumerator25");
                            break;
                        default:
                            Console.WriteLine(export.ObjectName.Value.Value + " Has the default value for " + (InventoryItemType)ItemType);
                            break;
                    }
                Map.Write(Mapfile);
                break;
            case "EmoteStatue_BP_C":
            case "Spirit_C":
                HasThings = true;
                //Fara's Grace is the only spirit at default
                if (export.ObjectName.Value.Value == "Spirit_A01_FarasGrace")
                    AddEnumReference(export, "Amulet", "Spirits", "Spirits::NewEnumerator0");
                if (export.ObjectName.Value.Value == "A01_Nuos_EmoteStatue_Wave")
                    AddEnumReference(export, "Emote", "E_Emotes", "E_Emotes::NewEnumerator0");
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

enum InventoryItemType
{
    Item = 0,
    Weapon = 1,
    Tunic = 2,
    Spirit = 3,
    Life = 4,
    SpiritSlot = 5,
    Ability = 6,
    Emote = 7,
}