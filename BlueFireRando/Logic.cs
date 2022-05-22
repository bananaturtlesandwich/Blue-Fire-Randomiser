namespace BlueFireRando;

partial class Randomiser
{
    readonly string[] FirstDoor = new string[]
    {
        "Chest_A01_TempleGardens_Ability_SpinAttack2",
        "Chest_A02_Keep_Loot_02",
        "Chest_A01_Keep_Shield",
        "Chest_A02_Keep_Key_01",
        "A01_FireKeep_EmoteStatue_Levitation"
    };

    void Randomise()
    {
        PoolProcessing();
        var rndm = new Random();
        int Key = rndm.Next(FirstDoor.Length);
        foreach (string Mapfile in Helpers.GetMaps())
        {
            UAsset Map = new UAsset(Mapfile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                if (FirstDoor.Contains(export.ObjectName.Value.Value))
                    if (export.ObjectName.Value.Value == FirstDoor[Key])
                        foreach (var prop in export.Data)
                            if (prop is BytePropertyData byt)
                            {
                                Map.AddNameReference(FString.FromString("InventoryItemType::NewEnumerator0"));
                                Map.AddNameReference(FString.FromString("Item"));
                                Map.AddNameReference(FString.FromString("Items"));
                                Map.AddNameReference(FString.FromString("Items::NewEnumerator6"));
                                if (byt.Name.Value.Value == "Type") byt.EnumValue = FName.FromString("InventoryItemType::NewEnumerator0");
                                export.Data.Add(new BytePropertyData(FName.FromString("Item"))
                                {
                                    EnumType = FName.FromString("Items"),
                                    EnumValue = FName.FromString("Items::NewEnumerator6")
                                });
                            }
        }
    }

    void PoolProcessing()
    {
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
                        List<PropertyData> PropertiesToClear = new();
                        for (int i = 0; i < export.Data.Count; i++)
                            if (export.Data[i] is BytePropertyData property)
                            {
                                if (property.Name.Value.Value == "Type") break;
                                if (!Weapons.Checked && property.Name.Value.Value == "Weapon") break;
                                if (!Items.Checked && property.Name.Value.Value == "Item") break;
                                if (!Spirits.Checked && property.Name.Value.Value == "Amulet") break;
                                if (!Tunics.Checked && property.Name.Value.Value == "Tunic") break;
                                PropertiesToClear.Add(property);
                            }
                        foreach (var property in PropertiesToClear) export.Data.Remove(property);
                        break;
                        //No need to remove anything here because this can't be mixed
                        /*case "EmoteStatue_BP_C":
                        case "Spirit_C":
                        case "Pickup_C":*/
                }
            }
            Map.Write(Mapfile.Replace("Baseassets", @"Randomiser_P\Blue Fire\Content\BlueFire\Maps"));
        }
        File.Copy(@".\Baseassets\BlueFireSaveGame.uasset", Helpers.GetSaveGame());
    }
}
