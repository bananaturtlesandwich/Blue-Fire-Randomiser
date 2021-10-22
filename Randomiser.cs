using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UAssetAPI;

namespace BlueFireRando
{

    public partial class Randomiser : Form
    {
        bool randomiseSpirits = false;
        //TODO write out logic for these
        void RandomiseSpirits()
        {
            //Load umap/enum
            UAsset y = new UAsset(@".\Baseassets\Blue Fire\Content\Enums\Spirits.uasset", UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Only one export so for loop isn't needed
            Export baseUs = y.Exports[0];
            if (baseUs is EnumExport us)
            {
                Random rndm = new Random();
                int[] UsedIndexes = new int[45];
                int[] UnusedIndexes = { 3, 5, 6, 8, 16, 18, 19, 20, 22, 23, 24, 26, 29};
                for (int a = 0; a < UnusedIndexes.Length; a++)
                {
                    UsedIndexes[a] = UnusedIndexes[a];
                }
                //If anyone peeking knows a better way to do this please contact me
                //bool valid;
                List<Tuple<FName, long>> eh = us.Enum.Names;
                for (int j=0; j < 28; j++)
                {
                    if (UnusedIndexes.Contains(j) == false)
                    {
                        int temp;
                        do
                        {
                            temp = rndm.Next(0, 30);
                        }
                        while (UsedIndexes.Contains(temp));
                        eh[j] = new Tuple<FName, long>(us.Enum.Names[j].Item1, temp);
                        UsedIndexes[j+14]=temp;
                        /*string debug=" ";
                        foreach (var item in UsedIndexes)
                        {
                            debug +=Convert.ToString(item + ", ");
                        }
                        MessageBox.Show(debug);*/
                    }
                }
            }
            y.Write(@".\Randomiser_P\Blue Fire\Content\Enums\Spirits.uasset");
            MessageBox.Show("Spirits Randomised");
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
            Directory.Delete(@".\Randomiser_P",true);
            Directory.CreateDirectory(@".\Randomiser_P\Blue Fire\Content\Enums");
            if (randomiseSpirits==true)
            {
                RandomiseSpirits();
            }
            if (randomiseSpirits==false)
            {
                MessageBox.Show("You haven't checked any options!");
            }
            else
            {
                System.Diagnostics.Process.Start(@".\Packing.bat");
                MessageBox.Show("Randomisation complete! You'll find the pak file next to the application");
            }

        }

        private void Spirits_CheckedChanged(object sender, EventArgs e)
        {
            if (Spirits.Checked)
            {
                randomiseSpirits = true;
            }
            else
            {
                randomiseSpirits = false;
            }
        }
    }
}
