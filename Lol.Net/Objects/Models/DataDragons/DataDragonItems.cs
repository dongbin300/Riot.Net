using Lol.Net.Objects.Models.LolModels;

namespace Lol.Net.Objects.Models.DataDragons
{
    public record DataDragonItems(string type, string version, Basic basic, IDictionary<string, LolItem?> data, IEnumerable<DataDragonItems_Group> groups, IEnumerable<DataDragonItems_Tree> tree);

    public record DataDragonItems_Group(string id, string MaxGroupOwnable);

    public record DataDragonItems_Tree(string header, IEnumerable<string> tags);
}
