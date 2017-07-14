using System.Collections.Generic;
using Diablo3Hub.Models;

namespace Diablo3Hub.DesignDatas
{
    internal class DesignData
    {
        /// <summary>
        ///     배틀테그 디자인 타임 데이터
        /// </summary>
        /// <returns></returns>
        public static IList<BattleTag> GetBattleTags()
        {
            return new List<BattleTag>
            {
                new BattleTag {Tag = "aaaaasdf#123"},
                new BattleTag {Tag = "aaaasdfa#123"},
                new BattleTag {Tag = "aaaasdfa#123"},
                new BattleTag {Tag = "aaasfdaa#123"},
                new BattleTag {Tag = "aaaasfa#123"}
            };
        }

        /// <summary>
        ///     케리어 프로파일 디자인 타임 데이터
        /// </summary>
        /// <returns></returns>
        public static CareerProfile GetCareerProfile()
        {
            return new CareerProfile
            {
                BattleTag = "SuperOwl#1417",
                LastUpdated = 1495638790,
                LastHeroPlayed = 62681397,
                ParagonLevel = 264,
                Heroes = new[]
                {
                    new Hero
                    {
                        Id = 62202694,
                        Name = "KakiBaba",
                        Class = "barbarian",
                        Gender = 0,
                        Level = 60,
                        Kills = new Kills {Elites = 9449},
                        ParagonLevel = 264,
                        Hardcore = false,
                        Seasonal = false,
                        Dead = false,
                        Lastupdated = 1490517844
                    },
                    new Hero
                    {
                        Id = 62681397,
                        Name = "카키디",
                        Class = "demon-hunter",
                        Gender = 0,
                        Level = 70,
                        Kills = new Kills {Elites = 8051},
                        ParagonLevel = 826,
                        Hardcore = false,
                        Seasonal = true,
                        Dead = false,
                        Lastupdated = 1495638790
                    }
                },
                Kills = new Kills
                {
                    Elites = 53537,
                    Monsters = 1251703
                },
                GuildName = "UWP",
                TimePlayed = new Timeplayed
                {
                    Barbarian = 0.813f,
                    Crusader = 0.778f,
                    Demonhunter = 1.0f,
                    Monk = 0.081f,
                    Witchdoctor = 0.111f,
                    Wizard = 0.65f
                },
                Progression = new Progression
                {
                    Act1 = true,
                    Act2 = true,
                    Act3 = true,
                    Act4 = true,
                    Act5 = false
                },
                Blacksmith = new StoreInfo
                {
                    Slug = "blacksmith",
                    Level = 12,
                    StepCurrent = 0,
                    StepMax = 1
                },
                Jeweler = new StoreInfo
                {
                    Slug = "jeweler",
                    Level = 12,
                    StepCurrent = 0,
                    StepMax = 1
                },
                BlacksmithHardcore = new StoreInfo
                {
                    Slug = "blacksmith",
                    Level = 0,
                    StepCurrent = 0,
                    StepMax = 1
                },
                ParagonLevelSeason = 721,
                ParagonLevelHardcore = 0,
                ParagonLevelSeasonHardcore = 0
            };
        }

        /// <summary>
        ///     히어로 디자인 타임 데이터
        /// </summary>
        /// <returns></returns>
        public static HeroProfile GetHeroProfile()
        {
            return new HeroProfile
            {
                Id = 63702937,
                Name = "KakiHardDIII",
                Class = "demon-hunter",
                Gender = 1,
                Level = 70,
                Kills = new Kills {Elites = 375},
                ParagonLevel = 165,
                Hardcore = true,
                Seasonal = true,
                SeasonCreated = 10,
                Items = new Items
                {
                    MainHand = new Equipment
                    {
                        Id = "P4_Unique_Sword_1H_01",
                        Name = "앙심의 칼",
                        Icon = "p4_unique_sword_1h_01_demonhunter_male",
                        DisplayColor = "orange",
                        TooltipParams =
                            "item/CoUBCK75q78KEgcIBBWgNMiPHVSlvI0dZiMGUB3Q7mgxHZWx9vIdyfq8oDCL0gI4nANAAFASWARgsgNqLAoMCAAQ4tHnpoKAgIAJEhwIyPCxrgoSBwgEFSotN6kwi9ICOABAAVgEkAEKgAFGpQHQ7mgxrQGeT4PctQGb2dnvuAG2w8m0BcABAhi_rb6DDlAAWAI"
                    },
                    Head = new Equipment
                    {
                        Id = "P4_Unique_Helm_103",
                        Name = "구네스의 얼굴",
                        Icon = "p4_unique_helm_103_demonhunter_male",
                        DisplayColor = "orange",
                        TooltipParams =
                            "item/Cm8It4fWnQ0SBwgEFZLsVecdf46HzB04neQEHdKfnkQdZiMGUB3J-rygMIvSAjjxAkAAUBJYBGCHA2osCgwIABDx0eemgoCAgAkSHAiSiYieCxIHCAQVi74cwjCL0gI4AEABWASQAQqAAUa1AX_5Tl0Y283QigNQAFgC"
                    }
                },
                Followers = new Followers
                {
                    Enchantress = new Follower
                    {
                        Slug = "enchantress",
                        Level = 70,
                        Items = new Items
                        {
                            MainHand = new Equipment
                            {
                                Id = "P41_Unique_Dagger_102_x1",
                                Name = "그린스톤 경의 부채",
                                Icon = "p41_unique_dagger_102_x1_demonhunter_male",
                                DisplayColor = "orange",
                                TooltipParams =
                                    "item/CkEIxLym7AkSBwgEFc4oGgAdTLTSZR2bBgDLHZ5Pg9wdO8mhYh3J-rygMIvSAjiYAkAAUBJYBGCYAoABRrUBvoJPshico9EB"
                            },
                            Special = new Equipment
                            {
                                Id = "Enchantress_Special_206",
                                Name = "신화 여행자의",
                                Icon = "enchantress_special_206_demonhunter_male",
                                DisplayColor = "yellow",
                                TooltipParams =
                                    "item/CkMI2cHCKxIHCAQVNaNiLR3A3IcbHZoGAMsd8nAHrR1pSWnqHU8ZrAwd6XAvuyILCAEVckIDABgiICIwjdICOABAAFAQGOqMldYF"
                            }
                        },
                        Stats = new Stats
                        {
                            ExperienceBonus = 22,
                            GoldFind = 6,
                            MagicFind = 0
                        },
                        Skills = new[]
                        {
                            new Skill
                            {
                                Slug = "charm",
                                Name = "매혹",
                                Icon = "enchantress_charm",
                                Level = 15,
                                TooltipUrl = "skill/enchantress/charm",
                                Description = "재사용 대기시간: 18초\r\n\r\n적을 매혹시켜 8초 동안 플레이어를 위해 싸우게 합니다.",
                                SimpleDescription = "재사용 대기시간: 18초\r\n\r\n일시적으로 적을 매혹시켜 영웅을 위해 싸우게 합니다.",
                                SkillCalcId = "a"
                            }
                        }
                    }
                },
                LegendaryPowers = new[]
                {
                    new Legendarypower
                    {
                        Id = "Unique_HandXBow_002_x1",
                        Name = "다네타의 보복",
                        Icon = "unique_handxbow_002_x1_demonhunter_male",
                        DisplayColor = "green",
                        TooltipParams = "item/danettas-revenge",
                        SetItemsEquipped = new[]
                        {
                            "Unique_HandXBow_002_x1"
                        }
                    },
                    new Legendarypower
                    {
                        Id = "Unique_Helm_002_p3",
                        Name = "레오릭의 왕관",
                        Icon = "unique_helm_002_p3_demonhunter_male",
                        DisplayColor = "orange",
                        TooltipParams = "item/leorics-crown-mCg1x"
                    },
                    null
                },
                Stats = new Stats
                {
                    Life = 468068,
                    Damage = 424233.0f,
                    Toughness = 9481220.0f,
                    Healing = 874273.0f,
                    AttackSpeed = 1.399999976158142f,
                    Armor = 13868,
                    Strength = 77,
                    Dexterity = 7415,
                    Vitality = 4067,
                    Intelligence = 77,
                    PhysicalResist = 747,
                    FireResist = 747,
                    ColdResist = 747,
                    LightningResist = 1197,
                    PoisonResist = 904,
                    ArcaneResist = 902,
                    CritDamage = 4.02f,
                    DamageIncrease = 0.0f,
                    CritChance = 0.29000000075000004f,
                    DamageReduction = 0.0f,
                    LifeSteal = 0.0f,
                    LifePerKill = 7683.0f,
                    GoldFind = 1.67f,
                    MagicFind = 0.0f,
                    Thorns = 0.0f,
                    BlockChance = 0.0f,
                    BlockAmountMin = 0,
                    BlockAmountMax = 0,
                    LifeOnHit = 17369.0f,
                    PrimaryResource = 125,
                    SecondaryResource = 42
                },
                Progression = new ProgressionHero
                {
                    Act1 = new Act
                    {
                        Completed = false
                    },
                    Act2 = new Act
                    {
                        Completed = false
                    },
                    Act3 = new Act
                    {
                        Completed = false
                    },
                    Act4 = new Act
                    {
                        Completed = false
                    },
                    Act5 = new Act
                    {
                        Completed = false
                    }
                },
                Dead = false,
                Lastupdated = 1496265207
            };
        }

        /// <summary>
        ///     아이템 디자인 타임 데이터
        /// </summary>
        /// <returns></returns>
        public static ItemDetail GetItemDetail(int index)
        {
            var items = new List<ItemDetail>
            {
                new ItemDetail
                {
                    Id = "Unique_Dagger_101_x1",
                    Name = "카를레이의 주장",
                    Icon = "unique_dagger_101_x1_demonhunter_male",
                    DisplayColor = "orange",
                    RequiredLevel = 70,
                    ItemLevel = 70,
                    StackSizeMax = 0,
                    BonusAffixes = 0,
                    BonusAffixesMax = 0,
                    AccountBound = true,
                    FlavorText = "악마사냥꾼 카를레이와 말다툼을 하는 사람은, 그녀가 기가 막힐 만큼 주장을 확실히 관철시키는 사람이라는 사실을 곧바로 깨닫기 마련이었습니다.",
                    TypeName = "고대 전설 단도",
                    Type = new Type
                    {
                        Id = "Dagger",
                        TwoHanded = false
                    },
                    DamageRange = "무기 공격력 1432~2004",
                    Dps = new MinMax
                    {
                        Min = 2757.8073000000004f,
                        Max = 2757.8073000000004f
                    },
                    AttacksPerSecond = new MinMax
                    {
                        Min = 1.605f,
                        Max = 1.605f
                    },
                    AttacksPerSecondText = "초당 공격 횟수 1.61",
                    MinDamage = new MinMax
                    {
                        Min = 113.42f,
                        Max = 113.42f
                    },
                    MaxDamage = new MinMax
                    {
                        Min = 340.26f,
                        Max = 340.26f
                    },
                    ElementalType = "cold",
                    Augmentation = "민첩 +370 (칼데산의 절망 74등급)",
                    Attributes = new Attributes
                    {
                        Primary = new[]
                        {
                            new Attribute
                            {
                                Color = "blue",
                                Text = "냉기 무기 공격력 +1244~1570",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "피해 +6%",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "민첩 +887",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "공격 속도 7% 증가",
                                AffixType = "enchant"
                            }
                        },
                        Secondary = new[]
                        {
                            new Attribute
                            {
                                Color = "blue",
                                Text = "적을 처치하고 얻는 경험치 +248",
                                AffixType = "utility"
                            }
                        },
                        Passive = new[]
                        {
                            new Attribute
                            {
                                Color = "blue",
                                Text = "이미 투검이 적중한 적에게 투검이 적중하면 15의 증오가 반환됨",
                                AffixType = "default"
                            }
                        }
                    },
                    AttributesRaw = new Attributesraw
                    {
                        Post212Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        DamageWeaponPercentAll = new MinMax
                        {
                            Min = 0.06f,
                            Max = 0.06f
                        },
                        DamageWeaponMinPhysical = new MinMax
                        {
                            Min = 107.0f,
                            Max = 107.0f
                        },
                        Post250Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        ItemLegendaryItemBaseItem = new MinMax
                        {
                            Min = -1.303412034E9f,
                            Max = -1.303412034E9f
                        },
                        CubeEnchantedGemRank = new MinMax
                        {
                            Min = 74.0f,
                            Max = 74.0f
                        },
                        DexterityItem = new MinMax
                        {
                            Min = 887.0f,
                            Max = 887.0f
                        },
                        DurabilityMax = new MinMax
                        {
                            Min = 369.0f,
                            Max = 369.0f
                        },
                        ExperienceBonus = new MinMax
                        {
                            Min = 248.0f,
                            Max = 248.0f
                        },
                        DamageWeaponDeltaCold = new MinMax
                        {
                            Min = 326.0f,
                            Max = 326.0f
                        },
                        AncientRank = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        AttacksPerSecondItem = new MinMax
                        {
                            Min = 1.5f,
                            Max = 1.5f
                        },
                        ItemPowerPassiveP4ItemPassiveUniqueRing008 = new MinMax
                        {
                            Min = 15.0f,
                            Max = 15.0f
                        },
                        DurabilityCur = new MinMax
                        {
                            Min = 364.0f,
                            Max = 364.0f
                        },
                        Sockets = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        DamageWeaponDeltaPhysical = new MinMax
                        {
                            Min = 214.0f,
                            Max = 214.0f
                        },
                        Season = new MinMax
                        {
                            Min = 0.0f,
                            Max = 0.0f
                        },
                        ItemLegendaryItemLevelOverride = new MinMax
                        {
                            Min = 70.0f,
                            Max = 70.0f
                        },
                        Loot20Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        CubeEnchantedGemType = new MinMax
                        {
                            Min = 2.0f,
                            Max = 2.0f
                        },
                        DamageWeaponMinCold = new MinMax
                        {
                            Min = 1244.0f,
                            Max = 1244.0f
                        },
                        ConsumableAddSockets = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        ItemBindingLevelOverride = new MinMax
                        {
                            Min = 2.0f,
                            Max = 2.0f
                        },
                        AttacksPerSecondItemPercent = new MinMax
                        {
                            Min = 0.07f,
                            Max = 0.07f
                        }
                    },
                    Gems = new[]
                    {
                        new Gem
                        {
                            Item = new Item
                            {
                                Id = "x1_Emerald_10",
                                Name = "온전한 왕실 에메랄드",
                                Icon = "x1_emerald_10_demonhunter_male",
                                DisplayColor = "blue",
                                TooltipParams = "item/ChwIyv_2pA8SBwgEFUItN6kwj9ICOABAAVgEkAEKGPvKxuwK"
                            },
                            IsGem = true,
                            IsJewel = false,
                            Attributes = new Attributes
                            {
                                Primary = new[]
                                {
                                    new Attribute
                                    {
                                        Color = "blue",
                                        Text = "극대화 피해 130.0% 증가",
                                        AffixType = "default"
                                    }
                                }
                            },
                            AttributesRaw = new Attributesraw
                            {
                                CritDamagePercent = new MinMax
                                {
                                    Min = 1.3f,
                                    Max = 1.3f
                                }
                            }
                        }
                    },
                    SeasonRequiredToDrop = -1,
                    IsSeasonRequiredToDrop = false,
                    BlockChance = "방패막기 확률 +0.0%"
                },
                new ItemDetail
                {
                    Id = "Unique_Helm_Set_14_x1",
                    Name = "어둠의 가면",
                    Icon = "unique_helm_set_14_x1_demonhunter_male",
                    DisplayColor = "green",
                    RequiredLevel = 70,
                    ItemLevel = 70,
                    StackSizeMax = 0,
                    BonusAffixes = 0,
                    BonusAffixesMax = 0,
                    AccountBound = true,
                    FlavorText = "\"어둠은 그대의 동료이자 적의 악몽이다.\" - 악마사냥꾼 쿠나이",
                    TypeName = "세트 투구",
                    Type = new Type
                    {
                        Id = "Helm",
                        TwoHanded = false
                    },
                    DamageRange = "무기 공격력 0~0",
                    Armor = new MinMax
                    {
                        Min = 736.0f,
                        Max = 736.0f
                    },
                    Attributes = new Attributes
                    {
                        Primary = new[]
                        {
                            new Attribute
                            {
                                Color = "blue",
                                Text = "민첩 +717",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "활력 +719",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "극대화 확률 6.0% 증가",
                                AffixType = "enchant"
                            }
                        },
                        Secondary = new[]
                        {
                            new Attribute
                            {
                                Color = "blue",
                                Text = "물리 저항 +151",
                                AffixType = "default"
                            },
                            new Attribute
                            {
                                Color = "blue",
                                Text = "가시 피해 +2739",
                                AffixType = "utility"
                            }
                        }
                    },
                    AttributesRaw = new Attributesraw
                    {
                        Post212Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        Post250Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        VitalityItem = new MinMax
                        {
                            Min = 719.0f,
                            Max = 719.0f
                        },
                        ItemLegendaryItemBaseItem = new MinMax
                        {
                            Min = 1.565456767E9f,
                            Max = 1.565456767E9f
                        },
                        ResistancePhysical = new MinMax
                        {
                            Min = 151.0f,
                            Max = 151.0f
                        },
                        CritPercentBonusCapped = new MinMax
                        {
                            Min = 0.06f,
                            Max = 0.06f
                        },
                        DurabilityCur = new MinMax
                        {
                            Min = 307.0f,
                            Max = 307.0f
                        },
                        Sockets = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        ItemLegendaryItemLevelOverride = new MinMax
                        {
                            Min = 70.0f,
                            Max = 70.0f
                        },
                        DexterityItem = new MinMax
                        {
                            Min = 717.0f,
                            Max = 717.0f
                        },
                        DurabilityMax = new MinMax
                        {
                            Min = 312.0f,
                            Max = 312.0f
                        },
                        Loot20Drop = new MinMax
                        {
                            Min = 1.0f,
                            Max = 1.0f
                        },
                        ItemBindingLevelOverride = new MinMax
                        {
                            Min = 2.0f,
                            Max = 2.0f
                        },
                        ArmorItem = new MinMax
                        {
                            Min = 736.0f,
                            Max = 736.0f
                        },
                        ThornsFixedPhysical = new MinMax
                        {
                            Min = 2739.0f,
                            Max = 2739.0f
                        }
                    },
                    Gems = new[]
                    {
                        new Gem
                        {
                            Item = new Item
                            {
                                Id = "x1_Diamond_10",
                                Name = "온전한 왕실 다이아몬드",
                                Icon = "x1_diamond_10_demonhunter_male",
                                DisplayColor = "blue",
                                TooltipParams = "item/ChwInKee3AoSBwgEFaS-HMIwi9ICOABAAVgEkAEKGLeFmt4H"
                            },
                            IsGem = true,
                            IsJewel = false,
                            Attributes = new Attributes
                            {
                                Primary = new[]
                                {
                                    new Attribute
                                    {
                                        Color = "blue",
                                        Text = "모든 기술의 재사용 대기시간 12.5% 감소",
                                        AffixType = "utility"
                                    }
                                }
                            },
                            AttributesRaw = new Attributesraw
                            {
                                PowerCooldownReductionPercentAlll = new MinMax
                                {
                                    Min = 0.125f,
                                    Max = 0.125f
                                }
                            }
                        }
                    },
                    Set = new SetItem
                    {
                        Items = new[]
                        {
                            new Item
                            {
                                Id = "Unique_Helm_Set_14_x1",
                                Name = "어둠의 가면",
                                Icon = "unique_helm_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-mask"
                            },
                            new Item
                            {
                                Id = "Unique_Pants_Set_14_x1",
                                Name = "어둠의 똬리 바지",
                                Icon = "unique_pants_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-coil"
                            },
                            new Item
                            {
                                Id = "Unique_Boots_Set_14_x1",
                                Name = "어둠의 뾰족구두",
                                Icon = "unique_boots_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-heels"
                            },
                            new Item
                            {
                                Id = "Unique_Gloves_Set_14_x1",
                                Name = "어둠의 손아귀",
                                Icon = "unique_gloves_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-grasp"
                            },
                            new Item
                            {
                                Id = "Unique_Shoulder_Set_14_x1",
                                Name = "어둠의 짐",
                                Icon = "unique_shoulder_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-burden"
                            },
                            new Item
                            {
                                Id = "Unique_Chest_Set_14_x1",
                                Name = "어둠의 파멸",
                                Icon = "unique_chest_set_14_x1_demonhunter_male",
                                DisplayColor = "green",
                                TooltipParams = "item/the-shadows-bane"
                            }
                        },
                        Name = "어둠의 어깨걸이",
                        Ranks = new[]
                        {
                            new Rank
                            {
                                Required = 2,
                                Attributes = new Attributes
                                {
                                    Passive = new[]
                                    {
                                        new Attribute
                                        {
                                            Color = "orange",
                                            Text = "근접 무기와 함께 장비한 동안 공격력 1200% 증가",
                                            AffixType = "default"
                                        }
                                    }
                                },
                                Attributesraw = new Attributesraw
                                {
                                    ItemPowerPassiveItemPassiveUniqueRing524X1 = new MinMax
                                    {
                                        Min = 12.0f,
                                        Max = 12.0f
                                    }
                                }
                            },
                            new Rank
                            {
                                Required = 4,
                                Attributes = new Attributes
                                {
                                    Passive = new[]
                                    {
                                        new Attribute
                                        {
                                            Color = "orange",
                                            Text = "어둠의 힘이 모든 룬의 효과를 발휘하고 계속 지속됨",
                                            AffixType = "default"
                                        }
                                    }
                                },
                                Attributesraw = new Attributesraw
                                {
                                    ItemPowerPassiveItemPassiveUniqueRing524X1 = new MinMax
                                    {
                                        Min = 12.0f,
                                        Max = 12.0f
                                    }
                                }
                            },
                            new Rank
                            {
                                Required = 6,
                                Attributes = new Attributes
                                {
                                    Passive = new[]
                                    {
                                        new Attribute
                                        {
                                            Color = "orange",
                                            Text = "투검이 처음으로 적중한 적에게 무기 공격력의  40000%만큼 추가 피해를 줌",
                                            AffixType = "default"
                                        }
                                    }
                                },
                                Attributesraw = new Attributesraw
                                {
                                    ItemPowerPassiveP4ItemPassiveUniqueRing002 = new MinMax
                                    {
                                        Min = 12.0f,
                                        Max = 12.0f
                                    }
                                }
                            }
                        },
                        Slug = "the-shadows-mantle"
                    },
                    SetItemsEquipped = new object[]
                    {
                        "Unique_Helm_Set_14_x1",
                        "Unique_Pants_Set_14_x1",
                        "Unique_Boots_Set_14_x1",
                        "Unique_Gloves_Set_14_x1",
                        "Unique_Shoulder_Set_14_x1",
                        "Unique_Chest_Set_14_x1",
                    },
                    SeasonRequiredToDrop = -1,
                    IsSeasonRequiredToDrop = false,
                    BlockChance = "방패막기 확률 +0.0%"
                }
            };
            return items[index];
        }
    }
}