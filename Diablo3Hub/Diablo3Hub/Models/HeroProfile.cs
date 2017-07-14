using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.Models
{
    public class HeroProfile
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

        [JsonProperty(PropertyName = "seasonCreated")]
        public int SeasonCreated { get; set; }

        [JsonProperty(PropertyName = "skills")]
        public Skills Skills { get; set; }

        [JsonProperty(PropertyName = "items")]
        public Items Items { get; set; }

        [JsonProperty(PropertyName = "followers")]
        public Followers Followers { get; set; }

        [JsonProperty(PropertyName = "legendaryPowers")]
        public Legendarypower[] LegendaryPowers { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public Stats Stats { get; set; }

        [JsonProperty(PropertyName = "progression")]
        public ProgressionHero Progression { get; set; }

        [JsonProperty(PropertyName = "dead")]
        public bool Dead { get; set; }

        [JsonProperty(PropertyName = "lastupdated")]
        public long Lastupdated { get; set; }
    }

    public class Skills
    {
        [JsonProperty(PropertyName = "active")]
        public Active[] Active { get; set; }

        [JsonProperty(PropertyName = "passive")]
        public Passive[] Passive { get; set; }
    }

    public class Active
    {
        [JsonProperty(PropertyName = "skill")]
        public Skill Skill { get; set; }

        [JsonProperty(PropertyName = "rune")]
        public Rune Rune { get; set; }
    }

    public class Skill
    {
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "categorySlug")]
        public string CategorySlug { get; set; }

        [JsonProperty(PropertyName = "tooltipUrl")]
        public string TooltipUrl { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "simpleDescription")]
        public string SimpleDescription { get; set; }

        [JsonProperty(PropertyName = "skillCalcId")]
        public string SkillCalcId { get; set; }

        [JsonProperty(PropertyName = "flavor")]
        public string Flavor { get; set; }
    }

    public class Rune
    {
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "simpleDescription")]
        public string SimpleDescription { get; set; }

        [JsonProperty(PropertyName = "tooltipParams")]
        public string TooltipParams { get; set; }

        [JsonProperty(PropertyName = "skillCalcId")]
        public string SkillCalcId { get; set; }

        [JsonProperty(PropertyName = "order")]
        public int Order { get; set; }
    }

    public class Passive
    {
        [JsonProperty(PropertyName = "skill")]
        public Skill Skill { get; set; }
    }


    public class Items
    {
        public IList<Equipment> Equipments => new List<Equipment>
        {
            MainHand,
            OffHand,
            Waist,
            RightFinger,
            LeftFinger,
            Neck,
            Torso,
            Feet,
            Hands,
            Shoulders,
            Legs,
            Bracers,
            Head,
            Special
        }.Where(p => p != null).ToList();

        [JsonProperty(PropertyName = "mainHand")]
        public Equipment MainHand { get; set; }

        [JsonProperty(PropertyName = "offHand")]
        public Equipment OffHand { get; set; }

        [JsonProperty(PropertyName = "waist")]
        public Equipment Waist { get; set; }

        [JsonProperty(PropertyName = "rightFinger")]
        public Equipment RightFinger { get; set; }

        [JsonProperty(PropertyName = "leftFinger")]
        public Equipment LeftFinger { get; set; }

        [JsonProperty(PropertyName = "neck")]
        public Equipment Neck { get; set; }

        [JsonProperty(PropertyName = "torso")]
        public Equipment Torso { get; set; }

        [JsonProperty(PropertyName = "feet")]
        public Equipment Feet { get; set; }

        [JsonProperty(PropertyName = "hands")]
        public Equipment Hands { get; set; }

        [JsonProperty(PropertyName = "shoulders")]
        public Equipment Shoulders { get; set; }

        [JsonProperty(PropertyName = "legs")]
        public Equipment Legs { get; set; }

        [JsonProperty(PropertyName = "bracers")]
        public Equipment Bracers { get; set; }

        [JsonProperty(PropertyName = "head")]
        public Equipment Head { get; set; }

        [JsonProperty(PropertyName = "special")]
        public Equipment Special { get; set; }
    }

    /// <summary>
    ///     장비
    /// </summary>
    public class Equipment : BindableBase
    {
        private ItemDetail _itemDetail;

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "displayColor")]
        public string DisplayColor { get; set; }

        [JsonProperty(PropertyName = "tooltipParams")]
        public string TooltipParams { get; set; }

        [JsonProperty(PropertyName = "setItemsEquipped")]
        public string[] SetItemsEquipped { get; set; }

        /// <summary>
        ///     아이템 상세 정보
        /// </summary>
        public ItemDetail ItemDetail
        {
            get => _itemDetail;
            set => Set(ref _itemDetail, value);
        }
    }

    public class Followers
    {
        [JsonProperty(PropertyName = "enchantress")]
        public Follower Enchantress { get; set; }

        [JsonProperty(PropertyName = "templar")]
        public Follower Templar { get; set; }

        [JsonProperty(PropertyName = "scoundrel")]
        public Follower Scoundrel { get; set; }

        public IList<Follower> Items => new List<Follower>
        {
            Enchantress,
            Scoundrel,
            Templar
        }.Where(p => p != null).ToList();
    }

    public class Follower
    {
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "items")]
        public Items Items { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public Stats Stats { get; set; }

        [JsonProperty(PropertyName = "skills")]
        public Skill[] Skills { get; set; }
    }


    public class Stats
    {
        [JsonProperty(PropertyName = "experienceBonus")]
        public int ExperienceBonus { get; set; }

        [JsonProperty(PropertyName = "life")]
        public int Life { get; set; }

        [JsonProperty(PropertyName = "damage")]
        public float Damage { get; set; }

        [JsonProperty(PropertyName = "toughness")]
        public float Toughness { get; set; }

        [JsonProperty(PropertyName = "healing")]
        public float Healing { get; set; }

        [JsonProperty(PropertyName = "attackSpeed")]
        public float AttackSpeed { get; set; }

        [JsonProperty(PropertyName = "armor")]
        public int Armor { get; set; }

        [JsonProperty(PropertyName = "strength")]
        public int Strength { get; set; }

        [JsonProperty(PropertyName = "dexterity")]
        public int Dexterity { get; set; }

        [JsonProperty(PropertyName = "vitality")]
        public int Vitality { get; set; }

        [JsonProperty(PropertyName = "intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty(PropertyName = "physicalResist")]
        public int PhysicalResist { get; set; }

        [JsonProperty(PropertyName = "fireResist")]
        public int FireResist { get; set; }

        [JsonProperty(PropertyName = "coldResist")]
        public int ColdResist { get; set; }

        [JsonProperty(PropertyName = "lightningResist")]
        public int LightningResist { get; set; }

        [JsonProperty(PropertyName = "poisonResist")]
        public int PoisonResist { get; set; }

        [JsonProperty(PropertyName = "arcaneResist")]
        public int ArcaneResist { get; set; }

        [JsonProperty(PropertyName = "critDamage")]
        public float CritDamage { get; set; }

        [JsonProperty(PropertyName = "damageIncrease")]
        public float DamageIncrease { get; set; }

        [JsonProperty(PropertyName = "critChance")]
        public float CritChance { get; set; }

        [JsonProperty(PropertyName = "damageReduction")]
        public float DamageReduction { get; set; }

        [JsonProperty(PropertyName = "lifeSteal")]
        public float LifeSteal { get; set; }

        [JsonProperty(PropertyName = "lifePerKill")]
        public float LifePerKill { get; set; }

        [JsonProperty(PropertyName = "goldFind")]
        public float GoldFind { get; set; }

        [JsonProperty(PropertyName = "magicFind")]
        public float MagicFind { get; set; }

        [JsonProperty(PropertyName = "thorns")]
        public float Thorns { get; set; }

        [JsonProperty(PropertyName = "blockChance")]
        public float BlockChance { get; set; }

        [JsonProperty(PropertyName = "blockAmountMin")]
        public int BlockAmountMin { get; set; }

        [JsonProperty(PropertyName = "blockAmountMax")]
        public int BlockAmountMax { get; set; }

        [JsonProperty(PropertyName = "lifeOnHit")]
        public float LifeOnHit { get; set; }

        [JsonProperty(PropertyName = "primaryResource")]
        public int PrimaryResource { get; set; }

        [JsonProperty(PropertyName = "secondaryResource")]
        public int SecondaryResource { get; set; }
    }

    public class ProgressionHero
    {
        [JsonProperty(PropertyName = "act1")]
        public Act Act1 { get; set; }

        [JsonProperty(PropertyName = "act2")]
        public Act Act2 { get; set; }

        [JsonProperty(PropertyName = "act3")]
        public Act Act3 { get; set; }

        [JsonProperty(PropertyName = "act4")]
        public Act Act4 { get; set; }

        [JsonProperty(PropertyName = "act5")]
        public Act Act5 { get; set; }
    }

    public class Act
    {
        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }

        [JsonProperty(PropertyName = "completedQuests")]
        public object[] CompletedQuests { get; set; }
    }

    public class Legendarypower
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "displayColor")]
        public string DisplayColor { get; set; }

        [JsonProperty(PropertyName = "tooltipParams")]
        public string TooltipParams { get; set; }

        [JsonProperty(PropertyName = "setItemsEquipped")]
        public string[] SetItemsEquipped { get; set; }
    }
}