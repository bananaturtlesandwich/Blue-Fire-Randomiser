using UAssetAPI;
using UAssetAPI.PropertyTypes;

UAsset Map=new UAsset(@Console.ReadLine(),UE4Version.VER_UE4_25);
if (Map.Exports[246] is NormalExport norm) Console.WriteLine(norm.Data[10]);