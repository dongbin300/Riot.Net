﻿namespace Lol.Net.Objects.Models.LolModels
{
    public record LolItem(string name, string description, string colloq, string plaintext, IEnumerable<string> from, IEnumerable<string> into, LolImage image, Gold gold, IEnumerable<string> tags, Maps maps, Stats stats, int depth, Effect effect);

    public record LolLiveItem(bool canUse, bool consumable, int count, string displayName, int itemID, int price, string rawDescription, string rawDisplayName, int slot);

    public record Effect(string Effect1Amount, string Effect2Amount, string Effect3Amount, string Effect4Amount);

    public record Rune(bool isrune, int tier, string type);

    public record Gold(int @base, int total, int sell, bool purchasable);

    public record Stats(
        decimal FlatHPPoolMod,
        decimal rFlatHPModPerLevel,
        decimal FlatMPPoolMod,
        decimal rFlatMPModPerLevel,
        decimal PercentHPPoolMod,
        decimal PercentMPPoolMod,
        decimal FlatHPRegenMod,
        decimal rFlatHPRegenModPerLevel,
        decimal PercentHPRegenMod,
        decimal FlatMPRegenMod,
        decimal rFlatMPRegenModPerLevel,
        decimal PercentMPRegenMod,
        decimal FlatArmorMod,
        decimal rFlatArmorModPerLevel,
        decimal PercentArmorMod,
        decimal rFlatArmorPenetrationMod,
        decimal rFlatArmorPenetrationModPerLevel,
        decimal rPercentArmorPenetrationMod,
        decimal rPercentArmorPenetrationModPerLevel,
        decimal FlatPhysicalDamageMod,
        decimal rFlatPhysicalDamageModPerLevel,
        decimal PercentPhysicalDamageMod,
        decimal FlatMagicDamageMod,
        decimal rFlatMagicDamageModPerLevel,
        decimal PercentMagicDamageMod,
        decimal FlatMovementSpeedMod,
        decimal rFlatMovementSpeedModPerLevel,
        decimal PercentMovementSpeedMod,
        decimal rPercentMovementSpeedModPerLevel,
        decimal FlatAttackSpeedMod,
        decimal PercentAttackSpeedMod,
        decimal rPercentAttackSpeedModPerLevel,
        decimal rFlatDodgeMod,
        decimal rFlatDodgeModPerLevel,
        decimal PercentDodgeMod,
        decimal FlatCritChanceMod,
        decimal rFlatCritChanceModPerLevel,
        decimal PercentCritChanceMod,
        decimal FlatCritDamageMod,
        decimal rFlatCritDamageModPerLevel,
        decimal PercentCritDamageMod,
        decimal FlatBlockMod,
        decimal PercentBlockMod,
        decimal FlatSpellBlockMod,
        decimal rFlatSpellBlockModPerLevel,
        decimal PercentSpellBlockMod,
        decimal FlatEXPBonus,
        decimal PercentEXPBonus,
        decimal rPercentCooldownMod,
        decimal rPercentCooldownModPerLevel,
        decimal rFlatTimeDeadMod,
        decimal rFlatTimeDeadModPerLevel,
        decimal rPercentTimeDeadMod,
        decimal rPercentTimeDeadModPerLevel,
        decimal rFlatGoldPer10Mod,
        decimal rFlatMagicPenetrationMod,
        decimal rFlatMagicPenetrationModPerLevel,
        decimal rPercentMagicPenetrationMod,
        decimal rPercentMagicPenetrationModPerLevel,
        decimal FlatEnergyRegenMod,
        decimal rFlatEnergyRegenModPerLevel,
        decimal FlatEnergyPoolMod,
        decimal rFlatEnergyModPerLevel,
        decimal PercentLifeStealMod,
        decimal PercentSpellVampMod);

    public record Maps(bool _1, bool _2, bool _3, bool _4, bool _8, bool _10, bool _11, bool _12, bool _14, bool _16, bool _18, bool _19, bool _20, bool _21, bool _22);

    public record Basic(
        string name,
        Rune rune,
        Gold gold,
        string group,
        string description,
        string colloq,
        string plaintext,
        bool consumed,
        int stacks,
        int depth,
        bool consumeOnFull,
        IEnumerable<object> from,
        IEnumerable<object> into,
        int specialRecipe,
        bool inStore,
        bool hideFromAll,
        string requiredChampion,
        string requiredAlly,
        Stats stats,
        IEnumerable<object> tags,
        Maps maps);
}
