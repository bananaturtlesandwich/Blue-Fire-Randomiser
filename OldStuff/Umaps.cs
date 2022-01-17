using UAssetAPI;
using UAssetAPI.PropertyTypes;

namespace BlueFireRando
{
    public partial class Umaps
    {
        public static void Randomise(string filepath, string endpath, bool randomisekeyitems, bool randomiseweapons, bool randomisetunics, bool randomiseemotes)
        {
            //Load umap
            //There are 75 items in chests in the game :)
            string[] Items = { "Items::NewEnumerator45", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator72", "Items::NewEnumerator72", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator31", "Items::NewEnumerator17", "Items::NewEnumerator31", "Items::NewEnumerator24", "Items::NewEnumerator26", "Items::NewEnumerator31", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator7", "Items::NewEnumerator30", "Items::NewEnumerator42", "Items::NewEnumerator55", "Items::NewEnumerator75", "Items::NewEnumerator19", "Items::NewEnumerator78", "Items::NewEnumerator27", "Items::NewEnumerator70", "Items::NewEnumerator9", "Items::NewEnumerator9", "Items::NewEnumerator24", "Items::NewEnumerator46", "Items::NewEnumerator26", "Items::NewEnumerator76", "Items::NewEnumerator6", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator6", "Items::NewEnumerator24", "Items::NewEnumerator31", "Items::NewEnumerator6", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator31", "Items::NewEnumerator72", "Items::NewEnumerator6", "Items::NewEnumerator72", "Items::NewEnumerator31", "Items::NewEnumerator6", "Items::NewEnumerator80", "Items::NewEnumerator31", "Items::NewEnumerator42", "Items::NewEnumerator14", "Items::NewEnumerator24", "Items::NewEnumerator24", "Items::NewEnumerator42", "Items::NewEnumerator54", "Items::NewEnumerator81", "Items::NewEnumerator14", "Items::NewEnumerator77", "Items::NewEnumerator77", "Items::NewEnumerator71", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90", "Items::NewEnumerator90" };
            List<int> UsedIndexes = new List<int>();
            UAsset y = new UAsset(filepath, UE4Version.VER_UE4_25);
            //MessageBox.Show($"Data preserved: {(y.VerifyBinaryEquality() ? "yes" : "no")} {filepath}");
            //Loop through exports
            //List<string> shit = new List<string>();
            for (int i = 0; i < y.Exports.Count; i++)
            {
                Export export = y.Exports[i];
                if (export is NormalExport ex)
                {
                    //loop through subcategories to find chests/spirits or items
                    for (int j = 0; j < ex.Data.Count; j++)
                    {
                        Random rndm = new Random();
                        if (ex.Data[j].Name.Equals(FName.FromString("Item")) && ex.Data[j] is BytePropertyData byt)
                        {
                            int temp;
                            do
                            {
                                temp = rndm.Next(0, Items.Length);
                            }
                            while (UsedIndexes.Contains(temp));
                            //shit.Add(y.GetNameReferenceWithoutZero(byt.Value).ToString());
                            //byt.EnumType = y.AddNameReference(FString.FromString("Items"));
                            byt.Value = y.AddNameReference(FString.FromString(Items[temp]));
                            UsedIndexes.Add(temp);
                        }
                    }
                }
            }
            y.Write(endpath);
            //I did this to log all the Items in the overworld. Set return type of the method to string to use
            /*string debug = "";
            foreach (var piceofshit in shit)
            {
                debug += ",\"" + piceofshit + "\"";
            }
            return debug;*/
        }
    }
}