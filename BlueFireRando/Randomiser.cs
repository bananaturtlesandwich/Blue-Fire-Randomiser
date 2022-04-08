namespace BlueFireRando;

public partial class Randomiser : Form
{
    public Randomiser()
    {
        InitializeComponent();
#if !DEBUG
        MessageBox.Show("There is currently a bug I'm not sure what to do with where the application will have trouble accessing the mod folder due to you having file explorer open.\nJust click randomise again and it'll work, or close file explorer before hitting randomise :)");
#endif
        //create config.txt to store modfolder if it doesn't exist
        if (!File.Exists(@".\config.txt")) File.Create(@".\config.txt");
    }

    private void Randomise_Click(object sender, EventArgs e)
    {
        //delete any previously generated seed's source
        if (Directory.Exists(@".\Randomiser_P")) Directory.Delete(@".\Randomiser_P", true);

        //Not sure if there's a better way to check for no unchecked boxes
        if (!Spirits.Checked && !Abilities.Checked && !Weapons.Checked && !Tunics.Checked && !Emotes.Checked && !Items.Checked)
        {
#if DEBUG
            Indexes.DumpIndexes();
#endif
            MessageBox.Show("You haven't checked any options!");
            return;
        }


        #region custom menu art
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu");
        if (American.Checked)
        {
            File.Copy(@".\Baseassets\USLogo.uasset", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
            File.Copy(@".\Baseassets\USLogo.uexp", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
        }
        else
        {
            File.Copy(@".\Baseassets\NormalLogo.uasset", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
            File.Copy(@".\Baseassets\NormalLogo.uexp", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
        }
        #endregion

        #region enum randomising
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\Enums");
        if (Abilities.Checked)
        {
            int[] CutAbilities = { 5, 7, 10/*for now let's also ban dash and attack*/, 0, 1 };
            Enums.RandomiseEnum(@".\Baseassets\Enums\Abilities.uasset", CutAbilities);
        }
        /*if (Weapons.Checked)
        {
            int[] UnusedWeapons = { 12,13,14 };
            Enums.RandomiseEnum(@".\Baseassets\Enums\Weapons.uasset", UnusedWeapons);
        }
        if (Items.Checked)
        {
            //this might change
            int[] CutOrKeyItems = { 2, 3, 17, 4, 6, 8, 15, 20, 21, 43, 25, 26, 22, 7, 9, 28, 10, 16, 11, 29, 12, 30, 13, 35, 36, 37, 40, 41, 42, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 56, 57, 58, 59, 60, 61, 62, 63, 68, 69, 71, 73, 74, 76, 77, 78, 79, 80, 81, 82 };
            Enums.RandomiseEnum(@".\Baseassets\Enums\Items.uasset", CutOrKeyItems);
        }
        if (Spirits.Checked)
        {
            int[] CutSpirits = { 5, 6, 8, 15, 17, 19, 20, 22, 23, 24, 26, 29, 30 };
            Enums.RandomiseEnum(@".\Baseassets\Enums\Spirits.uasset", CutSpirits);
        }
        if (Emotes.Checked)
        {
            int[] UnusedEmotes = { 14, 15 };
            Enums.RandomiseEnum(@".\Baseassets\Enums\Abilities.uasset", UnusedEmotes);
        }*/
        #endregion

        #region index randomising
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork");
        if (Emotes.Checked) Indexes.RandomiseEmotes();
        if (Spirits.Checked) Indexes.RandomiseSpirits();
        if(Items.Checked) Indexes.RandomiseItems();
        #endregion

        #region packaging and installing
        //Start the custom batch file I created
        //I cooouuuuld run cmd with parameters but I think a batch script is cleaner
        System.Diagnostics.Process.Start(@".\Packing.bat");
        MessageBox.Show("Randomisation complete!");

        //Start moving process of the .pak file to the mod folder
        string modfolder = File.ReadAllText(@".\config.txt");
        if (modfolder.Equals(""))
        {
            if (ModFolderDialog.ShowDialog() == DialogResult.OK) MessageBox.Show("Mod folder registered. edit config.txt to change this folder");
            File.WriteAllText(@".\config.txt", ModFolderDialog.SelectedPath);
        }
        modfolder = File.ReadAllText(@".\config.txt");
        if (File.Exists($@"{modfolder}\Randomiser_P.pak")) File.Delete($@"{modfolder}\Randomiser_P.pak");
        if (File.Exists($@"{modfolder}\Randomizer_P.pak")) File.Delete($@"{modfolder}\Randomizer_P.pak");
        File.Move(@".\Randomiser_P.pak", $@"{modfolder}\Randomiser_P.pak");
        //Rename the mod pak if american
        if (American.Checked) File.Move($@"{modfolder}\Randomiser_P.pak", $@"{modfolder}\Randomizer_P.pak");
        MessageBox.Show("Randomiser pak installed");
        #endregion

#if !DEBUG
        Directory.Delete(@".\Randomiser_P", true);
#endif
    }
    #region deleting mod pak
    private void DeletePak_Click(object sender, EventArgs e)
    {
        string modfolder = File.ReadAllText(@".\config.txt");
        if (File.Exists($@"{modfolder}\Randomiser_P.pak"))
        {
            File.Delete($@"{modfolder}\Randomiser_P.pak");
            MessageBox.Show("Pak file deleted");
            return;
        }
        if (File.Exists($@"{modfolder}\Randomizer_P.pak"))
        {
            File.Delete($@"{modfolder}\Randomizer_P.pak");
            MessageBox.Show("Pak file deleted");
            return;
        }
        MessageBox.Show("There was no pak to delete");
    }
    #endregion

    #region american mode switching
    private void American_CheckedChanged(object sender, EventArgs e)
    {
        if (American.Checked)
        {
            Weapons.Text = "Randomize Weapons?";
            Abilities.Text = "Randomize Abilities?";
            Spirits.Text = "Randomize Spirits?";
            Tunics.Text = "Randomize Tunics?";
            Emotes.Text = "Randomize Emotes?";
            Randomise.Text = "Randomize";
            UmbyPet.Image = UmbyPet.InitialImage;
            Logo.BackgroundImage = Logo.ErrorImage;
        }
        else
        {
            Weapons.Text = "Randomise Weapons?";
            Abilities.Text = "Randomise Abilities?";
            Spirits.Text = "Randomise Spirits?";
            Tunics.Text = "Randomise Tunics?";
            Emotes.Text = "Randomise Emotes";
            Randomise.Text = "Randomise";
            UmbyPet.Image = UmbyPet.ErrorImage;
            Logo.BackgroundImage = Logo.InitialImage;
        }
    }
    #endregion
}
