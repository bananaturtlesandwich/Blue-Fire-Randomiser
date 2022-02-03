using System;
using System.Linq;

public static class NewRandom
{
    public static int RandInt(int MaxValue, int[] Banned)
    {
        Random rndm = new Random();
        int temp;
        do temp = rndm.Next(MaxValue); while (Banned.Contains(temp));
        return temp;
    }
}
