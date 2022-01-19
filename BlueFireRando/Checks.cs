using System.Collections.Generic;

namespace BlueFireRando
{
    internal class Checks
    {
        Dictionary<string/*ObjectName*/, string/*Enumerator index*/> checks = new Dictionary<string, string>()
        {
            //Fire Keep

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

            //Arcane Tunnels

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

            //Waterways

            //A02_CentralWaterWay (has a duck)
            //A02_CentralWaterWay_CenterAccess
            {"Chest_A02_Tunic_PureShadow","Tunics::NewEnumerator7"}, //Pure shadow is a cool tunic-especially with neon abyss mask
            {"A02_Arcane_EmoteStatue_HatKid","E_Emotes::NewEnumerator4"} //Awesome reference imo - official too because GBF retweeted it


        };
    }
}
