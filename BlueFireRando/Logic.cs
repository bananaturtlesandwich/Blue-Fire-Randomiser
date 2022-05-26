namespace BlueFireRando;

partial class Randomiser
{
    readonly string[] FirstDoor = new string[]
    {
        "Chest_A01_TempleGardens_Ability_SpinAttack2",
        "Chest_A02_Keep_Loot_02",
        "Chest_A01_Keep_Shield",
        "Chest_A02_Keep_Key_01"
    };

    void Randomise()
    {
        var rndm = new Random();
        var checks = FilterChecks(out var items);
        Queue<string> queue = new(Helpers.Shuffle(items.Where(x => !x.Contains("Spirits"))));
        for (int i = 0; i < queue.Count(); i++) if (!items[i].Contains("Spirits")) items[i] = queue.Dequeue();
        queue = new(Helpers.Shuffle(items.Where(x => x.Contains("Spirits"))));
        for (int i = 0; i < queue.Count(); i++) if (items[i].Contains("Spirits")) items[i] = queue.Dequeue();
        //TODO: I need to add a case for codi's chest so spirit can be in a different chest
        queue = new(items);
        foreach (string Mapfile in Helpers.GetMaps())
        {
            UAsset Map = new UAsset(Mapfile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                if (checks.Contains(export))
                {
                    var value = queue.Dequeue();
                    foreach (var property in export.Data)
                        if (property.Name == FName.FromString("Type"))
                            ((BytePropertyData)property).EnumValue = FName.FromString("InventoryItemType::NewEnumerator" + StringToEnum(value));
                    Helpers.AddEnumReference(export, GetName(value), value.Split(':')[0], value);
                    if (value.Contains("Abilities") || value == "Items::NewEnumerator6" || value == "Items::NewEnumerator9" || value == "Items::NewEnumerator27" || value == "Items::NewEnumerator72" || value == "Items::NewEnumerator88" || value == "Items::NewEnumerator89" || value == "Items::NewEnumerator91" || value == "Items::NewEnumerator92")
                        export.Data.Add(new BoolPropertyData(FName.FromString("KeyItem")) { Value = true });
                }
            Map.Write(Mapfile);
        }
        UAsset Savegame = new UAsset(Helpers.GetSaveGame(), UE4Version.VER_UE4_25);
        foreach (var prop in ((NormalExport)Savegame.Exports[1]).Data)
            if (prop.Name.Value.Value.Contains("Shop"))
                foreach (StructPropertyData Stock in ((ArrayPropertyData)prop).Value)
                {
                    var value = queue.Dequeue();
                    ((BytePropertyData)Stock.Value[4]).EnumValue = FName.FromString("InventoryItemType::NewEnumerator" + StringToEnum(value));
                    foreach (var cat in Stock.Value)
                        if (cat.Name.Value.Value.Contains(GetName(value)))
                        {
                            Savegame.AddNameReference(FString.FromString(value));
                            ((BytePropertyData)cat).EnumValue = FName.FromString(value);
                        }
                }
        Savegame.Write(Savegame.FilePath);
    }

    char StringToEnum(string _enum) =>
        _enum.Split(':')[0] switch
        {
            "Items" => '0',
            "Weapons" => '1',
            "Tunics" => '2',
            "Spirits" => '3',
            "Abilities" => '6',
            "E_Emotes" => '7',
            _ => ' '
        };
    string GetName(string value) =>
        value.Split(':')[0] switch
        {
            "Items" => "Item",
            "Weapons" => "Amulet",
            "Tunics" => "Tunic",
            "Spirits" => "Spirit",
            "Abilities" => "Ability",
            "E_Emotes" => "Emote",
            _ => ""
        };

    //returns a list of checks that are affected by the pools selected and also copies files
    List<NormalExport> FilterChecks(out List<string> items)
    {
        List<NormalExport> checks = new();
        items = new();
        foreach (string Mapfile in Directory.GetFiles(@"Baseassets\World", "*.umap", SearchOption.AllDirectories))
        {
            UAsset Map = new UAsset(Mapfile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                switch (export.GetExportClassType().Value.Value)
                {
                    case "Chest_Master_C":
                    case "Chest_Dance_C":
                    case "Chest_Master_Child_C":
                        foreach (var property in export.Data)
                            switch (property.Name.Value.Value)
                            {
                                case "Item":
                                    if (Items.Checked)
                                    {
                                        checks.Add(export);
                                        items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                                    }
                                    break;
                                case "Tunic":
                                    if (Tunics.Checked)
                                    {
                                        checks.Add(export);
                                        items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                                    }
                                    break;
                                case "Weapon":
                                    if (Weapons.Checked)
                                    {
                                        checks.Add(export);
                                        items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                                    }
                                    break;
                                case "Amulet":
                                    if (Spirits.Checked)
                                    {
                                        checks.Add(export);
                                        items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                                    }
                                    break;
                            }
                        break;
                    //no need to do emote statue because they are randomised separately
                    case "Spirit_C":
                        if (Spirits.Checked)
                        {
                            checks.Add(export);
                            foreach (var property in export.Data)
                                if (property.Name == FName.FromString("Amulet"))
                                    items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                        }
                        break;
                    case "Pickup_C":
                        foreach (var property in export.Data) if (property.Name == FName.FromString("Item"))
                                if (Items.Checked)
                                {
                                    checks.Add(export);
                                    items.Add(((BytePropertyData)property).EnumValue.Value.Value);
                                }
                        break;
                }
            Map.Write(Mapfile.Replace("Baseassets", @"Randomiser_P\Blue Fire\Content\BlueFire\Maps"));
        }
        UAsset Savegame = new UAsset(@"Baseassets\BlueFireSaveGame.uasset", UE4Version.VER_UE4_25);
        foreach (var prop in ((NormalExport)Savegame.Exports[1]).Data)
            if (prop.Name.Value.Value.Contains("Shop"))
                foreach (StructPropertyData Stock in ((ArrayPropertyData)prop).Value)
                    switch (((BytePropertyData)Stock.Value[4]).EnumValue.Value.Value[^1])
                    {
                        case '0':
                            items.Add(((BytePropertyData)Stock.Value[0]).EnumValue.Value.Value);
                            break;
                        case '1':
                            items.Add(((BytePropertyData)Stock.Value[6]).EnumValue.Value.Value);
                            break;
                        case '2':
                            items.Add(((BytePropertyData)Stock.Value[5]).EnumValue.Value.Value);
                            break;
                        case '3':
                            items.Add(((BytePropertyData)Stock.Value[7]).EnumValue.Value.Value);
                            break;
                        case '6':
                            items.Add(((BytePropertyData)Stock.Value[9]).EnumValue.Value.Value);
                            break;
                    };
        Savegame.Write(@"Randomiser_P\Blue Fire\Content\BlueFire\Player\Logic\FrameWork\BlueFireSaveGame.uasset");
        return checks;
    }
}

enum InventoryItemType
{
    Item = 0,
    Weapon = 1,
    Tunic = 2,
    Spirit = 3,
    Life = 4,
    SpiritSlot = 5,
    Ability = 6,
    Emote = 7,
}
enum E_Abilities
{
    DoubleJump = 1,
    Dash = 2,
    Attack = 3,
    WallRun = 9,
    Sprint = 11,
    Spell = 13,
    Block = 14,
    SpinAttack = 15,
}
enum E_Emotes
{
    Wave = 0,
    Applause = 1,
    Levitation = 2,
    Windmill = 3,
    HatKid = 4,
    Triceps = 5,
    Aggressive = 6,
    No = 7,
    Photo = 8,
    Celebration = 9,
    KungFu = 11,
    Techno = 12,
    Party = 13,
    Hello2 = 14,
    Empty = 15,
}
enum E_Items
{
    LargePouch = 0,
    SmallPouch = 1,
    OldKey = 6,
    Book = 7,
    Rose = 9,
    Boot = 14,
    KinbankDebitCard = 15,
    IceCrystal = 17,
    SanctuaryStone = 18,
    RareKey = 19,
    PureShadowCatcher = 22,
    RubyOre = 24,
    SapphireOre = 25,
    DeadRat = 26,
    BremurPicture = 27,
    OddRock = 28,
    Souls = 29,
    SandRelic = 30,
    EmeraldOre = 31,
    ShadowFragment = 32,
    BlackFire = 33,
    AbyssPotion = 34,
    Coin = 35,
    VoidShards = 36,
    FireEssence = 39,
    ShadowPotion = 40,
    HolyBlessing = 41,
    Rice = 42,
    CarrotPotion = 44,
    Apple = 45,
    RottenApple = 46,
    Medicine = 47,
    SpiritCatcher = 49,
    HouseKey = 50,
    LifeElixir = 51,
    RoyalElixir = 52,
    BoulderPowder = 53,
    RareCheese = 54,
    SeagulSoup = 55,
    FleshEater = 56,
    ShardCluster = 57,
    ForestBug = 58,
    PoisonedPlant = 59,
    Dash = 61,
    DoubleJump = 62,
    SpinAttack = 63,
    WallRun = 64,
    FireBall = 65,
    DownSmash = 66,
    Shield = 67,
    SpiritSlot = 68,
    VoidKey = 69,
    Necklace = 70,
    KeyFireMaster = 71,
    KeyHolyMaster = 72,
    KeyIceMaster = 73,
    KeyDeathMaster = 74,
    KeyUthasTemple = 75,
    KeyGodMaster = 76,
    KeySteam = 77,
    KeyGraveyardKey = 78,
    HouseContract = 79,
    Mandoline = 80,
    RareGlasses = 81,
    RareSnow = 83,
    ComposerLetter = 84,
    Sprint = 85,
    BeiraVessel = 86,
    BeiraShards = 87,
    BasicPouch = 88,
    FireEssenceSlot = 89,
    VoidOre = 90,
    ExtraLargePouch = 91,
    Mana = 92,
    GuardianSoul = 93,
    CovenantSoul = 94,
    GuardianKey = 95,
    Duck = 96,
    RobiBadge = 97,
}
enum E_Spirits
{
    FarasGrace = 0,
    HammerKing = 1,
    HolyCentry = 2,
    RiverSpirit = 3,
    AngryAmbusher = 4,
    SecretFruit = 5,
    MindController = 6,
    FrozenSoul = 7,
    HowlingTree = 8,
    LoveFlower = 9,
    StormCentry = 10,
    BloodPhantom = 11,
    PossesedBook = 12,
    ForestGuardian = 13,
    OnopSiblings = 14,
    MoiTheDreadful = 15,
    StoneHunter = 16,
    GoldenLust = 17,
    SpringWarrior = 18,
    CandleOnop = 19,
    StoneWarrior = 20,
    ToxicRat = 21,
    SummonedGod = 22,
    SummoningHand = 23,
    BettingHand = 24,
    LifeSteal = 25,
    ShadowDemon = 26,
    ShadowGru = 27,
    FlyingOnop = 28,
    ToxicWater = 29,
}
enum E_Weapons
{
    DualBlades = 0,
    BloodstormBlades = 1,
    DiamondWings = 2,
    ShadowCasters = 3,
    EmberTwins = 4,
    IronJustice = 5,
    IceDestroyers = 6,
    PeaceKeepers = 7,
    SteelShanks = 8,
    BremurFamilySwords = 9,
    SilverBlades = 10,
    KinaDefenders = 11,
    Empty = 12,
    DLCVoidMaster = 13,
}