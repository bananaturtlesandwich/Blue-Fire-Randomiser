using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

namespace BlueFireRando
{

    public partial class Randomiser : Form
    {
        Random rndm = new Random();
        bool randomiseSpirits = false;
        bool nothingSelected = true;
        //TODO write out logic for these
        void RandomiseSpirits()
        {
            //Load umap/enum
            UAsset y = new UAsset(@".\Baseassets\Blue Fire\Content\Enums\Spirits.uasset", UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Only one export so for loop isn't needed
            Export baseUs = y.Exports[0];
            if (baseUs is NormalExport us)
            {
                var newValues = new NamePropertyData(FName.FromString("Key"));
            }
            //y.Write(@".\Randomiser_P\Blue Fire\Content\Enums\Spirits.uasset");
            //MessageBox.Show("Spirits Randomised");
        }

        public Randomiser()
        {
            InitializeComponent();
        }

        private void BFRandoGUI_Load(object sender, EventArgs e)
        {

        }

        private void Randomise_Click(object sender, EventArgs e)
        {
            if (randomiseSpirits==true)
            {
                RandomiseSpirits();
            }
            if (nothingSelected==true)
            {
                MessageBox.Show("You haven't checked any options!");
            }
            else
            {
                //System.Diagnostics.Process.Start(@".\Packing.bat");
                //MessageBox.Show("Randomisation complete! You'll find the pak file next to the application");
            }

        }

        private void Spirits_CheckedChanged(object sender, EventArgs e)
        {
            if (Spirits.Checked)
            {
                randomiseSpirits = true;
                nothingSelected = false;
            }
        }
    }
}
