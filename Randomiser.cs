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
            if (!File.Exists(@".\config.txt"))
            {
                File.Create(@".\config.txt");
            }
        }

        private void BFRandoGUI_Load(object sender, EventArgs e)
        {

        }

        private void Randomise_Click(object sender, EventArgs e)
        {

            //delete any previously generated seed's source
            if (Directory.Exists(@".\Randomiser_P"))
            {
                Directory.Delete(@".\Randomiser_P", true);
            }

            //custom menu art
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


            /*Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A01_StoneHeartCity");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\A06_IronCaves");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\02_Void04_V2");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\03_VoidEasy");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\15_VoidFlauta");
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Maps\World\Voids\17_VoidSanti");
            string[] fileentries = Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories);
            foreach (var file in fileentries)
            {
                string endpath = @".\Randomiser_P\Blue Fire\Content\BlueFire\Maps" + file.Replace(@".\Baseassets", "");
                Transformtest.RandTransform(file, endpath);
            }*/


            //If no options then tell the user they're a fucking dummy
            if (!Spirits.Checked && !KeyItems.Checked && !Weapons.Checked && !Tunics.Checked && !Emotes.Checked && !Items.Checked)
            {
                MessageBox.Show("You haven't checked any options!");
            }
            else
            {
                //Start the custom batch file I create
                System.Diagnostics.Process.Start(@".\Packing.bat");
                MessageBox.Show("Randomisation complete!");

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
        }

        private void American_CheckedChanged(object sender, EventArgs e)
        {
            if (American.Checked)
            {
                Weapons.Text = "Randomize Weapons?";
                KeyItems.Text = "Randomize Items?";
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
                KeyItems.Text = "Randomise Items?";
                Spirits.Text = "Randomise Spirits?";
                Tunics.Text = "Randomise Tunics?";
                Emotes.Text = "Randomise Emotes";
                Randomise.Text = "Randomise";
                UmbyPet.Image = UmbyPet.ErrorImage;
                Logo.BackgroundImage = Logo.InitialImage;
            }
        }

        private void deletePak_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"{File.ReadAllText(@".\config.txt")}\Randomiser_P.pak"))
            {
                File.Delete($@"{File.ReadAllText(@".\config.txt")}\Randomiser_P.pak");
                MessageBox.Show("Pak file deleted");
            }
            else
            {
                //hehe dummy
                MessageBox.Show("There was no pak to delete");
            }
        }
    }
}
