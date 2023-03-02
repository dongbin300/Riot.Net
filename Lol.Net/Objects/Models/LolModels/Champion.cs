namespace Lol.Net.Objects.Models.LolModels
{
    public record Champion(string version, string id, string key, string name, string title, string blurb, Champion_Info info, LolImage image, IList<string> tags, string partype, Champion_Stats stats);
    public record ChampionDetail(string id, string key, string name, string title, LolImage image, IList<Champion_Skin> skins, string lore, string blurb, IList<string> allytips, IList<string> enemytips, IList<string> tags, string partype, Champion_Info info, Champion_Stats stats, IList<Champion_Spell> spells, Champion_Passive passive, IList<object> recommended);

    public record Champion_Info(int attack, int defense, int magic, int difficulty);

    public record Champion_Stats(decimal hp, decimal hpperlevel, decimal mp, decimal mpperlevel, int movespeed, int armor, decimal armorperlevel, int spellblock, decimal spellblockperlevel, int attackrange, decimal hpregen, decimal hpregenperlevel, decimal mpregen, decimal mpregenperlevel, int crit, int critperlevel, decimal attackdamage, decimal attackdamageperlevel, decimal attackspeedperlevel, decimal attackspeed);

    public record Champion_Skin();

    public record Champion_Spell(string id, string name, string description, string tooltip, Champion_Spell_Leveltip leveltip, int maxrank, IList<decimal> cooldown, string cooldownBurn, IList<int> cost, string costBurn, Champion_Spell_Datavalues datavalues, IList<IList<decimal>> effect, IList<string> effectBurn, IList<object> vars, string costType, string maxammo, IList<int> range, string rangeBurn, LolImage image, string resource);

    public record Champion_Spell_Leveltip(IList<string> label, IList<string> effect);

    public record Champion_Spell_Datavalues();

    public record Champion_Passive(string name, string description, LolImage image);
}
