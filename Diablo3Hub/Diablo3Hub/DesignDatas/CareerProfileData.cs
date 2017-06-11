using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3Hub.Models;

namespace Diablo3Hub.DesignDatas
{
    class CareerProfileData
    {
        /// <summary>
        /// 디자인 타임용 케리어 프로파일
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
    }
}
