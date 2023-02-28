using Lol.Net.Objects.Models.LolModels;

namespace Lol.Net.Objects.Models.DataDragons
{
    public record DataDragonItems(string type, string version, Basic basic, Dictionary<string, LolItem?> data, IList<DataDragonItems_Group> groups, IList<DataDragonItems_Tree> tree);

    public record DataDragonItems_Group(string id, string MaxGroupOwnable);
    public record DataDragonItems_Tree(string header, IList<string> tags);
}
