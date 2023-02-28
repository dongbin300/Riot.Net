namespace Lol.Net.Objects.Models.LolModels
{
    public record LolSummonerSpell(
        string id,
        string name,
        string description,
        string tooltip,
        int maxrank,
        IList<int> cooldown,
        string cooldownBurn,
        IList<int> cost,
        string costBurn,
        Champion_Spell_Datavalues datavalues,
        IList<IList<decimal>> effect,
        IList<string> effectBurn,
        IList<object> vars,
        string key,
        int summonerLevel,
        IList<string> modes,
        string costType,
        string maxammo,
        IList<int> range,
        string rangeBurn,
        LolImage image,
        string resource
    );
}
