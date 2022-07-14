using UAssetAPI;
using UAssetAPI.UnrealTypes;

namespace BlueFireRando;

public partial class Randomiser : Form
{
    public Randomiser()
    {
        InitializeComponent();
        //create config.txt to store modfolder if it doesn't exist
        if (!File.Exists(@"config.txt")) File.Create(@"config.txt");
    }

    void Randomise_Click(object sender, EventArgs e)
    {
        //Not sure if there's a better way to check for no unchecked boxes
        if (!Spirits.Checked && !Abilities.Checked && !Weapons.Checked && !Tunics.Checked && !Emotes.Checked && !Items.Checked)
        {
            MessageBox.Show("You haven't checked any options!");
            return;
        }

#if DEBUG
        //delete any previously generated seed's source
        if (Directory.Exists(@"Randomiser_P")) Directory.Delete(@"Randomiser_P", true);
#endif
        #region custom menu art
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu");
        File.Copy(American.Checked ? @"Baseassets\USLogo.uasset" : @"Baseassets\Logo.uasset", @"Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
        File.Copy(American.Checked ? @"Baseassets\USLogo.uexp" : @"Baseassets\Logo.uexp", @"Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
        #endregion

        #region creating folders xwx
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
        Directory.CreateDirectory(@"Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork");
        #endregion

        //start from scratch >o<

        #region packaging and installing
        //Start the custom batch file I created
        System.Diagnostics.Process.Start(@"Packing.bat");
        MessageBox.Show("Randomisation complete!");

        //Start moving process of the .pak file to the mod folder
        string modfolder = File.ReadAllText(@"config.txt");
        if (modfolder == "")
        {
            if (ModFolderDialog.ShowDialog() == DialogResult.OK) MessageBox.Show("Mod folder registered. edit config.txt to change this folder");
            File.WriteAllText(@"config.txt", ModFolderDialog.SelectedPath);
        }
        modfolder = File.ReadAllText(@"config.txt");
        if (File.Exists($@"{modfolder}\Rando_P.pak")) File.Delete($@"{modfolder}\Rando_P.pak");
        File.Move(@"Rando_P.pak", $@"{modfolder}\Rando_P.pak");
        MessageBox.Show("Randomiser pak installed");
        #endregion

        //Users don't need to see the source quickly and bugged seeds can be unpaked
#if !DEBUG
        Directory.Delete(@"Randomiser_P", true);
#endif
    }
    #region deleting mod pak
    void OnDeletePakClick(object sender, EventArgs e)
    {
        string modfolder = File.ReadAllText(@"config.txt");
        if (File.Exists($@"{modfolder}\Rando_P.pak"))
        {
            File.Delete($@"{modfolder}\Rando_P.pak");
            MessageBox.Show("Pak file deleted");
            return;
        }
        MessageBox.Show("There was no pak to delete");
    }
    #endregion

    #region american mode switching
    void OnAmericanCheck(object sender, EventArgs e)
    {
        if (American.Checked)
        {
            RandomiseButton.Text = "Randomize";
            UmbyPet.Image = UmbyPet.InitialImage;
            Logo.BackgroundImage = Logo.ErrorImage;
            return;
        }
        RandomiseButton.Text = "Randomise";
        UmbyPet.Image = UmbyPet.ErrorImage;
        Logo.BackgroundImage = Logo.InitialImage;
    }
    #endregion

    //And now the hair-pulling logic begins...
    Dictionary<string, string> CheckData = new();

    //The logic for the rando seed generation is here
    void GenerateSeed()
    {
        Queue<StaticWorld.Check> names;
        while (TryFindChecks(out var checks))
        {
            //randomise the positions of the checks
            names = new(Helpers.Shuffle(checks));
            for (int i = 0; i < names.Count; i++)
                CheckData.TryAdd(names.Dequeue().name,);
        }
    }

    public static bool TryFindChecks(out List<StaticWorld.Check> checks)
    {
        checks = new();
        //look at the inventory and from that determine the accessible area and add all less than
        //then check the requirements and cut if necessary
        return checks == new List<StaticWorld.Check>() ? false : true;
    }

    //Writes the randomised data stored in CheckData to the maps
    void WriteData()
    {
        foreach (string MapFile in Directory.GetFiles(@"Baseassets\World", "*.umap", SearchOption.AllDirectories))
        {
            UAsset Map = new(MapFile, UE4Version.VER_UE4_25);
            for (int i = 0; i < Map.Exports.Count; i++)
                if (CheckData.ContainsKey(Map.Exports[i].ObjectName.Value.Value))
                {
                    string value = CheckData[Map.Exports[i].ObjectName.Value.Value];
                    if (value[..5] == "Items")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator0");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Item", "Items", value);
                        continue;
                    }
                    if (value[..7] == "Weapons")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator1");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Weapon", "Weapons", value);
                        continue;
                    }
                    if (value[..6] == "Tunics")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator2");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Tunic", "Tunics", value);
                        continue;
                    }
                    if (value[..7] == "Spirits")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator3");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Amulet", "Spirits", value);
                        continue;
                    }
                    if (value[..9] == "Abilities")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator6");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Ability", "Abilities", value);
                        continue;
                    }
                    if (value[..8] == "E_Emotes")
                    {
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Type", "InventoryItemType", "InventoryItemType::NewEnumerator7");
                        Helpers.AddEnumReference((NormalExport)Map.Exports[i], "Emote", "E_Emotes", value);
                        continue;
                    }
                }
            Map.Write(MapFile.Replace("Baseassets", @"Randomiser_P\Blue Fire\Content\BlueFire\Maps"));
        }
    }
}