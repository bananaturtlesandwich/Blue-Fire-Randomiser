using System;
using System.IO;
using System.Windows.Forms;

namespace BlueFireRando
{
    public partial class Randomiser : Form
    {
        public Randomiser()
        {
            InitializeComponent();

            //create config.txt to store modfolder if it doesn't exist
            if (!File.Exists(@".\config.txt")) File.Create(@".\config.txt");
        }

        private void BFRandoGUI_Load(object sender, EventArgs e) { }

        //button and checkbox events

        private void Randomise_Click(object sender, EventArgs e)
        {
            //delete any previously generated seed's source
            if (Directory.Exists(@".\Randomiser_P")) Directory.Delete(@".\Randomiser_P", true);

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

            Globals.ValidExports = HelperFunctions.GetWantedExports();//Find the exports to modify

            #region enum randomising
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\Enums");
            if (Abilities.Checked)
            {
                int[] CutAbilities = { 5, 7, 10 };
                Enums.RandomiseEnum(@".\Baseassets\Enums\Abilities.uasset", CutAbilities);
            }
            /*if (Items.Checked)
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
            if (Weapons.Checked)
            {
                int[] UnusedWeapons = { 14 };
                Enums.RandomiseEnum(@".\Baseassets\Enums\Weapons.uasset", UnusedWeapons);
            }
            if (Emotes.Checked)
            {
                int[] UnusedEmotes = { 14, 15 };
                Enums.RandomiseEnum(@".\Baseassets\Enums\Abilities.uasset", UnusedEmotes);
            }*/
            #endregion

            #region index randomising
            #endregion

            #region location randomising
            #endregion

            #region if options were checked then package
            if (!(Spirits.Checked && Abilities.Checked && Weapons.Checked && Tunics.Checked && Emotes.Checked && Items.Checked&&Ducks.Checked))
            {
                MessageBox.Show("You haven't checked any options!");
            }
            else
            {
                //Start the custom batch file I created
                System.Diagnostics.Process.Start(@".\Packing.bat");
                MessageBox.Show("Randomisation complete!");
                if (American.Checked) File.Move(@".\Randomiser_P.pak", @".\Randomizer_P.pak");

                //Start moving process of the .pak file to the mod folder
                string modfolder = File.ReadAllText(@".\config.txt");
                if (modfolder.Equals(""))
                {
                    File.WriteAllText(@".\config.txt", modfoldercheck.SelectedPath);
                    if (modfoldercheck.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Mod folder registered. edit config.txt to change this folder");
                    }
                }
                modfolder = File.ReadAllText(@".\config.txt");
                if (File.Exists($@"{modfolder}\Randomiser_P.pak"))
                {
                    File.Delete($@"{modfolder}\Randomiser_P.pak");
                }
                File.Move(@".\Randomiser_P.pak", $@"{modfolder}\Randomiser_P.pak");
                MessageBox.Show("Randomiser pak installed");
            }
            #endregion
        }

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
                Ducks.Text = "Randomize Ducks?";
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
                Ducks.Text = "Randomise Ducks?";
                Randomise.Text = "Randomise";
                UmbyPet.Image = UmbyPet.ErrorImage;
                Logo.BackgroundImage = Logo.InitialImage;
            }
        }
        #endregion

        #region making the checkboxes global
        private void Weapons_CheckedChanged(object sender, EventArgs e) { Globals.Weapons = Weapons.Checked ? true : false; }
        private void Abilities_CheckedChanged(object sender, EventArgs e) { Globals.Abilities = Abilities.Checked ? true : false; }
        private void Tunics_CheckedChanged(object sender, EventArgs e) { Globals.Tunics = Tunics.Checked ? true : false; }
        private void Emotes_CheckedChanged(object sender, EventArgs e) { Globals.Emotes = Emotes.Checked ? true : false; }
        private void Items_CheckedChanged(object sender, EventArgs e) { Globals.Items = Items.Checked ? true : false; }
        private void Spirit_CheckedChanged(object sender, EventArgs e) { Globals.Spirits = Spirits.Checked ? true : false; }
        private void Ducks_CheckedChanged(object sender, EventArgs e) { Globals.Ducks = Ducks.Checked ? true : false; }
        #endregion

        #region deleting mod pak
        private void deletePak_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"{File.ReadAllText(@".\config.txt")}\Randomiser_P.pak"))
            {
                File.Delete($@"{File.ReadAllText(@".\config.txt")}\Randomiser_P.pak");
                MessageBox.Show("Pak file deleted");
            }
            else MessageBox.Show("There was no pak to delete");
        }
        #endregion
    }
}
