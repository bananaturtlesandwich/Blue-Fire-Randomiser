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
            AssetWriter y = new AssetWriter(@".\Baseassets\Blue Fire\Content\Enums\Spirits.uasset", null, null);
            //MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Go through all data blocks
            for (int i = 0; i < y.data.categories.Count; i++)
            {
                Category category = y.data.categories[i];
                if (category is NormalCategory cat)
                {
                    //Loop through subcategories
                    for (int j = 0; j < cat.Data.Count; j++)
                    {
                        //is an enum key?
                        if (cat.Data[j].Name == "Key(0)" && cat.Data[j] is StructPropertyData bob)
                        {
                            //get the name
                            int temp = 0;
                            bool valid = false;
                            string[] PossibleIndexes = new string[30];
                            string[] UsedIndexes = new string[30];
                            var index = bob.Value as NamePropertyData;
                            for (int k = 0; k < PossibleIndexes.Length; k++)
                            {
                                PossibleIndexes[k] = Convert.ToString(k);
                            }
                            while (valid == false)
                            {
                                valid = false;
                                temp = rndm.Next(0, 8);
                                if (UsedIndexes.Contains(PossibleIndexes[temp]))
                                {
                                    continue;
                                }
                                else
                                {
                                    valid = true;
                                }
                            }
                            index.Value = $"NewEnumerator{PossibleIndexes[temp]}(0)";
                            UsedIndexes[j] = PossibleIndexes[temp];
                        }
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
                MessageBox.Show("Randomisation complete! You'll find the pak file in the root directory");
            }

        }

        private void RandoOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            randomiseSpirits = true;
            nothingSelected = false;
        }
    }
}
