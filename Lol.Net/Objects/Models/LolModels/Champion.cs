namespace Lol.Net.Objects.Models.LolModels
{
    public record Champion(string version, string id, string key, string name, string title, string blurb, ChampionInfo info, LolImage image, IEnumerable<string> tags, string partype, ChampionStats stats);

    public record ChampionDetail(string id, string key, string name, string title, LolImage image, IEnumerable<ChampionSkin> skins, string lore, string blurb, IEnumerable<string> allytips, IEnumerable<string> enemytips, IEnumerable<string> tags, string partype, ChampionInfo info, ChampionStats stats, IEnumerable<ChampionSpell> spells, ChampionPassive passive, IEnumerable<object> recommended);

    public record ChampionInfo(int attack, int defense, int magic, int difficulty);

    public record ChampionStats(decimal hp, decimal hpperlevel, decimal mp, decimal mpperlevel, int movespeed, int armor, decimal armorperlevel, int spellblock, decimal spellblockperlevel, int attackrange, decimal hpregen, decimal hpregenperlevel, decimal mpregen, decimal mpregenperlevel, int crit, int critperlevel, decimal attackdamage, decimal attackdamageperlevel, decimal attackspeedperlevel, decimal attackspeed);
   
    public record ChampionSkin();

    public record ChampionSpell(string id, string name, string description, string tooltip, ChampionSpellLeveltip leveltip, int maxrank, IEnumerable<decimal> cooldown, string cooldownBurn, IEnumerable<int> cost, string costBurn, ChampionSpellDatavalues datavalues, IEnumerable<IEnumerable<decimal>> effect, IEnumerable<string> effectBurn, IEnumerable<object> vars, string costType, string maxammo, IEnumerable<int> range, string rangeBurn, LolImage image, string resource);

    public record ChampionSpellLeveltip(IEnumerable<string> label, IEnumerable<string> effect);

    public record ChampionSpellDatavalues();

    public record ChampionPassive(string name, string description, LolImage image);
}
