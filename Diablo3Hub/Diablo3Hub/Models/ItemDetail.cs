using Newtonsoft.Json;

namespace Diablo3Hub.Models
{
    public class Attribute
    {
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "affixType")]
        public string AffixType { get; set; }
    }

    public class MinMax
    {
        [JsonProperty(PropertyName = "min")]
        public float Min { get; set; }

        [JsonProperty(PropertyName = "max")]
        public float Max { get; set; }
    }

    public class ItemDetail
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

        [JsonProperty(PropertyName = "requiredLevel")]
        public int RequiredLevel { get; set; }

        [JsonProperty(PropertyName = "itemLevel")]
        public int ItemLevel { get; set; }

        [JsonProperty(PropertyName = "stackSizeMax")]
        public int StackSizeMax { get; set; }

        [JsonProperty(PropertyName = "bonusAffixes")]
        public int BonusAffixes { get; set; }

        [JsonProperty(PropertyName = "bonusAffixesMax")]
        public int BonusAffixesMax { get; set; }

        [JsonProperty(PropertyName = "accountBound")]
        public bool AccountBound { get; set; }

        [JsonProperty(PropertyName = "flavorText")]
        public string FlavorText { get; set; }

        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        [JsonProperty(PropertyName = "type")]
        public Type Type { get; set; }

        [JsonProperty(PropertyName = "damageRange")]
        public string DamageRange { get; set; }

        [JsonProperty(PropertyName = "dps")]
        public MinMax Dps { get; set; }

        [JsonProperty(PropertyName = "attacksPerSecond")]
        public MinMax AttacksPerSecond { get; set; }

        [JsonProperty(PropertyName = "attacksPerSecondText")]
        public string AttacksPerSecondText { get; set; }

        [JsonProperty(PropertyName = "minDamage")]
        public MinMax MinDamage { get; set; }

        [JsonProperty(PropertyName = "maxDamage")]
        public MinMax MaxDamage { get; set; }

        [JsonProperty(PropertyName = "elementalType")]
        public string ElementalType { get; set; }

        [JsonProperty(PropertyName = "slots")]
        public string[] Slots { get; set; }
        
        [JsonProperty(PropertyName = "augmentation")]
        public string Augmentation { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty(PropertyName = "attributesRaw")]
        public Attributesraw AttributesRaw { get; set; }

        [JsonProperty(PropertyName = "randomAffixes")]
        public object[] RandomAffixes { get; set; }

        [JsonProperty(PropertyName = "gems")]
        public Gem[] Gems { get; set; }

        [JsonProperty(PropertyName = "socketEffects")]
        public object[] SocketEffects { get; set; }

        [JsonProperty(PropertyName = "craftedBy")]
        public object[] CraftedBy { get; set; }

        [JsonProperty(PropertyName = "seasonRequiredToDrop")]
        public int SeasonRequiredToDrop { get; set; }

        [JsonProperty(PropertyName = "isSeasonRequiredToDrop")]
        public bool IsSeasonRequiredToDrop { get; set; }

        [JsonProperty(PropertyName = "description")]
        public object Description { get; set; }

        [JsonProperty(PropertyName = "blockChance")]
        public string BlockChance { get; set; }
    }

    public class Type
    {
        [JsonProperty(PropertyName = "twoHanded")]
        public bool TwoHanded { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }

    public class Attributes
    {
        [JsonProperty(PropertyName = "primary")]
        public Attribute[] Primary { get; set; }

        [JsonProperty(PropertyName = "secondary")]
        public Attribute[] Secondary { get; set; }

        [JsonProperty(PropertyName = "passive")]
        public Attribute[] Passive { get; set; }
    }


    public class Attributesraw
    {
        [JsonProperty(PropertyName = "Damage_Weapon_MinPhysical")]
        public MinMax DamageWeaponMinPhysical { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_Bonus_Delta_X1Physical")]
        public MinMax DamageWeaponBonusDeltaX1Physical { get; set; }

        [JsonProperty(PropertyName = "Season")]
        public MinMax Season { get; set; }

        [JsonProperty(PropertyName = "Item_Power_PassiveP3_ItemPassive_Unique_Ring_005")]
        public MinMax ItemPowerPassiveP3ItemPassiveUniqueRing005 { get; set; }

        [JsonProperty(PropertyName = "Durability_Cur")]
        public MinMax DurabilityCur { get; set; }

        [JsonProperty(PropertyName = "Post_2_1_2_Drop")]
        public MinMax Post212Drop { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_DeltaPhysical")]
        public MinMax DamageWeaponDeltaPhysical { get; set; }

        [JsonProperty(PropertyName = "Bow")]
        public MinMax Bow { get; set; }

        [JsonProperty(PropertyName = "Post_2_5_0_Drop")]
        public MinMax Post250Drop { get; set; }

        [JsonProperty(PropertyName = "Sockets")]
        public MinMax Sockets { get; set; }

        [JsonProperty(PropertyName = "Item_LegendaryItem_Level_Override")]
        public MinMax ItemLegendaryItemLevelOverride { get; set; }

        [JsonProperty(PropertyName = "ConsumableAddSockets")]
        public MinMax ConsumableAddSockets { get; set; }

        [JsonProperty(PropertyName = "Resource_Max_BonusDiscipline")]
        public MinMax ResourceMaxBonusDiscipline { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_Bonus_Min_X1Physical")]
        public MinMax DamageWeaponBonusMinX1Physical { get; set; }

        [JsonProperty(PropertyName = "Attacks_Per_Second_Item")]
        public MinMax AttacksPerSecondItem { get; set; }

        [JsonProperty(PropertyName = "Ancient_Rank")]
        public MinMax AncientRank { get; set; }

        [JsonProperty(PropertyName = "Splash_Damage_Effect_Percent")]
        public MinMax SplashDamageEffectPercent { get; set; }

        [JsonProperty(PropertyName = "Resource_Cost_Reduction_Percent_All")]
        public MinMax ResourceCostReductionPercentAll { get; set; }

        [JsonProperty(PropertyName = "Durability_Max")]
        public MinMax DurabilityMax { get; set; }

        [JsonProperty(PropertyName = "Item_Binding_Level_Override")]
        public MinMax ItemBindingLevelOverride { get; set; }

        [JsonProperty(PropertyName = "Item_Legendary_Item_Base_Item")]
        public MinMax ItemLegendaryItemBaseItem { get; set; }

        [JsonProperty(PropertyName = "CubeEnchantedGemRank")]
        public MinMax CubeEnchantedGemRank { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_Percent_All")]
        public MinMax DamageWeaponPercentAll { get; set; }

        [JsonProperty(PropertyName = "Dexterity_Item")]
        public MinMax DexterityItem { get; set; }

        [JsonProperty(PropertyName = "Experience_Bonus")]
        public MinMax ExperienceBonus { get; set; }

        [JsonProperty(PropertyName = "Loot_2_0_Drop")]
        public MinMax Loot20Drop { get; set; }

        [JsonProperty(PropertyName = "Crit_Damage_Percent")]
        public MinMax CritDamagePercent { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_Delta#Cold")]
        public MinMax DamageWeaponDeltaCold { get; set; }

        [JsonProperty(PropertyName = "Item_Power_Passive#P4_ItemPassive_Unique_Ring_008")]
        public MinMax ItemPowerPassiveP4ItemPassiveUniqueRing008 { get; set; }

        [JsonProperty(PropertyName = "CubeEnchantedGemType")]
        public MinMax CubeEnchantedGemType { get; set; }

        [JsonProperty(PropertyName = "Damage_Weapon_Min#Cold")]
        public MinMax DamageWeaponMinCold { get; set; }

        [JsonProperty(PropertyName = "Attacks_Per_Second_Item_Percent")]
        public MinMax AttacksPerSecondItemPercent { get; set; }

    }

    public class Gem
    {
        [JsonProperty(PropertyName = "item")]
        public Item Item { get; set; }

        [JsonProperty(PropertyName = "isGem")]
        public bool IsGem { get; set; }

        [JsonProperty(PropertyName = "isJewel")]
        public bool IsJewel { get; set; }

        [JsonProperty(PropertyName = "attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty(PropertyName = "attributesRaw")]
        public Attributesraw AttributesRaw { get; set; }
    }

    public class Item
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
    }
}