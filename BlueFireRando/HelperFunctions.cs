using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UAssetAPI;
using static Globals;

public static partial class HelperFunctions
{
    public static int RandInt(int MaxValue, int[] Banned)
    {
        int temp;
        Random rndm = new Random();
        do temp = rndm.Next(MaxValue); while (Banned.Contains(temp));
        return temp;
    }

    public static string[] GetMaps()
    {
        return Directory.Exists(@".\Randomiser_P\World") ? Directory.GetFiles(@".\Randomiser_P\World", "*.umap", SearchOption.AllDirectories) : Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);
    }

    //is this more or less efficient than scanning through exports each time you want to change something?
    public static List<Export> GetWantedExports()//incomplete-look at strategy guide for locations
    {
        List<Export> exports = new List<Export>();
        //Emote statues, dance platforms, ducks, ember angels and NPCs can all be found with identifiers
        string[] Ability = { "Chest_A01_Keep_Shield", "Chest_A01_Arcane_Spell", "Chest_A01_Nuos_Ability_WallRun", "Chest_A01_Uthas_Loot_01", "NPC_Onop_Speedo" };
        string[] Spirit = { "Spirit_A","Dance_Platform_Party_Chest_Spirit_HammerKing" };
        string[] Tunic = { "" };
        string[] Loot = { "" };
        string[] Item = { "" };
        string[] Weapon = { "" };
        foreach (string file in GetMaps())
        {
            if (Abilities) exports.AddRange(GetExport(file, Ability));
            if (Spirits) exports.AddRange(GetExport(file, Spirit));
            if (Tunics) exports.AddRange(GetExport(file, Tunic));
            if (Weapons) exports.AddRange(GetExport(file, Weapon));
            if (Emotes) exports.AddRange(GetExport(file, "_EmoteStatue_"));
            if (Ducks) exports.AddRange(GetExport(file, "Duck"));
        }
        return exports;
    }

    public static List<Export> GetExport(string path, string identifier)
    {
        UAsset Map = new UAsset(@path, UE4Version.VER_UE4_25);
        List<Export> output = new List<Export>();
        foreach (Export export in Map.Exports) if (export.ObjectName.ToString().Contains(identifier)) output.Add(export);
        return output;
    }

    public static List<Export> GetExport(string path, string[] identifiers)
    {
        UAsset Map = new UAsset(@path, UE4Version.VER_UE4_25);
        List<Export> output = new List<Export>();
        foreach (string identifier in identifiers) foreach (Export export in Map.Exports) if (export.ObjectName.ToString().Contains(identifier)) output.Add(export);
        return output;
    }
}