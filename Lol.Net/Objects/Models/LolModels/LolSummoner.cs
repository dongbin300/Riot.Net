namespace Lol.Net.Objects.Models.LolModels
{
    public record LolSummonerSpell(
        string id,
        string name,
        string description,
        string tooltip,
        int maxrank,
        IEnumerable<int> cooldown,
        string cooldownBurn,
        IEnumerable<int> cost,
        string costBurn,
        Champion_Spell_Datavalues datavalues,
        IEnumerable<IEnumerable<decimal>> effect,
        IEnumerable<string> effectBurn,
        IEnumerable<object> vars,
        string key,
        int summonerLevel,
        IEnumerable<string> modes,
        string costType,
        string maxammo,
        IEnumerable<int> range,
        string rangeBurn,
        LolImage image,
        string resource
    );

    public record LolShortSummonerSpell(string displayName, string rawDescription, string rawDisplayName);

    public record LolShortSummonerSpells(LolShortSummonerSpell summonerSpellOne, LolShortSummonerSpell summonerSpellTwo);
}
