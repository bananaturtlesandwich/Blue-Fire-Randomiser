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
        bool randomiseCheckpoints = false;
        //TODO write out logic for these
        void RandomiseCheckpoints()
        {
            //Load umap/enum
            AssetWriter y = new AssetWriter(@".\Base\Blue Fire\Content\Enums\CheckPoints.uasset", null, null);
            MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
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
                            int temp=0;
                            bool valid=false;
                            string[] PossibleIndexes = {"0","1","2","3","5","6","17","18","19"};
                            string[] UsedIndexes=new string[9];
                            var index = bob.Value as NamePropertyData;
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
                        }
                    }
                }
            }
            y.Write(@".\Blue Fire\Content\Enums\CheckPoints.uasset");
        }
        void RandomiseEnums(string filepath)
        {
            //Load umap/enum
            AssetWriter y = new AssetWriter(filepath, null, null);
            MessageBox.Show($"Data preserved:{(y.VerifyParsing() ? "yes" : "no")}");
            //Go through all data blocks
            for(int i = 0; i < y.data.categories.Count; i++)
            {
                Category category = y.data.categories[i];
                if(category is NormalCategory cat)
                {
                    //Loop through subcategories
                    for(int j = 0; j < cat.Data.Count; j++)
                    {

                    }
                }
            }
            //int temp=rndm.Next(0, AllIndexes.Length - 1);
            
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
            if (randomiseCheckpoints==true)
            {
                RandomiseCheckpoints();
            }
        }

        private void RandoOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            randomiseCheckpoints = true;
        }
    }
}
