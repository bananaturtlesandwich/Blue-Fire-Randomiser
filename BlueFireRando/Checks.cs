using System.Collections.Generic;

namespace BlueFireRando
{
    internal class Checks
    {
        Dictionary<string/*ObjectName*/, string/*Enumerator index*/> checks = new Dictionary<string, string>()
        {
            #region Fire Keep
            //A02_GameIntro_Exterior (The epic view)
            {"A01_FireKeep_EmoteStatue_Levitation","E_Emotes::NewEnumerator2"},// A quaint emote statue, next to a stunning view and an onop with even more stunning hair
            //A02_GameIntro_DLC_VoidMaster (general map)
            //There's a duck here-well hidden next to the discovery of the first discovered (patched) out-of-bounds method
            //A02_GameIntro_KeepEast (The hall with the vessel of souls)
            {"Chest_A01_TempleGardens_Ability_SpinAttack2","wait what I can't see anything?"},
            {"Chest_A02_Keep_Loot_02","wait what I can't see anything?"}, //This place is weird umap wise but this pair of chests is decent-2 ore earlygame is big (you can get to both by jumping on the vessel of souls)
            //A02_GameIntro_KeepWest (idfk)
            {"Chest_A02_Keep_Loot_01","WHY CAN'T I SEE YOUR CONTENTS?"}, // idk where this is lmao
            //A02_GameIntro_EastWing (The combat room)
            {"Chest_A01_Keep_Shield","Abilities::NewEnumerator14"}, //Really cool ability but parry is severely underutilised in fights
            {"Chest_A02_Keep_Key_01","Items::NewEnumerator6"}, // interestingly has a boolean called KeyItem. Nice beginner fight before that
            //A02_GameIntro_FirstVoidRoom (Lula's grace room)
            {"A01_FireKeep_EmoteStatue_Techno","E_Emotes::NewEnumerator12"}, //Nicely hidden statue tbf plus nice dance (overshadowed by smug)
            {"Spirit_A02_RiverSpirit","Spirits::NewEnumerator3"}, //A really cool spirit-I'm still amazed at the speedrun trick that allows this to be obtained early game
            #endregion

            #region Arcane Tunnels
            //A02_Arcane (general map)
            //A02_EastArcane (Spirit hunter)
            {"Chest_A02_EastArcane_Loot_01","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_02","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_03","Items::NewEnumerator31"},//The one where the item byteproperty exists(the others may be copies?)
            {"Chest_A02_EastArcane_Loot_04","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_05","Items::NewEnumerator31"},
            {"Chest_A01_Arcane_Spell","Abilities::NewEnumerator13"},
            //A02_NorthArcane
            {"Chest_A02_NorthArcane_Loot_01","idfk how this works but ok"},
            {"Chest_A02_NorthArcane_Loot_02","idfk how this works but ok"},
            {"Chest_A02_NorthArcane_Loot_03","idfk how this works but ok"},
            {"A02_Arcane_EmoteStatue_Windmill","E_Emotes::NewEnumerator3"}, //I like windmill because you can drill into the ground and skydive
            //A02_SouthArcane (where everything is)
            {"Dance_Platform_Celebration_Chest","Items::NewEnumerator42"}, 
            {"Dance_Platform_KungFu_Chest","Items::NewEnumerator14"}, //I forget what these chest are
            {"Chest_A02_NorthArcane_Sword_Bloodstorm","Weapons::NewEnumerator1"},
            {"Chest_A02_SouthArcane_Key_01","Items::NewEnumerator24"},
            {"Chest_A02_SouthArcane_Key_02","not there"}, //again I believe this is a copy of the other one
            {"Chest_A02_SouthArcane_Loot_01","Items::NewEnumerator24"},
            {"Dance_Platform_Celebration_Platform","E_Emotes::NewEnumerator9"}, // I assume the emote required to use it
            {"Dance_Platform_Celebration_Target","E_Emotes::NewEnumerator9"}, // I assume the emote required to use it
            {"Dance_Platform_KungFu_Platform","E_Emotes::NewEnumerator11"}, // I assume the emote required to use it
            {"Dance_Platform_KungFu_Target","E_Emotes::NewEnumerator11"}, // I assume the emote required to use it
            //debating whether I should include emote platforms
            #endregion

            #region Waterways
            //A02_CentralWaterWay (has a duck)
            //A02_CentralWaterWay_CenterAccess
            {"Chest_A02_Tunic_PureShadow","Tunics::NewEnumerator7"}, //Pure shadow is a cool tunic-especially with neon abyss mask
            {"A02_Arcane_EmoteStatue_HatKid","E_Emotes::NewEnumerator4"}, //Awesome reference imo - official too because GBF retweeted it
            #endregion

            #region Uthas (The fact this is in the same folder as intro and arcane is a crime)
            //A01_SmallShrine_Intro
            {"Chest_A01_Uthas_Key_04","Items::NewEnumerator6"},
            {"Chest_A01_Uthas_Loot_02","Items::NewEnumerator24"},
            {"Chest_A01_Uthas_Loot_03","Items::NewEnumerator31"},
            //A01_SmallShrine_EndPath
            {"Chest_A01_Uthas_Key_05","Items::NewEnumerator6"},
            //A01_SmallShrine_BottomPassage
            {"Chest_A01_Uthas_Key_03","Items::NewEnumerator6"},
            //A01_SmallShrine_Main
            {"Chest_A01_Uthas_Key_02","Items::NewEnumerator6"},
            {"Chest_A01_Uthas_Loot_04","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot_05","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot_06","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot","Items::NewEnumerator31"},//Weapons::NewEnumerator7(peace keepers)
            {"Chest_A01_Uthas_Loot_01","Abilities::NewEnumerator1"},//Items::NewEnumerator72 this is the uthas bracelet
            {"Chest_A01_Uthas_MasterKey2","Items::NewEnumerator72"},
            {"A01_Uthas_EmoteStatue_Party","E_Emotes::NewEnumerator13"},
            {"A01_Uthas_EmoteStatue_Photo","E_Emotes::NewEnumerator8"},
            //A01_SmallShrine_SouthEast
            {"Chest_A01_Uthas_Key_01","Items::NewEnumerator6"},
            //A01_SmallShrine_SouthWest
            {"Chest_A01_Uthas_MasterKey","Items::NewEnumerator72"},
            #endregion

            #region Crossroads
            //A01_Well
            {"Chest_A01_CrossRoads_Loot",""},//aaaagghgghgh
            {"Chest_A01_Well_SpinAttack","Abilities::NewEnumerator15"},
            //A01_CrossRoads
            {"Dance_Platform_Techno_Chest","Tunics::NewEnumerator15"},//Items::NewEnumerator42(Rice)
            {"Chest_A01_CrossRoads_Loot_01",""},
            {"Chest_A01_CrossRoads_Loot_02",""},
            {"Chest_A01_CrossRoads_Loot_03",""},
            #endregion

            #region Stoneheart City
            //A01_CliffPath
            {"Dance_Platform_Triceps_Chest","Items::NewEnumerator17"},
            {"Chest_A01_Stoneheart_Loot_01",""},
            {"Chest_A01_Stoneheart_Loot_02","Items::NewEnumerator31"},//also has an amount variable
            {"Chest_A01_Stoneheart_Loot_03",""},
            {"Chest_A01_Stoneheart_Loot",""},
            {"Chest_A01_Stoneheart_Tunic_MerchantsRobe","Items::NewEnumerator24"},
            {"Chest_Master_A01_StoneheartCity_GraveyardKey","Items::NewEnumerator26"},
            {"Chest_Master_A01_StoneheartCity_GraveyardKey2","Items::NewEnumerator31"},
            {"Chest_A01_Tunic_AlphaTunic","Tunics::NewEnumerator31"},
            #endregion

            #region Forest Shrine
            //A01_AbilityShrine
            {"Dance_Platform_Hello2_Chest","Items::NewEnumerator45"},
            {"Chest_A01_Nuos_MasterKey","Items::NewEnumerator72"},
            //A01_AbilityShrine_AmbushZone
            {"Chest_A01_Nuos_Key_01","Items::NewEnumerator6"},
            {"Chest_A01_Nuos_Loot_01","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Ability_WallRun","Abilities::NewEnumerator9"},
            {"Chest_A01_Nuos_Key_03","Items::NewEnumerator72"},
            //A01_AbilityShrine_CenterTree
            {"" }
            #endregion
        };
    }
}
