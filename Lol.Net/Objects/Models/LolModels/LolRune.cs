namespace Lol.Net.Objects.Models.LolModels
{
    public record LolKeystone(string displayName, int id, string rawDescription, string rawDisplayName);

    public record LolStatRune(int id, string rawDescription);

    public record LolRuneTree(string displayName, int id, string rawDescription, string rawDisplayName);

    public record LolRune(LolKeystone keystone, LolRuneTree primaryRuneTree, LolRuneTree secondaryRuneTree);

    public record LolFullRune(IEnumerable<LolRuneTree> generalRunes, LolKeystone keystone, LolRuneTree primaryRuneTree, LolRuneTree secondaryRuneTree, IEnumerable<LolStatRune> statRunes);
}
