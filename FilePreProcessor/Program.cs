using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

Console.Write("Enter which function you wish to use");
var cursorpos = Console.GetCursorPosition();
Console.WriteLine("\n1 for enum extraction");
Console.WriteLine("2 for file pre-processing");
Console.WriteLine("3 for value dumping (probably best to pre-process first)");
Console.SetCursorPosition(cursorpos.Left, cursorpos.Top);

if (int.TryParse(Console.ReadLine(), out var request))
    switch (request)
    {
        case 1:
            Extract();
            break;
        case 2:
            Process();
            break;
        case 3:
            Dump();
            break;
    }

static void Extract()
{
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
}

static void AddEnumReference(NormalExport export, string propname, string enumname, string enumvalue)
{
    export.Asset.AddNameReference(FString.FromString(propname));
    export.Asset.AddNameReference(FString.FromString(enumname));
    export.Asset.AddNameReference(FString.FromString(enumvalue));
    export.Data.Add(new BytePropertyData(FName.FromString(propname))
    {
        ByteType = BytePropertyType.FName,
        EnumType = FName.FromString(enumname),
        EnumValue = FName.FromString(enumvalue)
    });

    //because it's out of scope afterwards otherwise
    export.Asset.Write(export.Asset.FilePath);
}
static void Process()
{
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
                    //There's no chests with any other default value than items
                    if (!HasItem) AddEnumReference(export, "Item", "Items", "Items::NewEnumerator25");
                    Map.Write(Mapfile);
                    break;
                case "EmoteStatue_BP_C":
                case "Spirit_C":
                    HasThings = true;
                    //Fara's Grace is the only spirit at default
                    if (export.ObjectName.Value.Value == "Spirit_A01_FarasGrace")
                        AddEnumReference(export, "Amulet", "Spirits", "Spirits::NewEnumerator0");
                    //the Wave statue in forest temple
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
}

static void Dump()
{
    foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
    {
        UAsset Map = new UAsset(@Mapfile, UE4Version.VER_UE4_25); foreach (NormalExport export in Map.Exports)
            switch (export.GetExportClassType().Value.Value)
            {
                case "Chest_Master_C":
                case "Chest_Dance_C":
                case "Chest_Master_Child_C":
                case "EmoteStatue_BP_C":
                case "Spirit_C":
                    break;
                case "Pickup_C":
                    foreach (var property in export.Data) if (property.Name == FName.FromString("Type")) ;
                    break;
            }
    }
}
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