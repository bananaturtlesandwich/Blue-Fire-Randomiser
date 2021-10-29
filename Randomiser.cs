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
        }

        private void BFRandoGUI_Load(object sender, EventArgs e)
        {

        }

        private void Randomise_Click(object sender, EventArgs e)
        {
            Directory.Delete(@".\Randomiser_P",true);
            //for enums obviously
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\Enums");
            //for datatables?
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\Emotes");
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
            
            if (File.Exists(@".\config.txt") == false)
            {
                File.Create(@".\config.txt");
            }
            if (Mix.Checked)
            {
                foreach (var file in Directory.GetFiles(@".\Baseassets\Maps"))
                {
                    Umaps.Randomise(file, "jjglfi", Spirits.Checked, KeyItems.Checked, false, Tunics.Checked, Emotes.Checked);
                }
            }
            else
            {
                if (Spirits.Checked)
                {
                    int[] uwu = { 5, 6, 8, 16, 18, 19, 20, 22, 23, 24, 26, 29 };
                    Enums.RandomiseEnums(@".\Baseassets\Spirits.uasset", @".\Randomiser_P\Blue Fire\Content\Enums\Spirits.uasset", 30, uwu,false);
                }
                if (KeyItems.Checked)
                {
                    int[] uwa = {5,46,47,48,49,50,52,69,70 };
                    Enums.RandomiseEnums(@".\Baseassets\Items.uasset",@".\Randomiser_P\Blue Fire\Content\Enums\Items.uasset", 82, uwa, true);
                }
            }


            if (Spirits.Checked==false&&KeyItems.Checked==false&&Weapons.Checked==false&&Tunics.Checked==false&&Emotes.Checked==false)
            {
                MessageBox.Show("You haven't checked any options!");
            }
            else
            {
                System.Diagnostics.Process.Start(@".\Packing.bat");
                MessageBox.Show("Randomisation complete!");
                string modfolder = File.ReadAllText(@".\config.txt");
                if (modfolder.Equals(""))
                {
                    File.WriteAllText(@".\config.txt",modfoldercheck.SelectedPath);
                    if (modfoldercheck.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show($"Mod folder registered. edit config.txt to change this folder");
                    }
                }
                modfolder = File.ReadAllText(@".\config.txt");
                if (File.Exists($"{modfolder}\\Randomiser_P.pak"))
                {
                    File.Delete($"{modfolder}\\Randomiser_P.pak");
                }
                File.Move(@".\Randomiser_P.pak", $"{modfolder}\\Randomiser_P.pak");
                MessageBox.Show("Randomiser pak installed");
            }
        }

        private void Spirits_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void American_CheckedChanged(object sender, EventArgs e)
        {
            if (American.Checked)
            {
                Mix.Text = "Mix Randomization?*";
                Weapons.Text = "Randomize Weapons?*";
                KeyItems.Text = "Randomize Items?*";
                Spirits.Text = "Randomize Spirits?";
                Tunics.Text = "Randomize Tunics?*";
                Emotes.Text = "Randomize Emotes";
                Randomise.Text = "Randomize";
                Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them it will have no effect. Mix randomization means key items can be in weapon locations etc.";
                UmbyPet.Image = UmbyPet.InitialImage;
                Logo.BackgroundImage = Logo.ErrorImage;
            }
            else
            {
                Mix.Text = "Mix Randomisation?*";
                Weapons.Text = "Randomise Weapons?*";
                KeyItems.Text = "Randomise Items?*";
                Spirits.Text = "Randomise Spirits?";
                Tunics.Text = "Randomise Tunics?*";
                Emotes.Text = "Randomise Emotes";
                Randomise.Text = "Randomise";
                Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them it will have no effect. Mix randomisation means key items can be in weapon locations etc.";
                UmbyPet.Image = UmbyPet.ErrorImage;
                Logo.BackgroundImage = Logo.InitialImage;
            }
        }

        private void deletePak_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{File.ReadAllText(@".\config.txt")}\\Randomiser_P.pak"))
            {
                File.Delete($"{File.ReadAllText(@".\config.txt")}\\Randomiser_P.pak");
                MessageBox.Show("Pak file deleted");
            }
            else
            {
                MessageBox.Show("There was no pak to delete");
            }
        }
    }
}
