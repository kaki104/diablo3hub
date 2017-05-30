using Newtonsoft.Json;

namespace Diablo3Hub.Models
{
    public class CareerProfile
    {
        [JsonProperty(PropertyName = "battleTag")]
        public string BattleTag { get; set; }

        [JsonProperty(PropertyName = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [JsonProperty(PropertyName = "paragonLevelHardcore")]
        public int ParagonLevelHardcore { get; set; }

        [JsonProperty(PropertyName = "paragonLevelSeason")]
        public int ParagonLevelSeason { get; set; }

        [JsonProperty(PropertyName = "paragonLevelSeasonHardcore")]
        public int ParagonLevelSeasonHardcore { get; set; }

        [JsonProperty(PropertyName = "guildName")]
        public string GuildName { get; set; }

        [JsonProperty(PropertyName = "heroes")]
        public Hero[] Heroes { get; set; }

        [JsonProperty(PropertyName = "lastHeroPlayed")]
        public long LastHeroPlayed { get; set; }

        [JsonProperty(PropertyName = "lastUpdated")]
        public long LastUpdated { get; set; }

        [JsonProperty(PropertyName = "kills")]
        public Kills Kills { get; set; }

        [JsonProperty(PropertyName = "highestHardcoreLevel")]
        public int HighestHardcoreLevel { get; set; }

        [JsonProperty(PropertyName = "timePlayed")]
        public Timeplayed TimePlayed { get; set; }

        [JsonProperty(PropertyName = "progression")]
        public Progression Progression { get; set; }

        [JsonProperty(PropertyName = "fallenHeroes")]
        public object[] FallenHeroes { get; set; }

        [JsonProperty(PropertyName = "blacksmith")]
        public StoreInfo Blacksmith { get; set; }

        [JsonProperty(PropertyName = "jeweler")]
        public StoreInfo Jeweler { get; set; }

        [JsonProperty(PropertyName = "mystic")]
        public StoreInfo Mystic { get; set; }

        [JsonProperty(PropertyName = "blacksmithHardcore")]
        public StoreInfo BlacksmithHardcore { get; set; }

        [JsonProperty(PropertyName = "jewelerHardcore")]
        public StoreInfo JewelerHardcore { get; set; }

        [JsonProperty(PropertyName = "mysticHardcore")]
        public StoreInfo MysticHardcore { get; set; }

        [JsonProperty(PropertyName = "blacksmithSeason")]
        public StoreInfo BlacksmithSeason { get; set; }

        [JsonProperty(PropertyName = "jewelerSeason")]
        public StoreInfo JewelerSeason { get; set; }

        [JsonProperty(PropertyName = "mysticSeason")]
        public StoreInfo MysticSeason { get; set; }

        [JsonProperty(PropertyName = "blacksmithSeasonHardcore")]
        public StoreInfo BlacksmithSeasonHardcore { get; set; }

        [JsonProperty(PropertyName = "jewelerSeasonHardcore")]
        public StoreInfo JewelerSeasonHardcore { get; set; }

        [JsonProperty(PropertyName = "mysticSeasonHardcore")]
        public StoreInfo MysticSeasonHardcore { get; set; }

        [JsonProperty(PropertyName = "seasonalProfiles")]
        public Seasonalprofiles SeasonalProfiles { get; set; }
    }

    public class Kills
    {
        [JsonProperty(PropertyName = "monsters")]
        public int Monsters { get; set; }

        [JsonProperty(PropertyName = "elites")]
        public int Elites { get; set; }

        [JsonProperty(PropertyName = "hardcoreMonsters")]
        public int HardcoreMonsters { get; set; }
    }

    public class Timeplayed
    {
        [JsonProperty(PropertyName = "barbarian")]
        public float Barbarian { get; set; }

        [JsonProperty(PropertyName = "crusader")]
        public float Crusader { get; set; }

        [JsonProperty(PropertyName = "demonhunter")]
        public float Demonhunter { get; set; }

        [JsonProperty(PropertyName = "monk")]
        public float Monk { get; set; }

        [JsonProperty(PropertyName = "witchdoctor")]
        public float Witchdoctor { get; set; }

        [JsonProperty(PropertyName = "wizard")]
        public float Wizard { get; set; }
    }

    public class Progression
    {
        [JsonProperty(PropertyName = "act1")]
        public bool Act1 { get; set; }

        [JsonProperty(PropertyName = "act2")]
        public bool Act2 { get; set; }

        [JsonProperty(PropertyName = "act3")]
        public bool Act3 { get; set; }

        [JsonProperty(PropertyName = "act4")]
        public bool Act4 { get; set; }

        [JsonProperty(PropertyName = "act5")]
        public bool Act5 { get; set; }
    }

    public class StoreInfo
    {
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "stepCurrent")]
        public int StepCurrent { get; set; }

        [JsonProperty(PropertyName = "stepMax")]
        public int StepMax { get; set; }
    }


    public class Seasonalprofiles
    {
        [JsonProperty(PropertyName = "season0")]
        public Season Season0 { get; set; }

        [JsonProperty(PropertyName = "season1")]
        public Season Season1 { get; set; }

        [JsonProperty(PropertyName = "season2")]
        public Season Season2 { get; set; }

        [JsonProperty(PropertyName = "season3")]
        public Season Season3 { get; set; }

        [JsonProperty(PropertyName = "season4")]
        public Season Season4 { get; set; }

        [JsonProperty(PropertyName = "season5")]
        public Season Season5 { get; set; }

        [JsonProperty(PropertyName = "season6")]
        public Season Season6 { get; set; }

        [JsonProperty(PropertyName = "season7")]
        public Season Season7 { get; set; }

        [JsonProperty(PropertyName = "season8")]
        public Season Season8 { get; set; }

        [JsonProperty(PropertyName = "season9")]
        public Season Season9 { get; set; }

        [JsonProperty(PropertyName = "season10")]
        public Season Season10 { get; set; }
    }

    public class Season
    {
        [JsonProperty(PropertyName = "seasonId")]
        public int SeasonId { get; set; }

        [JsonProperty(PropertyName = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [JsonProperty(PropertyName = "paragonLevelHardcore")]
        public int ParagonLevelHardcore { get; set; }

        [JsonProperty(PropertyName = "kills")]
        public Kills Kills { get; set; }

        [JsonProperty(PropertyName = "timePlayed")]
        public Timeplayed TimePlayed { get; set; }

        [JsonProperty(PropertyName = "highestHardcoreLevel")]
        public int HighestHardcoreLevel { get; set; }

        [JsonProperty(PropertyName = "progression")]
        public Progression Progression { get; set; }
    }

    public class Hero
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "class")]
        public string Class { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public int Gender { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "kills")]
        public Kills Kills { get; set; }

        [JsonProperty(PropertyName = "paragonLevel")]
        public int ParagonLevel { get; set; }

        [JsonProperty(PropertyName = "hardcore")]
        public bool Hardcore { get; set; }

        [JsonProperty(PropertyName = "seasonal")]
        public bool Seasonal { get; set; }

        [JsonProperty(PropertyName = "dead")]
        public bool Dead { get; set; }

        [JsonProperty(PropertyName = "lastupdated")]
        public long Lastupdated { get; set; }
    }
}