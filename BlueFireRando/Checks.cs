using System.Collections.Generic;

namespace BlueFireRando
{
    internal class Checks
    {
        public enum Check { /*Ability rando is done with enums*/  _EmoteStatue_, Spirit_, _Loot_, Tunic, Chest_, Dance_Platform_, Duck, Ember_Angel, NPC }
        public static Dictionary<string/*ObjectName*/, string/*Enumerator index*/> checks = new Dictionary<string, string>()
        {
            #region Fire Keep
            //A02_GameIntro_Exterior (The epic view)
            {"A01_FireKeep_EmoteStatue_Levitation(0)","E_Emotes::NewEnumerator2"},// A quaint emote statue, next to a stunning view and an onop with even more stunning hair
            //A02_GameIntro_DLC_VoidMaster (general map)
            //There's a duck here-well hidden next to the discovery of the first discovered (patched) out-of-bounds method
            //A02_GameIntro_KeepEast (The hall with the vessel of souls)
            {"Chest_A01_TempleGardens_Ability_SpinAttack2(0)","wait what I can't see anything?"},
            {"Chest_A02_Keep_Loot_02(0)","wait what I can't see anything?"}, //This place is weird umap wise but this pair of chests is decent-2 ore earlygame is big (you can get to both by jumping on the vessel of souls)
            //A02_GameIntro_KeepWest (idfk)
            {"Chest_A02_Keep_Loot_01(0)","WHY CAN'T I SEE YOUR CONTENTS?"}, // idk where this is lmao
            //A02_GameIntro_EastWing (The combat room)
            {"Chest_A01_Keep_Shield(0)","Abilities::NewEnumerator14"}, //Really cool ability but parry is severely underutilised in fights
            {"Chest_A02_Keep_Key_01(0)","Items::NewEnumerator6"}, // interestingly has a boolean called KeyItem. Nice beginner fight before that
            //A02_GameIntro_FirstVoidRoom (Lula's grace room)
            {"A01_FireKeep_EmoteStatue_Techno(0)","E_Emotes::NewEnumerator12"}, //Nicely hidden statue tbf plus nice dance (overshadowed by smug)
            {"Spirit_A02_RiverSpirit(0)","Spirits::NewEnumerator3"}, //A really cool spirit-I'm still amazed at the speedrun trick that allows this to be obtained early game
            #endregion

            #region Arcane Tunnels
            //A02_Arcane (general map)
            //A02_EastArcane (Spirit hunter)
            {"Chest_A02_EastArcane_Loot_01(0)","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_02(0)","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_03(0)","Items::NewEnumerator31"},//The one where the item byteproperty exists(the others may be copies?)
            {"Chest_A02_EastArcane_Loot_04(0)","Items::NewEnumerator31"},
            {"Chest_A02_EastArcane_Loot_05(0)","Items::NewEnumerator31"},
            {"Chest_A01_Arcane_Spell(0)","Abilities::NewEnumerator13"},
            //A02_NorthArcane
            {"Chest_A02_NorthArcane_Loot_01(0)","idfk how this works but ok"},
            {"Chest_A02_NorthArcane_Loot_02(0)","idfk how this works but ok"},
            {"Chest_A02_NorthArcane_Loot_03(0)","idfk how this works but ok"},
            {"A02_Arcane_EmoteStatue_Windmill(0)","E_Emotes::NewEnumerator3"}, //I like windmill because you can drill into the ground and skydive
            //A02_SouthArcane (where everything is)
            {"Dance_Platform_Celebration_Chest(0)","Items::NewEnumerator42"},
            {"Dance_Platform_KungFu_Chest(0)","Items::NewEnumerator14"}, //I forget what these chest are
            {"Chest_A02_NorthArcane_Sword_Bloodstorm(0)","Weapons::NewEnumerator1"},
            {"Chest_A02_SouthArcane_Key_01(0)","Items::NewEnumerator24"},
            {"Chest_A02_SouthArcane_Key_02(0)","not there"}, //again I believe this is a copy of the other one
            {"Chest_A02_SouthArcane_Loot_01(0)","Items::NewEnumerator24"},
            {"Dance_Platform_Celebration_Platform(0)","E_Emotes::NewEnumerator9"}, // I assume the emote required to use it
            {"Dance_Platform_Celebration_Target(0)","E_Emotes::NewEnumerator9"}, // I assume the emote required to use it
            {"Dance_Platform_KungFu_Platform(0)","E_Emotes::NewEnumerator11"}, // I assume the emote required to use it
            {"Dance_Platform_KungFu_Target(0)","E_Emotes::NewEnumerator11"}, // I assume the emote required to use it
            //debating whether I should include emote platforms
            #endregion

            #region Waterways
            //A02_CentralWaterWay (has a duck)
            //A02_CentralWaterWay_CenterAccess
            {"Chest_A02_Tunic_PureShadow(0)","Tunics::NewEnumerator7"}, //Pure shadow is a cool tunic-especially with neon abyss mask
            {"A02_Arcane_EmoteStatue_HatKid(0)","E_Emotes::NewEnumerator4"}, //Awesome reference imo - official too because GBF retweeted it
            #endregion

            #region Uthas (The fact this is in the same folder as intro and arcane is a crime)
            //A01_SmallShrine_Intro
            {"Chest_A01_Uthas_Key_04(0)","Items::NewEnumerator6"},
            {"Chest_A01_Uthas_Loot_02(0)","Items::NewEnumerator24"},
            {"Chest_A01_Uthas_Loot_03(0)","Items::NewEnumerator31"},
            //A01_SmallShrine_EndPath
            {"Chest_A01_Uthas_Key_05(0)","Items::NewEnumerator6"},
            //A01_SmallShrine_BottomPassage
            {"Chest_A01_Uthas_Key_03(0)","Items::NewEnumerator6"},
            //A01_SmallShrine_Main
            {"Chest_A01_Uthas_Key_02(0)","Items::NewEnumerator6"},
            {"Chest_A01_Uthas_Loot_04(0)","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot_05(0)","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot_06(0)","Items::NewEnumerator31"},
            {"Chest_A01_Uthas_Loot(0)","Items::NewEnumerator31"},//Weapons::NewEnumerator7(peace keepers)
            {"Chest_A01_Uthas_Loot_01(0)","Abilities::NewEnumerator1"},//Items::NewEnumerator72 this is the uthas bracelet
            {"Chest_A01_Uthas_MasterKey2(0)","Items::NewEnumerator72"},
            {"A01_Uthas_EmoteStatue_Party(0)","E_Emotes::NewEnumerator13"},
            {"A01_Uthas_EmoteStatue_Photo(0)","E_Emotes::NewEnumerator8"},
            //A01_SmallShrine_SouthEast
            {"Chest_A01_Uthas_Key_01(0)","Items::NewEnumerator6"},
            //A01_SmallShrine_SouthWest
            {"Chest_A01_Uthas_MasterKey(0)","Items::NewEnumerator72"},
            #endregion

            #region Crossroads
            //A01_Well
            {"Chest_A01_CrossRoads_Loot(0)",""},//aaaagghgghgh
            {"Chest_A01_Well_SpinAttack(0)","Abilities::NewEnumerator15"},
            //A01_CrossRoads
            {"Dance_Platform_Techno_Chest(0)","Tunics::NewEnumerator15"},//Items::NewEnumerator42(Rice)
            {"Chest_A01_CrossRoads_Loot_01(0)",""},
            {"Chest_A01_CrossRoads_Loot_02(0)",""},
            {"Chest_A01_CrossRoads_Loot_03(0)",""},
            #endregion

            #region Stoneheart City
            //A01_CliffPath
            {"Dance_Platform_Triceps_Chest(0)","Items::NewEnumerator17"},
            {"Chest_A01_Stoneheart_Loot_01(0)",""},
            {"Chest_A01_Stoneheart_Loot_02(0)","Items::NewEnumerator31"},//also has an amount variable
            {"Chest_A01_Stoneheart_Loot_03(0)",""},
            {"Chest_A01_Stoneheart_Loot(0)",""},
            {"Chest_A01_Stoneheart_Tunic_MerchantsRobe(0)","Items::NewEnumerator24"},
            {"Chest_Master_A01_StoneheartCity_GraveyardKey(0)","Items::NewEnumerator26"},
            {"Chest_Master_A01_StoneheartCity_GraveyardKey2(0)","Items::NewEnumerator31"},
            {"Chest_A01_Tunic_AlphaTunic(0)","Tunics::NewEnumerator31"},
            #endregion

            #region Forest Shrine
            //A01_AbilityShrine
            {"Dance_Platform_Hello2_Chest(0)","Items::NewEnumerator45"},
            {"Chest_A01_Nuos_MasterKey(0)","Items::NewEnumerator72"},
            //A01_AbilityShrine_AmbushZone
            {"Chest_A01_Nuos_Key_01(0)","Items::NewEnumerator6"},
            {"Chest_A01_Nuos_Loot_01(0)","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Ability_WallRun(0)","Abilities::NewEnumerator9"},
            {"Chest_A01_Nuos_Key_03(0)","Items::NewEnumerator72"},
            //A01_AbilityShrine_CenterTree
            {"Chest_A01_Nuos_Key_02(0)","Items::NewEnumerator6"},
            {"Chest_A01_Nuos_Loot_04(0)","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Loot_06(0)","Items::NewEnumerator24"},
            {"Chest_A01_TempleGardens_Sword_SilverBlades(0)","Weapons::NewEnumerator10"},
            {"A01_Nuos_EmoteStatue_Wave(0)",""},
            //A01_AbilityShrine_WaterLevels
            {"Chest_A01_Nuos_Key_2(0)","Items::NewEnumerator6"},
            {"Chest_A01_Nuos_Loot_02(0)","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Loot_03(0)","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Loot_05(0)","Items::NewEnumerator24"},
            {"Chest_A01_Nuos_Loot(0)","Items::NewEnumerator31"},//Amount is 3
            {"Spirit_A01_ForestGuardian(0)","Spirits::NewEnumerator13"},
            #endregion

            #region Temple Gardens
            //A01_TempleGardens
            {"Ember_Angel_TempleGardens_Juro_Tunic(0)",""},//still a check
            {"Dance_Platform_Applause_Tunic_BananaKing(0)","Tunics::NewEnumerator16"},
            {"Dance_Platform_Wave_Chest(0)","Tunics::NewEnumerator16"},//Items::NewEnumerator46
            {"Chest_A01_TempleGardens_Loot_01(0)",""},
            {"Chest_A01_TempleGardens_Loot_02(0)",""},
            {"Chest_A01_TempleGardens_Loot_03(0)",""},
            {"Chest_A01_TempleGardens_Loot_04(0)",""},
            {"Chest_A01_TempleGardens_Loot_05(0)",""},
            {"Chest_A01_TempleGardens_Loot_06(0)",""},
            {"Chest_A01_TempleGardens_Loot_07(0)",""},
            {"Chest_A01_TempleGardens_Loot_08(0)",""},
            {"Chest_A01_TempleGardens_RareSnow(0)","Items::NewEnumerator26"},
            {"Chest_A01_TempleGardens_Sword_Shanks(0)","Weapons::NewEnumerator8"},
            {"NPC_Nilo(3)",""},//technically still a check
                            //There's a duck here
            #endregion

            #region Abandoned Path
            //A01_Graveyard
            {"Dance_Platform_Levitation_Chest","Items::NewEnumerator55"},
            {"Chest_A01_Graveyard_IceDestroyers","Weapons::NewEnumerator6"},
            {"Chest_A01_Graveyard_Loot_01",""},
            {"Chest_A01_Graveyard_Loot_02",""},
            {"Chest_A01_Graveyard_Loot_03",""},
            {"Chest_A02_Tunic_HolyAttire","Tunics::NewEnumerator2"},
            {"A01_Graveyard_EmoteStatue_Aggressive","E_Emotes::NewEnumerator6"},
            {"A01_Graveyard_EmoteStatue_No","E_Emotes::NewEnumerator7"},
            {"Pickup_BremurPicture","Items::NewEnumerator27"},//PickUpList::NewEnumerator1
            {"Pickup_Necklace","Items::NewEnumerator70"},
            {"Pickup_Rose","Items::NewEnumerator9"},
            {"Pickup_Rose2","Items::NewEnumerator9"},
            //There's another duck here

            //A01_GraveyardShrine
            {"Ember_Angel_Graveyard_Kuna_Oddstone",""},
            {"Chest_A01_Graveyard_Key_01","Items::NewEnumerator24"},
            {"Spirit_A01_AngryAmbusher","Spirits::NewEnumerator4"},
            //There's a duck here
            #endregion

            #region FireFall River
            //A06_FireFall_A
            {"Dance_Platform_HatKid_Chest","Weapons::NewEnumerator4"},//Items::NewEnumerator42
            {"Chest_A06_River_Loot_01",""},
            {"Chest_A06_River_Loot_03",""},
            //A06_FireFall_B
            {"Dance_Platform_Windmill_Chest","Items::NewEnumerator54"},
            {"Chest_A06_River_Loot_02",""},
            {"A06_Firefall_EmoteStatue_KungFu","E_Emotes::NewEnumerator11"},
            {"NPC_Master_Onari",""},
            {"NPC_Mia_Firefall",""},
            {"NPC_Onop_Speedo",""},
            //A06_FireFallRiver
            #endregion
        };
    }
}
