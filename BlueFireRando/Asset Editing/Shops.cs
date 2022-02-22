using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;
using static Globals;

public static class Shops
{
    public static void RandomiseShop()
    {
        UAsset SaveGame = new UAsset(HelperFunctions.GetSaveGame(), UE4Version.VER_UE4_25);
        Dictionary<BytePropertyData, BytePropertyData> Stock = new Dictionary<BytePropertyData, BytePropertyData>();
        Random random = new Random();
        if (SaveGame.Exports[1] is NormalExport export)
            foreach (PropertyData shop in export.Data)
                if (shop is ArrayPropertyData Shop && Shop.Name.ToString().Contains("Shop"))
                    foreach (StructPropertyData Item in Shop.Value)
                    {
                        if (Items) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 0 && Item.Value[7] is BytePropertyData item)
                                    Stock.Add(byt, item);

                        if (Weapons) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 1 && Item.Value[7] is BytePropertyData weapon)
                                    Stock.Add(byt, weapon);

                        if (Tunics) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 2 && Item.Value[7] is BytePropertyData tunic)
                                    Stock.Add(byt, tunic);

                        if (Spirits) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 3 && Item.Value[7] is BytePropertyData spirit)
                                    Stock.Add(byt, spirit);
                    }

        Stock = HelperFunctions.Shuffle(Stock).ToDictionary(x => x.Key, x => x.Value);

        if (SaveGame.Exports[1] is NormalExport ex)
            foreach (PropertyData shop in ex.Data)
                if (shop is ArrayPropertyData Shop && Shop.Name.ToString().Contains("Shop"))
                    foreach (StructPropertyData Item in Shop.Value)
                    {

                        if (Items) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 0)
                                {
                                    Item.Value[4] = Stock.Keys.ToArray()[0];
                                    Item.Value[7] = Stock.Values.ToArray()[0];
                                    Stock.Remove(Stock.Keys.ToArray()[0]);
                                    continue;
                                }

                        if (Weapons) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 1)
                                {
                                    Item.Value[4] = Stock.Keys.ToArray()[0];
                                    Item.Value[7] = Stock.Values.ToArray()[0];
                                    Stock.Remove(Stock.Keys.ToArray()[0]);
                                    continue;
                                }

                        if (Tunics) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 2)
                                {
                                    Item.Value[4] = Stock.Keys.ToArray()[0];
                                    Item.Value[7] = Stock.Values.ToArray()[0];
                                    Stock.Remove(Stock.Keys.ToArray()[0]);
                                    continue;
                                }

                        if (Spirits) if (Item.Value[4] is BytePropertyData byt)
                                if (byt.Value == 3)
                                {
                                    Item.Value[4] = Stock.Keys.ToArray()[0];
                                    Item.Value[7] = Stock.Values.ToArray()[0];
                                    Stock.Remove(Stock.Keys.ToArray()[0]);
                                    continue;
                                }
                    }

        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork");
        SaveGame.Write(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset");
    }
}
