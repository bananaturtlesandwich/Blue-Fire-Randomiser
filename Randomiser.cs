using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UAssetAPI;

namespace BlueFireRando
{

    public partial class Randomiser : Form
    {
        Random rndm = new Random();
        int[] AllIndexes;
        int[] UsedIndexes;
        //TODO write out logic for these
        void RandomiseItems(string filepath)
        {
            //Load umap
            AssetWriter y = new AssetWriter(filepath, null, null);
            //Go through all data blocks
            for(int i = 0; i < y.data.categories.Count; i++)
            {
                Category category = y.data.categories[i];
                if(category is NormalCategory cat)
                {

                    //Loop through subcategories
                }
            }
            int temp=rndm.Next(0, AllIndexes.Length - 1);
            
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
            MessageBox.Show("Randomising requested content...");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
