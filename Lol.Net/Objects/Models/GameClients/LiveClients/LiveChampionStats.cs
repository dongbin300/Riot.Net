namespace Lol.Net.Objects.Models.GameClients.LiveClients
{
    public record LiveChampionStats
    (
       double abilityHaste,
       double abilityPower,
       double armor,
       double armorPenetrationFlat,
       double armorPenetrationPercent,
       double attackDamage,
       double attackRange,
       double attackSpeed,
       double bonusArmorPenetrationPercent,
       double bonusMagicPenetrationPercent,
       double critChance,
       double critDamage,
       double currentHealth,
       double healShieldPower,
       double healthRegenRate,
       double lifeSteal,
       double magicLethality,
       double magicPenetrationFlat,
       double magicPenetrationPercent,
       double magicResist,
       double maxHealth,
       double moveSpeed,
       double omnivamp,
       double physicalLethality,
       double physicalVamp,
       double resourceMax,
       double resourceRegenRate,
       string resourceType,
       double resourceValue,
       double spellVamp,
       double tenacity
    );
}
