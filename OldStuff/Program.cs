using UAssetAPI;
using UAssetAPI.PropertyTypes;

UAsset VoidRoomMap = new UAsset(@"C:\Users\afcar\UE4 modding\Raw\SpiritToAbility_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels\A02_GameIntro_FirstVoidRoom.umap", UE4Version.VER_UE4_25);
Export spirit = VoidRoomMap.Exports[205];
int enumerator;
int index;
enumerator=VoidRoomMap.AddNameReference(FString.FromString("Abilities"));
index=VoidRoomMap.AddNameReference(FString.FromString("Abilities::NewEnumerator1"));
if (spirit is NormalExport normal) if (normal.Data[9] is BytePropertyData byt)
    {
        byt.EnumType = enumerator;
        byt.Value = index;
    }
VoidRoomMap.Write(@"C:\Users\afcar\UE4 modding\Raw\SpiritToAbility_P\Blue Fire\Content\BlueFire\Maps\World\A02_ArcaneTunnels\A02_GameIntro_FirstVoidRoom.umap");
