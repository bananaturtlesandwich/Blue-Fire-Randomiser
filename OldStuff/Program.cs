using System;
using UAssetAPI;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;

static class Program
{
    static void Main()
    {
        VectorPropertyData vec=new VectorPropertyData(FName.FromString("RelativeLocation"));
        vec.Value =new FVector();
        Console.WriteLine(vec);
    }
}