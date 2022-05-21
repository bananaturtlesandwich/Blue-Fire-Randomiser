namespace BlueFireRando;

public partial class Randomiser : Form
{
    public Randomiser()
    {
        InitializeComponent();
        //create config.txt to store modfolder if it doesn't exist
        if (!File.Exists(@".\config.txt")) File.Create(@".\config.txt");
    }

    void Randomise_Click(object sender, EventArgs e)
    {
        //Not sure if there's a better way to check for no unchecked boxes
        if (!Spirits.Checked && !Abilities.Checked && !Weapons.Checked && !Tunics.Checked && !Emotes.Checked && !Items.Checked)
        {
            MessageBox.Show("You haven't checked any options!");
            return;
        }

        //delete any previously generated seed's source
        if (Directory.Exists(@".\Randomiser_P")) Directory.Delete(@".\Randomiser_P", true);
        #region custom menu art
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu");
        File.Copy(American.Checked ? @".\Baseassets\USLogo.uasset" : @".\Baseassets\NormalLogo.uasset", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
        File.Copy(American.Checked ? @".\Baseassets\USLogo.uexp" : @".\Baseassets\NormalLogo.uexp", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
        #endregion

        #region creating folders xwx
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
        Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork");
        #endregion

        //start from scratch >o<
        Randomise();

        #region packaging and installing
        //Start the custom batch file I created
        //I cooouuuuld run cmd with parameters but I think a batch script is cleaner
        System.Diagnostics.Process.Start(@".\Packing.bat");
        MessageBox.Show("Randomisation complete!");

        //Start moving process of the .pak file to the mod folder
        string modfolder = File.ReadAllText(@".\config.txt");
        if (modfolder == "")
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
}
