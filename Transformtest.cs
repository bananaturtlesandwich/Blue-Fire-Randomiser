using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

namespace BlueFireRando
{
    public partial class Transformtest
    {
        static public void RandTransform(string filepath, string endpath)
        {
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            for (int i = 0; i < y.Exports.Count; i++)
            {
                if (y.Exports[i] is NormalExport us)
                {
                    string chestref = us.ObjectName.ToString();
                    string[] Chests = {"Dance_Platform_Hello2_Chest", "Chest_A01_Nuos_MasterKey", "Chest_A01_Nuos_Key_01", "Chest_A01_Nuos_Loot_01", "Chest_A01_Nuos_Ability_WallRun", "Chest_A01_Nuos_Key_03", "Chest_A01_Nuos_Key_02", "Chest_A01_Nuos_Loot_04", "Chest_A01_Nuos_Loot_06", "Chest_A01_TempleGardens_Sword_SilverBlades", "Chest_A01_Nuos_Key", "Chest_A01_Nuos_Loot_02", "Chest_A01_Nuos_Loot_03", "Chest_A01_Nuos_Loot_05", "Chest_A01_Nuos_Loot", "Dance_Platform_Triceps_Chest", "Chest_A01_Stoneheart_Loot_01", "Chest_A01_Stoneheart_Loot_02", "Chest_A01_Stoneheart_Loot_03","Chest_A01_Stoneheart_Loot","Chest_A01_Stoneheart_Tunic_MerchantsRobe", "Chest_Master_A01_StoneheartCity_GraveyardKey", "Chest_Master_A01_StoneheartCity_GraveyardKey2", "Chest_A01_Tunic_AlphaTunic", "Dance_Platform_Techno_Chest", "Chest_A01_CrossRoads_Loot_01", "Chest_A01_CrossRoads_Loot_02", "Chest_A01_CrossRoads_Loot_03", "Dance_Platform_Levitation_Chest", "Chest_A01_Graveyard_IceDestroyers", "Chest_A01_Graveyard_Loot_01", "Chest_A01_Graveyard_Loot_02", "Chest_A01_Graveyard_Loot_03", "Chest_A02_Tunic_HolyAttire" };
                    string[] Spirits={"Spirit_A01_ForestGuardian", "Spirit_A01_FarasGrace" };
                    string[] DancePads = {"Dance_Platform_Hello2_Platform", "Dance_Platform_Hello2_Target", "Dance_Platform_Triceps_Platform","Dance_Platform_Triceps_Target","Dance_Platform_Techno_Platform", "Dance_Platform_Techno_Target", "Dance_Platform_Levitation_Platform", "Dance_Platform_Levitation_Target" };
                    string[] EmoteStatues = {"A01_Nuos_EmoteStatue_Wave", "A01_Graveyard_EmoteStatue_Aggressive", "A01_Graveyard_EmoteStatue_No" };
                    string[] WildOre = { "Pickup27", "Pickup29", "Pickup34", "Pickup45", "Pickup46", "Pickup51", "Pickup54","Pickup_A01_City_SRL", "Pickup_A01_City_SRL2", "Pickup_A01_City_SRL3", "Pickup_Book", "Pickup_Book2", "Pickup_Book3", "Pickup_Book4", "Pickup_Book5", "Pickup_SandRelic", "Pickup_BremurPicture", "Pickup_Necklace", "Pickup_Rose", "Pickup_Rose2" };
                    string[] Signs = {"Sign_BP","Sign_BP2","Sign_BP20","Sign_BP","Sign_BP8" };
                    string[] Ducks = { "Duck2","Duck" };
                    if (chestref.Contains("Chest") || chestref.StartsWith("Spirit") || chestref.Contains("Dance"))
                    {
                        for (int j = 0; j < us.Data.Count; j++)
                        {
                            if (us.Data[j].Name.Equals(FName.FromString("RootComponent")) && us.Data[j] is ObjectPropertyData ob)
                            {
                                //MessageBox.Show(y.Exports[Convert.ToInt32(ob.Value.ToString())].ObjectName.ToString());
                                //FINALLY!!!!!
                                if (y.Exports[Convert.ToInt32(ob.Value.ToString())] is NormalExport egg)
                                {
                                    foreach (var data in egg.Data)
                                    {
                                        if (data.Name.Equals(FName.FromString("RelativeLocation")) && data is StructPropertyData loc)
                                        {
                                            loc.Value = new List<PropertyData>
                                            {
                                                new VectorPropertyData(FName.FromString("Vector"))
                                                {
                                                    Value= new FVector(50,50,50)
                                                }
                                            };
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            y.Write(endpath);
        }
    }
}
