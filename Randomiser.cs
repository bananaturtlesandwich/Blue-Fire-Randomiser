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
            if (Directory.Exists(@".\Randomiser_P\Blue Fire\Content\Enums") == false)
            {
                Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\Enums");
                Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu");
                if (American.Checked)
                {
                    File.Move(@".\Baseassets\USLogo.uasset", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
                    File.Move(@".\Baseassets\USLogo.uexp", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
                }
                else
                {
                    File.Move(@".\Baseassets\NormalLogo.uasset", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uasset");
                    File.Move(@".\Baseassets\NormalLogo.uexp", @".\Randomiser_P\Blue Fire\Content\BlueFire\HUD\Menu\Blue-Fire-Logo.uexp");
                }
            }
            if (File.Exists(@".\config.txt") == false)
            {
                File.Create(@".\config.txt");
            }
            if (Spirits.Checked)
            {
                Enums.RandomiseSpirits();
            }
            if (Spirits.Checked==false)
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
                        MessageBox.Show($"Randomiser pak installed");
                    }
                }
                modfolder = File.ReadAllText(@".\config.txt");
                if (File.Exists($"{modfolder}\\Randomiser_P.pak"))
                {
                    File.Delete($"{modfolder}\\Randomiser_P.pak");
                }
                File.Move(@".\Randomiser_P.pak", $"{modfolder}\\Randomiser_P.pak");
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
                KeyItems.Text = "Randomize Key Items?*";
                Keys.Text = "Randomize Keys?*";
                Items.Text = "Randomize Items?*";
                Spirits.Text = "Randomize Spirits?";
                Randomise.Text = "Randomize";
                Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them it will have no effect. Mix randomization means key items can be in weapon locations etc.";
                UmbyPet.Image = UmbyPet.InitialImage;
                Logo.BackgroundImage = Logo.ErrorImage;
            }
            else
            {
                Mix.Text = "Mix Randomisation?*";
                Weapons.Text = "Randomise Weapons?*";
                KeyItems.Text = "Randomise Key Items?*";
                Keys.Text = "Randomise Keys?*";
                Items.Text = "Randomise Items?*";
                Spirits.Text = "Randomise Spirits?";
                Randomise.Text = "Randomise";
                Disclaimer.Text = "Items marked with a * are features yet to be implemented and if you do tick them it will have no effect. Mix randomisation means key items can be in weapon locations etc.";
                UmbyPet.Image = UmbyPet.ErrorImage;
                Logo.BackgroundImage = Logo.InitialImage;
            }
        }
    }
}
