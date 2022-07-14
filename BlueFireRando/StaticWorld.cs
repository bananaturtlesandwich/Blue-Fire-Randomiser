namespace BlueFireRando;
public static class StaticWorld
{
    public enum Areas
    {
        //The values can be compared to determine whether one area requires another to enter
        Intro = 0,
        VoidRoom = 1,
        ArcaneTunnels = 2,
        Crossroads = 3,
        Stoneheart = 4,
        TempleGardens = 5,
        APStart = 5,
        ForestShrine = 5,
        UthasTemple = 6,
        APTower = 7,
        Firefall = 7,
        Waterways = 8,
        Steamhouse = 8,
        Beira = 8
    }

    static List<Check> checks = new()
    {
        new("Chest_A01_Keep_Shield", Areas.Intro),
        new("Chest_A02_Keep_Key_01", Areas.Intro),
        new("Chest_A01_TempleGardens_Ability_SpinAttack2", Areas.Intro),
        new("Chest_A02_Keep_Loot_02", Areas.Intro),
        new("A01_FireKeep_EmoteStatue_Levitation", Areas.Intro)
    };

    public struct Check
    {
        public Check(string Name, Areas Area) { name = Name; area = Area; }
        public string name;
        public Areas area;
        public object[] RequiredThings = Array.Empty<object>();
    }
}