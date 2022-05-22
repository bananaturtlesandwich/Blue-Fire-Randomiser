namespace BlueFireRando;

partial class Randomiser
{
    readonly string[] FirstDoor = new string[]
    {
        "Chest_A01_TempleGardens_Ability_SpinAttack2",
        "Chest_A02_Keep_Loot_02",
        "Chest_A01_Keep_Shield",
        "Chest_A02_Keep_Key_01",
        "A01_FireKeep_EmoteStatue_Levitation"
    };

    void Randomise()
    {
        var rndm = new Random();
    }

    List<string> FilterChecks()
    {
        List<string> checks = new List<string>();
        foreach (string Mapfile in Directory.GetFiles(@".\Baseassets\World", "*.umap", SearchOption.AllDirectories))
        {
            UAsset Map = new UAsset(Mapfile, UE4Version.VER_UE4_25);
            foreach (NormalExport export in Map.Exports)
                switch (export.GetExportClassType().Value.Value)
                {
                    case "Chest_Master_C":
                    case "Chest_Dance_C":
                    case "Chest_Master_Child_C":
                        foreach (var property in export.Data)
                        {
                            if (property.Name.Value.Value == "Type")
                                switch (Convert.ToInt16(((BytePropertyData)property).EnumValue.Value.Value[13..]))
                                {
                                    case (short)InventoryItemType.Ability:
                                        if (Abilities.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                    case (short)InventoryItemType.Item:
                                        if (Items.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                    case (short)InventoryItemType.Tunic:
                                        if (Tunics.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                    case (short)InventoryItemType.Weapon:
                                        if (Weapons.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                    case (short)InventoryItemType.Emote:
                                        if (Emotes.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                    case (short)InventoryItemType.Spirit:
                                        if (Spirits.Checked) checks.Add(export.ObjectName.Value.Value);
                                        break;
                                }
                        }
                        break;
                    case "EmoteStatue_BP_C":
                        if (Emotes.Checked) checks.Add(export.ObjectName.Value.Value);
                        break;
                    case "Spirit_C":
                        if (Spirits.Checked) checks.Add(export.ObjectName.Value.Value);
                        break;
                    case "Pickup_C":
                        foreach (var property in export.Data) if (property.Name == FName.FromString("Type"))
                                if (Items.Checked) checks.Add(export.ObjectName.Value.Value);
                        break;
                }
        }
        return checks;
    }

    enum E_Abilities
    {
        DoubleJump = 1,
        Dash = 2,
        Attack = 3,
        DownSmash = 4,
        WallRun = 9,
        Grind = 10,
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
}
