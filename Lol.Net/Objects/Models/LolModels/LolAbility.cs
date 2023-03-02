namespace Lol.Net.Objects.Models.LolModels
{
    public record LolAbilities(LolAbility E, LolAbility Passive, LolAbility Q, LolAbility R, LolAbility W);
    public record LolAbility(int abilityLevel, string displayName, string id, string rawDescription, string rawDisplayName);
}
