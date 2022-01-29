using System;
using System.Collections.Generic;
using System.IO;
//using System.Windows.Forms;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;
using static ButtonBools;

public static class Maps
{
    public enum Check { Ability, _EmoteStatue_, Spirit_, _Loot_, Tunic, Chest_, Dance_Platform_, Duck, Ember_Angel, NPC }

    public static void CreateMapDirectories()
    {
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
    }

    public static void Shuffle(List<FVector> list,out List<FVector> output)
    {
        Random rndm=new Random();
        output=new List<FVector>();
        for(int i = 0; i < list.Count; i++)
        {
            var temp = list[rndm.Next(list.Count)];
            output.Add(temp);
            list.Remove(temp);
        }
    }

    public static List<FVector> GetAllLocations()
    {
        List<FVector> Locations = new List<FVector>();

        string[] fileentries = Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);//Get all the map files
        foreach (string file in fileentries)
        {
            UAsset map = new UAsset(file, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(map.VerifyBinaryEquality() ? "yes" : "no")}");
            foreach (var export in map.Exports)
            {
                if (Emotes) Locations.Add(GetLocation(map, export, "_EmoteStatue_"));
                if (Spirits) Locations.Add(GetLocation(map, export, "Spirit_"));
                if (Tunics) Locations.Add(GetLocation(map, export, "_Tunic_"));
                if (Weapons) Locations.Add(GetLocation(map, export, "Chest_"));
            }
        }
        foreach (var location in Locations) if (location.Equals(new FVector())) Locations.Remove(location);//removes the new Fvectors
        return Locations;
    }

    public static FVector GetLocation(UAsset map, Export export, string identifier)
    {
        if (export.ToString().Contains(identifier) && export is NormalExport ex) foreach (var data in ex.Data) if (data.Name.Equals(FName.FromString("RootComponent")) && data is ObjectPropertyData ob) if (map.Exports[int.Parse(ob.Value.ToString())] is NormalExport norm) foreach (var item in norm.Data) if (item.Name.Equals(FName.FromString("RelativeLocation")) && item is StructPropertyData struc) if (struc.Value[0].Name.Equals(FName.FromString("RelativeLocation")) && struc.Value[0] is VectorPropertyData vec)
        {
            string[] vector = vec.ToString().Replace('(', ',').Replace(')', ',').Split(',');
            return new FVector(float.Parse(vector[1]), float.Parse(vector[3]), float.Parse(vector[5]));
        }
        return new FVector();
    }

    public static void SetAllLocations()
    {

    }
}