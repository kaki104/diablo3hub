using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3Hub.Models;

namespace Diablo3Hub.DesignDatas
{
    class HeroProfileData
    {
        public static HeroProfile GetHeroProfile()
        {
            return new HeroProfile
            {
                Id = 63702937,
                Name = "KakiHardDIII",
                Class = "demon-hunter",
                Gender = 1,
                Level = 70,
                Kills = {Elites = 373},
                ParagonLevel = 165,
                Hardcore = true,
                Seasonal = true,
                SeasonCreated = 10,
                Skills = new Skills
                {
                    Active = new []
                    {
                        new Active
                        {
                            Skill = new Skill
                            {
                                Slug = "grenade",
                                Name = "수류탄",
                                Icon = "demonhunter_grenades",
                                Level = 15,
                                CategorySlug = "primary",
                                TooltipUrl = "skill/demon-hunter/grenade",
                                Description = "생성: 증오 4\r\n\r\n통통 튀는 수류탄을 던집니다. 수류탄은 폭발하여 무기 공격력의 160%만큼 화염 피해를 줍니다.",
                                SimpleDescription = "생성: 증오 4\r\n\r\n통통 튀다 폭발하는 수류탄을 던집니다.",
                                SkillCalcId = "g"
                            },
                            Rune = new Rune
                            {
                                Slug = "grenade-c",
                                Type = "c",
                                Name = "상비 수류탄",
                                Level = 40,
                                Description = "수류탄을 3개 던집니다. 수류탄은 폭발하면서 각각 무기 공격력의 160%만큼 화염 피해를 줍니다.",
                                SimpleDescription = "수류탄을 2개 더 던집니다.",
                                TooltipParams = "rune/grenade/c",
                                SkillCalcId = "b",
                                Order = 2
                            }
                        }
                    },
                    Passive = new []
                    {
                        new Passive
                        {
                            Skill = new Skill
                            {
                                Slug = "awareness",
                                Name = "기민함",
                                Icon = "x1_demonhunter_passive_awareness",
                                Level = 66,
                                TooltipUrl = "skill/demon-hunter/awareness",
                                Description = "죽음에 달하는 피해를 받으면, 2초 동안 모습을 감추고 최대 생명력의 50%만큼 생명력을 회복합니다.\r\n\r\n이 효과는 60초에 한 번만 발동됩니다.",
                                Flavor = "\"모든 것은 시험이다. 주변을 잘 파악하는 것만으로도 합격은 문제 없다. \" - 사냥의 대가 조센",
                                SkillCalcId = "R"
                            }
                        }, 
                    }
                },
                Items = new Items
                {
                    MainHand = new Equipment
                    {
                        Id = "P4_Unique_Sword_1H_01",
                        Name = "앙심의 칼",
                        Icon = "p4_unique_sword_1h_01_demonhunter_male",
                        DisplayColor = "orange",
                        TooltipParams = "item/CoUBCK75q78KEgcIBBWgNMiPHVSlvI0dZiMGUB3Q7mgxHZWx9vIdyfq8oDCL0gI4nANAAFASWARgsgNqLAoMCAAQ4tHnpoKAgIAJEhwIyPCxrgoSBwgEFSotN6kwi9ICOABAAVgEkAEKgAFGpQHQ7mgxrQGeT4PctQGb2dnvuAG2w8m0BcABAhi_rb6DDlAAWAI"
                    },
                    Head = new Equipment
                    {
                        Id = "P4_Unique_Helm_103",
                        Name = "구네스의 얼굴",
                        Icon = "p4_unique_helm_103_demonhunter_male",
                        DisplayColor = "orange",
                        TooltipParams = "item/Cm8It4fWnQ0SBwgEFZLsVecdf46HzB04neQEHdKfnkQdZiMGUB3J-rygMIvSAjjxAkAAUBJYBGCHA2osCgwIABDx0eemgoCAgAkSHAiSiYieCxIHCAQVi74cwjCL0gI4AEABWASQAQqAAUa1AX_5Tl0Y283QigNQAFgC"
                    }
                },
                Followers = new Followers
                {
                    Enchantress = new Enchantress
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
                                TooltipParams = "item/CkEIxLym7AkSBwgEFc4oGgAdTLTSZR2bBgDLHZ5Pg9wdO8mhYh3J-rygMIvSAjiYAkAAUBJYBGCYAoABRrUBvoJPshico9EB"
                            },
                            Special = new Equipment
                            {
                                Id = "Enchantress_Special_206",
                                Name = "신화 여행자의",
                                Icon = "enchantress_special_206_demonhunter_male",
                                DisplayColor = "yellow",
                                TooltipParams = "item/CkMI2cHCKxIHCAQVNaNiLR3A3IcbHZoGAMsd8nAHrR1pSWnqHU8ZrAwd6XAvuyILCAEVckIDABgiICIwjdICOABAAFAQGOqMldYF"
                            }
                        },
                        Stats = new Stats
                        {
                            ExperienceBonus = 22,
                            GoldFind = 6,
                            MagicFind = 0
                        },
                        Skills = new []
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
                LegendaryPowers = new []
                {
                    new Legendarypower
                    {
                        Id = "Unique_HandXBow_002_x1",
                        Name = "다네타의 보복",
                        Icon = "unique_handxbow_002_x1_demonhunter_male",
                        DisplayColor = "green",
                        TooltipParams = "item/danettas-revenge",
                        SetItemsEquipped = new []
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
                    },
                },
                Dead = false,
                Lastupdated = 1496265207
            };
        }
    }
}
